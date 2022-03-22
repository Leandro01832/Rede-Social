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
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuProjetoAgora.Controllers
{
    public class PedidoController : Controller
    {
        private readonly ApplicationDbContext Context;

        public IRepositoryPedido RepositoryPedido { get; }
        public IRepositoryPagina epositoryPagina { get; }
        public IHttpHelper HttpHelper { get; }
        public IHttpContextAccessor ContextAccessor { get; }
        public IUserHelper UserHelper { get; }
        public UserManager<UserModel> UserManager { get; }
        public HostingEnvironment HostingEnvironment;

        public PedidoController(ApplicationDbContext context, IRepositoryPedido repositoryPedido,
            IRepositoryPagina repositoryPagina, IHttpHelper httpHelper, IHttpContextAccessor contextAccessor,
            IUserHelper userHelper, HostingEnvironment hostingEnvironment,
            UserManager<UserModel> userManager)
        {
            HostingEnvironment = hostingEnvironment;
            Context = context;
            RepositoryPedido = repositoryPedido;
            epositoryPagina = repositoryPagina;
            HttpHelper = httpHelper;
            ContextAccessor = contextAccessor;
            UserHelper = userHelper;
            UserManager = userManager;
        }

        
        public async Task<IActionResult> Index()
        {
            var option = Request.Cookies["automatico"];
            var option2 = Request.Cookies["story"];
            if (option == null)
                Set("automatico", "0", 12);
            if (option2 == null)
                Set("story", "0", 12);
            IList<Pagina> pages = await epositoryPagina.MostrarPageModels();
            List<Pagina> pages2 = new List<Pagina>();
            foreach (var p in pages.Where(p => p.Exibicao == true))
            {
                p.Html = await epositoryPagina.renderizarPagina(p);
                pages2.Add(p);
            }

            ViewBag.quantidade = pages.Count();

            return View(pages2);
        }

        [Route("Criar")]
        [Route("Create")]
        [Route("Cadastrar")]
        [Route("Inserir")]
        [Route("ViewCreate")]
        public IActionResult ViewCreate()
        {
            return View();
        }

        

        [Route("Galeria/{id}")]
        [Route("Galeria/{id}/{pagina?}")]
        [Route("Pedido/Galeria/{id}")]
        [Route("Paginas-de-um-site/{id}")]
        [Route("Paginas-do-site/{id}")]
        [Route("Paginas/{id}")]
        public async Task<ActionResult> Galeria(string id, int? pagina)
        {
            int numeroPagina = (pagina ?? 1);
            const int TAMANHO_PAGINA = 5;

            ViewBag.pagina = numeroPagina;
            ViewBag.site = id;
            var applicationDbContext = await Context.Pagina
                .Where(l => l.UserId == id)
                .Skip((numeroPagina - 1) * TAMANHO_PAGINA)
                .Take(TAMANHO_PAGINA).ToListAsync();

            
            return View(applicationDbContext);
        }

        [Authorize(Roles = "Admin")]
        public async Task<FileResult> Baixar(string id)
        {
            var site1 = await UserManager.Users.FirstAsync(p => p.Id == id);
            var finalResult = epositoryPagina.FazerDownload(site1.Id);

            return File(finalResult, "application/zip", site1.UserName);

        }

        [Authorize]
        [Route("Pedido/CreatePagina")]
        [Route("CreatePage")]
        [Route("Criar-Pagina")]
        [Route("CriarPagina")]
        public async Task<ActionResult> CreatePagina()
        {
            var usuario = await UserManager.GetUserAsync(this.User);
            var stories = await Context.Story.ToListAsync();

            ViewBag.StoryId = new SelectList(stories, "Id", "Nome");
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
            var usuario = await UserManager.GetUserAsync(this.User);
            var stories = await Context.Story.ToListAsync();

            if (ModelState.IsValid)
            {
                await Context.Pagina.AddAsync(pagina);
                await Context.SaveChangesAsync();
                HttpHelper.SetPedidoId(pagina.Id);

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

                RepositoryPagina.paginas.Clear();
                var lista = await epositoryPagina.MostrarPageModels();
                RepositoryPagina.paginas.AddRange(lista.Where(l => ! l.Layout).ToList());

                return RedirectToAction("Galeria", new { id = pagina.UserId });
            }
            
            ViewBag.StoryId = new SelectList(stories, "Id", "Nome", pagina.StoryId);
            return View(pagina);
        }

        [Route("Buscar/{dominio}/{extensao}")]
        public IActionResult Buscar(string dominio, string extensao)
        {
            if (dominio.Contains(' ') || dominio == null)
            {
                ViewBag.erro = "Não pode haver espaços no dominio e dominio não pode ser vazio";
                return View("Create");
            }
            dominio.Replace("www.", "");
            dominio.Replace(".", "");
            dominio.Replace("https://", "");
            dominio.Replace("http://", "");
            var client = new RestClient($"https://api.promptapi.com/whois/check?domain={dominio}{extensao}");
            client.Timeout = -1;

            var request = new RestRequest(Method.GET);
            request.AddHeader("apikey", "8x2bc41bcJxbKJnIY8OJAIc6ws4fc3xU");

            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);

            if (response.Content.Contains("registered"))
            {
                ViewBag.negativo = "este dominio não esta disponível";
                RepositoryPedido.SalvarDominioExistente(dominio + extensao);
            }
            else
            {
                ViewBag.positivo = "este dominio esta disponível";
            }

            return View("Create");
        }



        private ActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }

        private void Set(string key, string value, int? expireTime)
        {
            CookieOptions option = new CookieOptions();

            if (expireTime.HasValue)
                option.Expires = DateTime.Now.AddHours(expireTime.Value);
            else
                option.Expires = DateTime.Now.AddHours(10);

            option.HttpOnly = false;

            Response.Cookies.Append(key, value, option);
        }
    }
}
