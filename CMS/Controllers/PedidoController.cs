using business.Back;
using business.business;
using business.div;
using business.Join;
using CMS.Data;
using CMS.Models;
using CMS.Models.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MeuProjetoAgora.Controllers
{
    public class PedidoController : Controller
    {
        private readonly ApplicationDbContext Context;        
        public IRepositoryPagina epositoryPagina { get; }
        public IHttpHelper HttpHelper { get; }
        public IHttpContextAccessor ContextAccessor { get; }
        public IUserHelper UserHelper { get; }
        public UserManager<UserModel> UserManager { get; }
        public HostingEnvironment HostingEnvironment;

        public PedidoController(ApplicationDbContext context, IRepositoryPagina repositoryPagina,
            IHttpHelper httpHelper, IHttpContextAccessor contextAccessor,
            IUserHelper userHelper, HostingEnvironment hostingEnvironment,
            UserManager<UserModel> userManager)
        {
            HostingEnvironment = hostingEnvironment;
            Context = context;
            epositoryPagina = repositoryPagina;
            HttpHelper = httpHelper;
            ContextAccessor = contextAccessor;
            UserHelper = userHelper;
            UserManager = userManager;
        }
                               
        [Authorize]
        [Route("Galeria/{pagina?}")]
        public async Task<ActionResult> Galeria(int? pagina)
        {
            var user = await UserManager.GetUserAsync(this.User);
            int numeroPagina = (pagina ?? 1);
            const int TAMANHO_PAGINA = 5;

            ViewBag.pagina = numeroPagina;
            var applicationDbContext = await Context.Pagina.Include(l => l.Story)
                .Where(l => l.UserId == user.Id)
                .Skip((numeroPagina - 1) * TAMANHO_PAGINA)
                .Take(TAMANHO_PAGINA).ToListAsync();
            
            return View(applicationDbContext);
        }        

        [Authorize]
        [Route("Pedido/CreatePagina")]
        [Route("CreatePage")]
        [Route("Criar-Pagina")]
        [Route("CriarPagina")]
        public async Task<ActionResult> CreatePagina()
        {
            var user = await UserManager.GetUserAsync(this.User);
            var stories = await Context.Story.Where(str => str.UserId == user.Id && str.Nome != "Padrao").ToListAsync();

            if(stories.Count == 0)
            {
                ViewBag.Error = "Crie seu story primeiro!!!";
                RedirectToAction("Create", "Story");
            }

            ViewBag.UserId = user.Id;
            ViewBag.StoryId = new SelectList(stories, "Id", "CapituloComNome");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        [Route("Pedido/CreatePagina")]
        [Route("CreatePage")]
        [Route("Criar-Pagina")]
        [Route("CriarPagina")]
        public async Task<ActionResult> CreatePagina(Pagina pagina)
        {
            var user = await UserManager.GetUserAsync(this.User);
            var stories = await Context.Story.Where(str => str.UserId == user.Id).ToListAsync();

            if (ModelState.IsValid)
            {
                await Context.Pagina.AddAsync(pagina);
                await Context.SaveChangesAsync();
                HttpHelper.SetPaginaId(pagina.Id);

                for (int i = 0; i <= 5; i++)
                {
                    DivComum div = new DivComum();
                    div.Pagina_ = pagina.Id;
                    if (i < 3)
                        div.Background = new BackgroundImagem
                        {
                            Background_Position = "",
                            Background_Repeat = "repeat",
                            Imagem = Context.Imagem.ToList()[i]
                        };
                    else
                        div.Background = new BackgroundCor
                        {
                            backgroundTransparente = true,
                            Cor = "transparent"
                        };

                    await Context.Div.AddAsync(div);
                    await Context.SaveChangesAsync();

                    Context.DivPagina.Add(new DivPagina { DivId = div.Id, PaginaId = pagina.Id });
                    await Context.SaveChangesAsync();
                }

                RepositoryPagina.paginas.Add(pagina);

                return RedirectToAction("Galeria", new { id = pagina.UserId });
            }
            
            ViewBag.StoryId = new SelectList(stories, "Id", "CapituloComNome", pagina.StoryId);
            return View(pagina);
        }
        
        private ActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }
        
    }
}
