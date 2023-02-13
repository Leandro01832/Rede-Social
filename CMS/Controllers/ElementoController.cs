﻿using business.Back;
using business.business;
using business.business.carousel;
using business.business.Elementos;
using business.business.Elementos.element;
using business.business.Elementos.imagem;
using business.business.Elementos.texto;
using business.business.link;
using business.div;
using business.Join;
using CMS.Data;
using CMS.Models;
using CMS.Models.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Controllers
{
    public class ElementoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public IRepositoryElemento RepositoryElemento { get; }
        public IRepositoryDiv RepositoryDiv { get; }
        public UserManager<UserModel> UserManager { get; }
        public IHttpHelper HttpHelper { get; }
        public IUserHelper UserHelper { get; }
        public IRepositoryPagina epositoryPagina { get; }

        public ElementoController(ApplicationDbContext context, IRepositoryElemento repositoryElemento,
            IRepositoryDiv repositoryDiv, UserManager<UserModel> userManager, IHttpHelper httpHelper,
            IUserHelper userHelper, IRepositoryPagina repositoryPagina)
        {
            _context = context;
            RepositoryElemento = repositoryElemento;
            RepositoryDiv = repositoryDiv;
            UserManager = userManager;
            HttpHelper = httpHelper;
            UserHelper = userHelper;
            epositoryPagina = repositoryPagina;
        }

        [Route("Elemento/Lista/{dados}")]
        public async Task<IActionResult> Lista(string dados)
        {
            var arr = dados.Split('-');
            var numero = Int64.Parse(arr[1]);
            var user = await UserManager.GetUserAsync(this.User);

            var tipo = arr[0].Replace("GaleriaElemento", "");
            List<Elemento> lista = await _context.Elemento
                .Include(e => e.Imagem)
                .Include(e => e.Texto)
                .Include(e => e.Formulario)
                .Include(e => e.Dependentes).ThenInclude(e => e.Elemento)
                .Include(e => e.Dependentes).ThenInclude(e => e.ElementoDependente)
                .Include(e => e.Paginas).ThenInclude(e => e.Pagina)
                .Include(e => e.Paginas).ThenInclude(e => e.Elemento)
                .Where(e => e.GetType().Name == tipo).ToListAsync();

            Pagina pagina = new Pagina(1);
            pagina.FlexDirection = "column";
            pagina.AlignItems = "stretch";
            pagina.MostrarDados = 1;
            pagina.Div.First(d => d.Container.Content).Container.Div
                      .First(d => d.Div.Content).Div.Elemento = new List<DivElemento>();
            pagina.Div.First(d => d.Container.Content).Container.Div
                      .First(d => d.Div.Content).Div.FlexDirection = "row";
            pagina.Div.First(d => d.Container.Content).Container.Div
                      .First(d => d.Div.Content).Div.JustifyContent = "space-between";
            pagina.Div.First(d => d.Container.Content).Container.Div
                     .First(d => d.Div.Content).Div.Width = 100;
            pagina.Div.First(d => d.Container.Content).Container.Div
                    .First(d => d.Div.Content).Div.AlignItems = "center";

            foreach (var item in lista)
            pagina.Div.First(d => d.Container.Content).Container.Div
                      .First(d => d.Div.Content).Div.Elemento.Add
                      (new DivElemento
                        {
                            Div = pagina.Div.First(d => d.Container.Content).Container.Div
                            .First(d => d.Div.Content).Div,
                            Elemento = item
                        }
                      );

            string html =  epositoryPagina.renderizarPagina(pagina);
            ViewBag.Html = html;
            return PartialView(pagina);
        }

        [Route("Elemento/Create/{elemento}/{pagina}")]
        public async Task<IActionResult> Create(string elemento, Int64 pagina)
        {
            var page = await _context.Pagina.Include(p => p.Story)
            .ThenInclude(p => p.Pagina).FirstAsync(p => p.Id == pagina);
            var usuario = await UserManager.GetUserAsync(this.User);
            
            ViewBag.elemento = elemento;

            var claims = User.Claims.ToList();
            var roles = "";
            foreach (var v in claims)
            {
                roles += v.Value + ", ";
            }

            Elemento ele = null;

            if (elemento == "Imagem") ele = new Imagem();
            if (elemento == "Video") ele = new Video();
            if (elemento == "Texto") ele = new Texto();
            if (elemento == "LinkBody") ele = new LinkBody();
            if (elemento == "Formulario") ele = new Formulario();
            if (elemento == "CarouselPagina") ele = new CarouselPagina();
            if (elemento == "CarouselImg") ele = new CarouselImg();
            if (elemento == "Campo") ele = new Campo();

           // var pedido = await UserManager.Users.FirstAsync(p => p.Id == page.UserId);
            var elementos = new List<Elemento>();
            var els = await _context.Elemento.Where(elem => elem.Pagina_ == pagina).ToListAsync();

            List<Pagina> lista = new List<Pagina>();
            lista.Add(new Pagina { Id = 0, Titulo = "[[ Escolha uma pagina ]]" });

            lista.AddRange(page.Story.Pagina);
            ViewBag.PaginaEscolhida = new SelectList(lista, "Id", "Titulo");

            elementos.AddRange(els);

            ViewBag.condicao = !page.Layout;

            PreencherCombo(ele, elementos);

            return PartialView(ele);
        }
        
        public async Task<IActionResult> Edit(Int64? id)
        {
            var usuario = await UserManager.GetUserAsync(this.User);
            var pedido = await UserManager.Users.FirstAsync(p => p.Id == usuario.Id);
            var elementos = new List<Elemento>();

            Elemento elemento;

            var claims = User.Claims.ToList();
            var roles = "";
            foreach (var v in claims)
            {
                roles += v.Value + ", ";
            }

            try
            {
                elemento = await RepositoryElemento.includes()
                .FirstAsync(e => e.Id == id);
            }
            catch (Exception)
            {
                return RedirectToAction("NaoEncontrado");
            }


            if (elemento == null)
            {
                return NotFound();
            }

            var els = await _context.Elemento.Where(ele => ele.Pagina_ == elemento.Pagina_).ToListAsync();

            elementos.AddRange(els);

            List<Pagina> lista = new List<Pagina>();
            lista.Add(new Pagina { Id = 0, Titulo = "[[ Escolha uma pagina ]]" });
            var paginas = await _context.Pagina.Where(p => !p.Layout).ToListAsync();
            lista.AddRange(paginas);
            if (elemento.PaginaEscolhida == null) elemento.PaginaEscolhida = 0;
            ViewBag.PaginaEscolhida = new SelectList(lista, "Id", "Titulo", elemento.PaginaEscolhida);

            bool condicao = false;
            if(elemento.PaginaEscolhida != null) condicao = true;
            ViewBag.condicao = condicao;

            PreencherCombo(elemento, elementos);

            return PartialView(elemento);
        }

        #region Create-Edit-Elemento
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<string> _Imagem([FromBody] Imagem elemento)
        {
            try
            {
                if (elemento.Id == 0)
                    return await RepositoryElemento.salvar(elemento);
                else
                    return await RepositoryElemento.Editar(elemento);
            }
            catch (Exception ex) { return ex.Message; }
        }        

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<string> _Video([FromBody] Video elemento)
        {
            try
            {
                if (elemento.Id == 0)
                    return await RepositoryElemento.salvar(elemento);
                else
                    return await RepositoryElemento.Editar(elemento);
            }
            catch (Exception ex) { return ex.Message; }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<string> _Texto([FromBody] Texto elemento)
        {
            try
            {
                if (elemento.Id == 0)
                    return await RepositoryElemento.salvar(elemento);
                else
                    return await RepositoryElemento.Editar(elemento);
            }
            catch (Exception ex) { return ex.Message; }
        }

        

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<string> _LinkBody([FromBody] LinkBody elemento)
        {
            try
            {
                if (elemento.Id == 0)
                    return await RepositoryElemento.salvar(elemento);
                else
                    return await RepositoryElemento.Editar(elemento);
            }
            catch (Exception ex) { return ex.Message; }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<string> _Formulario([FromBody] Formulario elemento)
        {
            try
            {
                if (elemento.Id == 0)
                    return await RepositoryElemento.salvar(elemento);
                else
                    return await RepositoryElemento.Editar(elemento);
            }
            catch (Exception ex) { return ex.Message; }
        }        

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<string> _CarouselPagina([FromBody] CarouselPagina elemento)
        {
            try
            {
                if (elemento.Id == 0)
                    return await RepositoryElemento.salvar(elemento);
                else
                    return await RepositoryElemento.Editar(elemento);
            }
            catch (Exception ex) { return ex.Message; }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<string> _CarouselImg([FromBody] CarouselImg elemento)
        {
            try
            {
                if (elemento.Id == 0)
                    return await RepositoryElemento.salvar(elemento);
                else
                    return await RepositoryElemento.Editar(elemento);
            }
            catch (Exception ex) { return ex.Message; }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<string> _Campo([FromBody] Campo elemento)
        {
            try
            {
                if (elemento.Id == 0)
                    return await RepositoryElemento.salvar(elemento);
                else
                    return await RepositoryElemento.Editar(elemento);
            }
            catch (Exception ex) { return ex.Message; }
        }
        #endregion        

        public IActionResult NoPermission()
        {
            return PartialView();
        }

        public IActionResult NaoEncontrado()
        {
            return PartialView();
        }

        private void PreencherCombo(Elemento elemento, List<Elemento> elementos)
        {
            if (elemento is LinkBody)
            {
                var els = new List<Elemento>();
                els.Add(new Imagem { Id = 0, Nome = "[[ Escolha uma imagem ]]" });
                els.AddRange(elementos.OfType<Imagem>().ToList());
                var link = (LinkBody)elemento;
                ViewBag.ImagemId = new SelectList(els, "Id", "NomeComId", link.ImagemId);
                ViewBag.TextoId = new SelectList(elementos.OfType<Texto>().ToList(), "Id", "NomeComId", link.TextoId);
            }

            if (elemento is Campo)
            {
                var c = (Campo)elemento;
                ViewBag.FormularioId = new SelectList(elementos.OfType<Formulario>().ToList(), "Id", "NomeComId", c.FormularioId);
            }

        }
    }
}