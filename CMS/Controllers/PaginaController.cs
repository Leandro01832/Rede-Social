﻿using business.business;
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
        public IRepositoryPedido RepositoryPedido { get; }
        public IRepositoryPagina epositoryPagina { get; }
        public IHttpHelper HttpHelper { get; }
        public IHttpContextAccessor ContextAccessor { get; }
        public UserManager<UserModel> UserManager { get; }
        public IUserHelper UserHelper { get; }


        public PaginaController(ApplicationDbContext context, IRepositoryPedido repositoryPedido,
            IRepositoryPagina repositoryPagina, IHttpHelper httpHelper, IHttpContextAccessor contextAccessor,
            UserManager<UserModel> userManager, IUserHelper userHelper)
        {
            db = context;
            RepositoryPedido = repositoryPedido;
            epositoryPagina = repositoryPagina;
            HttpHelper = httpHelper;
            ContextAccessor = contextAccessor;
            UserManager = userManager;
            UserHelper = userHelper;
        }

        [AllowAnonymous]
        public ActionResult EmBranco()
        {
            return PartialView();
        }

        [AllowAnonymous]
        public async Task<ActionResult> QuantidadeBloco(int div)
        {
            var bloco = await db.DivElemento
                .Include(de => de.Elemento)
                .Include(de => de.Div)
                .Where(d => d.Div.Id == div).ToListAsync();

            ViewBag.Quantidade = bloco.Count;
            return PartialView();
        }

        [AllowAnonymous]
        public async Task<ActionResult> IdentificacaoBloco(int div)
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


        [Route("{story}/{id}")]
        public async Task<IActionResult> RenderizarDinamico(string story, int id)
        {
            var Story = story.Replace("Story-", "").Replace("-Pagina", "");

            ViewBag.story = Story;

            // var lista = Pagina.paginas;
            ViewBag.stories = db.Story.ToList();
            var lista = RepositoryPagina.paginas.Where(p => p.Story.Nome == Story).ToList();

            ViewBag.quantidadePaginas = lista.Count();

            if (id > 0)
            {
                Pagina pagina = lista.Skip((int)id - 1).FirstOrDefault();

                if (pagina == null || pagina.Id == 1) pagina = lista.Skip((int)id).FirstOrDefault();

                if (pagina == null)
                {
                    ViewBag.paginas = new SelectList(new List<Pagina>(), "Id", "Titulo");
                    ViewBag.numeroErro = id;
                    return View("HttpNotFound");
                }
                else
                {
                    HttpHelper.SetPedidoId(pagina.Id);
                    string html = await epositoryPagina.renderizarPaginaComCarousel(pagina);
                    ViewBag.Html = html;
                    pagina.Html = html;
                }

                if (pagina.Id == 2)
                    ViewBag.proximo = 3;
                else
                    ViewBag.proximo = id + 1;
                return View(pagina);
            }
            return HttpNotFound();
        }

        [Route("Editar/{id?}")]
        public async Task<IActionResult> Editar(int? id)
        {
            if (id == 1) id = 2;

            var lista = await BuscarPaginas();
            Pagina pagina = lista.FirstOrDefault(p => p.Id == id);

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
                HttpHelper.SetPedidoId(pagina.Id);
                string html = await epositoryPagina.renderizarPaginaComCarousel(pagina);
                ViewBag.Html = html;
                pagina.Html = html;
            }

            ViewBag.proximo = id + 1;
            return View(pagina);
        }

        [AllowAnonymous]
        public async Task<ActionResult> GetView(int? id)
        {
            var lista = await BuscarPaginas();
            Pagina pagina = lista.FirstOrDefault(p => p.Id == id);

            if (pagina == null)
            {
                ViewBag.numeroErro = id;
                return View("HttpNotFound");
            }
            ViewBag.html = await epositoryPagina.renderizarPagina(pagina);

            return PartialView("GetView");
        }

        

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Salvar(int id)
        {
            var lista = await BuscarPaginas();
            RepositoryPagina.paginas.Clear();
            RepositoryPagina.paginas.AddRange(lista.Where(l => ! l.Layout).ToList());
            Pagina pag = lista.FirstOrDefault(p => p.Id == id);

            epositoryPagina.criandoArquivoHtml(pag);
            ViewBag.html = epositoryPagina.renderizarPagina(pag);

            return Content("Salvo com sucesso");
        }

        public async Task<List<Pagina>> BuscarPaginas()
        {
            var lista = await epositoryPagina.MostrarPageModels();
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
        public async Task<IActionResult> EditarPagina(int id)
        {

            var pagina = db.Pagina
            .Include(p => p.Div)
            .ThenInclude(p => p.Div)
            .First(p => p.Id == id);
            var usuario = await UserManager.GetUserAsync(this.User);
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
        public async Task<IActionResult> GaleriaLayout(int Id, int? pagina)
        {
            int numeroPagina = (pagina ?? 1);
            const int TAMANHO_PAGINA = 3;

            var page = await db.Pagina.FirstAsync(p => p.Id == Id);

            ViewBag.pagina = numeroPagina;
            ViewBag.site = Id;
            var applicationDbContext = await db.Pagina
                .Where(l => l.UserId == page.UserId && l.Layout)
                .Skip((numeroPagina - 1) * TAMANHO_PAGINA)
                .Take(TAMANHO_PAGINA).ToListAsync();

            return PartialView(applicationDbContext);
        }

        [Authorize(Roles = "Pagina")]
        public async Task<IActionResult> CreatePaginaComLayout(int Id)
        {
            var page = await db.Pagina.FirstAsync(p => p.Id == Id);
            ViewBag.condicao = page.Layout;
            ViewBag.pagina = Id;
            return PartialView();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Pagina")]
        public async Task<IActionResult> CreatePaginaComLayout(int IdPagina, int Loop)
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