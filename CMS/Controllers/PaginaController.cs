using business.business;
using business.Join;
using CMS.Data;
using CMS.Models;
using CMS.Models.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuProjetoAgora.Controllers
{
    public class PaginaController : Controller
    {
        private readonly ApplicationDbContext db;
        public IRepositoryPagina epositoryPagina { get; }
        public IHttpHelper HttpHelper { get; }
        public IHttpContextAccessor ContextAccessor { get; }
        public UserManager<UserModel> UserManager { get; }
        public IUserHelper Helper { get; }


        public PaginaController(ApplicationDbContext context, IRepositoryPagina repositoryPagina,
            IHttpHelper httpHelper, IHttpContextAccessor contextAccessor,
            UserManager<UserModel> userManager, IUserHelper userHelper)
        {
            db = context;
            epositoryPagina = repositoryPagina;
            HttpHelper = httpHelper;
            ContextAccessor = contextAccessor;
            UserManager = userManager;
            Helper = userHelper;
        }

        [AllowAnonymous]
        public ActionResult EmBranco()
        {
            return PartialView();
        }

        [AllowAnonymous]
        public async Task<ActionResult> QuantidadeBloco(Int64 div)
        {
            var bloco = await db.DivElemento
                .Include(de => de.Elemento)
                .Include(de => de.Div)
                .Where(d => d.Div.Id == div).ToListAsync();

            ViewBag.Quantidade = bloco.Count;
            return PartialView();
        }

        [AllowAnonymous]
        public async Task<ActionResult> IdentificacaoBloco(Int64 div)
        {
            var bloco = await db.DivElemento
                .Include(de => de.Elemento)
                .Include(de => de.Div)
                .Where(d => d.Div.Id == div).ToListAsync();

            ViewBag.Quantidade = bloco.Count;
            ViewBag.id = div;
            return PartialView();
        }

        [AllowAnonymous]
        public ActionResult IdentificacaoElemento(int elemento)
        {
            ViewBag.id = elemento;
            return PartialView();
        }

        [Route("Renderizar/{Name}/{story}/{indice}")]
        [Route("capitulo/{Name}/{capitulo?}/{indice}")]
        [Route("padrao/{Name}/{capitulo?}/{indice}")]
        public async Task<IActionResult> Renderizar(string Name, string story, int indice, int? capitulo)
        {
            var user = UserHelper.Users.FirstOrDefault(u => u.Name.ToLower() == Name.Trim().ToLower());
            if (user == null)
            {
                user = await UserManager.Users.FirstOrDefaultAsync(u => u.Name.ToLower() == Name.Trim().ToLower());
                UserHelper.Users.Add(user);
            }

            if (RepositoryPagina.paginas.FirstOrDefault(p => p.UserId == user.Id) == null)
            {
                RepositoryPagina.paginas.RemoveAll(p => p.UserId == user.Id);
               var lst = await BuscarPaginas(user.Id);
               var quant = lst.Where(l => !l.Layout && !l.LayoutModelo).ToList().Count;
                RepositoryPagina.paginas.AddRange(lst.Where(l => !l.Layout && !l.LayoutModelo).ToList());

                if (RepositoryPagina.paginas.Where(p => p.UserId == user.Id &&
                !p.Layout && !p.LayoutModelo).ToList().Count != quant)
                {
                    RepositoryPagina.paginas.RemoveAll(p => p.UserId == user.Id);
                    RepositoryPagina.paginas.AddRange(lst.Where(l => !l.Layout && !l.LayoutModelo).ToList());
                }
            }

            ViewBag.user = user.Name;

            var lista = new List<Pagina>();
            if (capitulo == null)
                lista = RepositoryPagina.paginas.Where(p => p.Story.Nome == story && p.Story.UserId == user.Id).ToList();
            else
                lista = RepositoryPagina.paginas.Where(p => p.Story.PaginaPadraoLink == capitulo && p.Story.UserId == user.Id).ToList();

            ViewBag.quantidadePaginas = lista.Count();

            Pagina pagina = lista.Skip((int)indice - 1).FirstOrDefault();            

            if (pagina == null)
            {
                ViewBag.paginas = new SelectList(new List<Pagina>(), "Id", "Titulo");
                ViewBag.numeroErro = indice;
                return View("HttpNotFound");
            }
            else
            {
                ViewBag.story = pagina.Story.Nome;
                string html = await epositoryPagina.renderizarPaginaComCarousel(pagina);
                ViewBag.Html = html;
            }

            
                ViewBag.proximo = indice + 1;
            return View(pagina);

        }

        [Route("Editar/{id?}")]
        public async Task<IActionResult> Editar(Int64? id)
        {
            if (id == 1) id = 2;

            Pagina pagina = await epositoryPagina.includes().FirstOrDefaultAsync(p => p.Id == id);


            if (pagina == null)
            {
                ViewBag.paginas = new SelectList(new List<Pagina>(), "Id", "Nome");
                ViewBag.numeroErro = id;
                return View("HttpNotFound");
            }
            else
            {
                ViewBag.IdPagina = id;
                ViewBag.IdSite = pagina.UserId;
                HttpHelper.SetPaginaId(pagina.Id);
                string html = await epositoryPagina.renderizarPaginaComCarousel(pagina);
                ViewBag.Html = html;
            }

            ViewBag.proximo = id + 1;
            return View(pagina);
        }

        [AllowAnonymous]
        public async Task<ActionResult> GetView(Int64? id)
        {
            Pagina pagina = await epositoryPagina.includes().FirstOrDefaultAsync(p => p.Id == id);

            if (pagina == null)
            {
                ViewBag.numeroErro = id;
                return View("HttpNotFound");
            }
            ViewBag.html = await epositoryPagina.renderizarPagina(pagina);

            return PartialView("GetView");
        }



        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Salvar(Int64 id)
        {
            Pagina pag = await epositoryPagina.includes().FirstOrDefaultAsync(p => p.Id == id);
            var lista = await BuscarPaginas(pag.UserId);
            RepositoryPagina.paginas.RemoveAll(p => p.UserId == pag.UserId);
            RepositoryPagina.paginas.AddRange(lista.Where(l => !l.Layout && !l.LayoutModelo).ToList());


            return Content("Salvo com sucesso");
        }

        public async Task<List<Pagina>> BuscarPaginas(string userId)
        {
            var lista = await epositoryPagina.MostrarPageModels(userId);
            return lista.ToList();
        }

        public string RemoveAccents(string text)
        {
            StringBuilder sbReturn = new StringBuilder();
            var arrayText = text.Normalize(NormalizationForm.FormD).ToCharArray();
            foreach (char letter in arrayText)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(letter) != UnicodeCategory.NonSpacingMark)
                    sbReturn.Append(letter);
            }
            return sbReturn.ToString();
        }

        public IActionResult HttpNotFound()
        {
            return View();
        }

        [Authorize(Roles = "Pagina")]
        public IActionResult EditarPagina(Int64 id)
        {

            var pagina = db.Pagina
            .Include(p => p.Div)
            .ThenInclude(p => p.Div)
            .First(p => p.Id == id);
            ViewBag.StoryId = new SelectList(db.Story.ToList(), "Id", "Nome", pagina.StoryId);


            var elements = "";

            foreach (var ele in pagina.Div.Skip(6))
            {
                elements += ele.Div.Id.ToString() + ", ";
            }

            ViewBag.elementos = elements;
            return PartialView(pagina);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Pagina")]
        public async Task<string> EditarPagina([FromBody]Pagina pagina)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(pagina);
                    await db.SaveChangesAsync();

                    var Pagina = await db.Pagina
                        .Include(p => p.Div)
                        .ThenInclude(p => p.Div)
                        .FirstAsync(p => p.Id == pagina.Id);

                    await epositoryPagina.BlocosdaPagina(Pagina);

                }
                catch (Exception ex)
                {
                    return "Erro!!!" + ex.Message;

                }
                return "";
            }
            return "Erro!!!";
        }

        [Authorize(Roles = "Pagina")]
        [Route("Pagina/GaleriaLayout/{Id}/{pagina?}")]
        public async Task<IActionResult> GaleriaLayout(int? pagina)
        {
            var user = await UserManager.GetUserAsync(this.User);
            int numeroPagina = (pagina ?? 1);
            const int TAMANHO_PAGINA = 3;


            ViewBag.pagina = numeroPagina;
            var applicationDbContext = await db.Pagina
                .Where(l => l.UserId == user.Id && l.Layout)
                .Skip((numeroPagina - 1) * TAMANHO_PAGINA)
                .Take(TAMANHO_PAGINA).ToListAsync();

            return PartialView(applicationDbContext);
        }

        [Authorize(Roles = "Pagina")]
        public async Task<IActionResult> CreatePaginaComLayout(Int64 IdPagina)
        {
            var page = await db.Pagina.FirstAsync(p => p.Id == IdPagina);
            ViewBag.condicao = page.Layout;
            ViewBag.pagina = IdPagina;
            return PartialView();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Pagina")]
        public async Task<IActionResult> CreatePaginaComLayout(Int64 IdPagina, int Loop)
        {
            var pag2 = await epositoryPagina.includes().FirstAsync(p => p.Id == IdPagina);

            for (int i = 1; i <= Loop; i++)
            {
                var pag = new Pagina();

                foreach (var item in pag.GetType().GetProperties().Where(p => p.Name != "NomeComId" && p.Name != "Tipo"))
                    item.SetValue(pag, item.GetValue(pag2));
                pag.Id = 0;
                pag.CarouselPagina = new List<PaginaCarouselPagina>();
                pag.Div = new List<DivPagina>();
                pag.UserId = pag2.UserId;
                pag.Story = null;
                pag.Layout = false;

                await db.Pagina.AddAsync(pag);

                await db.SaveChangesAsync();

                pag.Div = new List<DivPagina>();
                foreach (var item in pag2.Div)
                {
                    pag.Div.Add(new DivPagina { DivId = item.DivId, PaginaId = pag.Id });
                }
                await db.SaveChangesAsync();
            }
            ViewBag.condicao = true;
            ViewBag.pagina = IdPagina;
            return PartialView();
        }

        public IActionResult NoPermission()
        {
            return PartialView();
        }


    }
}