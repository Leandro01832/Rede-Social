using business.business;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;
using CMS.Models.Repository;
using CMS.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data.SqlClient;
using business.business.Group;
using Microsoft.Extensions.Configuration;
using CMS.Data;
using business.Join;
using business.business.Elementos.texto;
using Microsoft.AspNetCore.Authorization;
using business.business.link;

namespace MeuProjetoAgora.Controllers
{
    public class VisualizarController : Controller
    {
        private readonly ApplicationDbContext db;
        public IRepositoryPagina epositoryPagina { get; }
        public UserManager<UserModel> UserManager { get; }
        public IConfiguration Configuration { get; }

        public VisualizarController(IRepositoryPagina repositoryPagina, UserManager<UserModel> userManager,
         IConfiguration configuration, ApplicationDbContext context)
        {
            db = context;
            epositoryPagina = repositoryPagina;
            UserManager = userManager;
            Configuration = configuration;
        }
        

         [Route("Renderizar/{capitulo?}/{indice}/{auto}/{compartilhante}")]
        public async Task<IActionResult> Renderizar( int indice, int? capitulo, int auto, string compartilhante)
        {           
            await Verificar(capitulo);
            var lista = RepositoryPagina.paginas.Where(p => p.Story.PaginaPadraoLink == capitulo && !p.Layout).ToList();
            Pagina pagina = lista.Skip((int)indice - 1).FirstOrDefault();
    

            if (pagina == null)
            {
                ViewBag.paginas = new SelectList(new List<Pagina>(), "Id", "Titulo");
                ViewBag.numeroErro = indice;
                return View("HttpNotFound");

            }            
            
            ViewBag.quantidadePaginas = lista.Count();
            ViewBag.story = pagina.Story.Nome;
            string html = "";
            if(pagina.Div.Count > 0)
            {
                if(!string.IsNullOrEmpty(pagina.Sobreescrita))
                html = pagina.Sobreescrita;
                else
                html =  epositoryPagina.renderizarPagina(pagina);
            }
            else
            html = Pagina.Capa;
            ViewBag.Html = html;
            ViewBag.proximo = indice + 1;
            ViewBag.compartilhante = compartilhante;
            ViewBag.auto = auto;

            if(pagina.Comentario != null)
            {
                var page = RepositoryPagina.paginas.FirstOrDefault(p => p.Id == pagina.Comentario);
                if(page == null)
                {
                    page = db.Pagina.Include(p => p.Story).First(p => p.Id == pagina.Comentario);
                    await Verificar(page.Story.PaginaPadraoLink);
                    page = RepositoryPagina.paginas.FirstOrDefault(p => p.Id == pagina.Comentario);
                }
                ViewBag.CapituloComentario = page.Story.PaginaPadraoLink;
                var paginas = RepositoryPagina.paginas
                .Where(p => p.Story.PaginaPadraoLink == page.Story.PaginaPadraoLink)
                .OrderBy(p => p.Id)
                .ToList();
                ViewBag.VersoComentario = paginas.IndexOf(page) + 1;
            }

            return View(pagina);            
        }

        

        [Route("SubStory/{capitulo?}/{substory}/{indice}/{auto}/{compartilhante}")]
         public async Task<IActionResult> SubStory( int indice, int? capitulo, int substory, int auto, string compartilhante)
        {
            await Verificar(capitulo);
            var lista = RepositoryPagina.paginas.Where(p => p.Story.PaginaPadraoLink == capitulo && !p.Layout).ToList();
            Pagina pag = lista.First();

            var group = pag.Story.SubStory.Where(str => str.Pagina.Count > 0).Skip((int)substory - 1).First();
            Pagina pag2 = group.Pagina.Where(p => !p.Layout).Skip((int)indice - 1).First();



            Pagina pagina = lista.First(p => p.Id == pag2.Id);
            int vers = lista.IndexOf(pagina) + 1;



            ViewBag.quantidadePaginas = group.Pagina.Count(p => !p.Layout);
            ViewBag.group = group;
            ViewBag.versiculo = vers;
            ViewBag.grupoindexsubstory = substory;
            ViewBag.story = pagina.Story.Nome;
            string html = "";
            if (!string.IsNullOrEmpty(pagina.Sobreescrita))
                html = pagina.Sobreescrita;
            else
                html = epositoryPagina.renderizarPagina(pagina);
            ViewBag.Html = html;
            ViewBag.proximo = indice + 1;
            ViewBag.compartilhante = compartilhante;
            ViewBag.auto = auto;
            return View(pagina);
        }        

        [Route("Grupo/{capitulo?}/{substory}/{grupo}/{indice}/{auto}/{compartilhante}")]
         public async Task<IActionResult> Grupo( int indice, int? capitulo, int substory, int grupo, int auto, string compartilhante)
        {             
             await Verificar(capitulo);
            var lista = RepositoryPagina.paginas.Where(p => p.Story.PaginaPadraoLink == capitulo && !p.Layout).ToList();
            Pagina pag = lista.First();

            var group = pag.Story.SubStory.Where(str => str.Pagina.Count > 0).Skip((int)substory - 1).First(); 
             var group2 = group.Grupo.Where(str => str.Pagina.Count > 0).Skip((int)grupo - 1).First(); 
            Pagina pag2 = group2.Pagina.Where(p => ! p.Layout).Skip((int)indice - 1).First();
           
             Pagina pagina = lista.First(p => p.Id == pag2.Id);
             int vers = lista.IndexOf(pagina) + 1;          
            
                ViewBag.quantidadePaginas = group2.Pagina.Count(p => ! p.Layout);
                ViewBag.group = group2;
                 ViewBag.versiculo = vers;
                 ViewBag.grupoindexsubstory = substory;
                 ViewBag.grupoindexgrupo = grupo;
                ViewBag.story = pagina.Story.Nome;
                string html = "";
                if(!string.IsNullOrEmpty(pagina.Sobreescrita))
                html = pagina.Sobreescrita;
                else
                html =  epositoryPagina.renderizarPagina(pagina);
                ViewBag.Html = html;
                ViewBag.proximo = indice + 1;
                ViewBag.compartilhante = compartilhante;
                ViewBag.auto = auto;
                return View(pagina);            
        }

         [Route("SubGrupo/{capitulo?}/{substory}/{grupo}/{subgrupo}/{indice}/{auto}/{compartilhante}")]
         public async Task<IActionResult> SubGrupo(int indice, int? capitulo, int substory, int grupo, int subgrupo, int auto, string compartilhante)
        {
             await Verificar(capitulo);
             var lista = RepositoryPagina.paginas.Where(p => p.Story.PaginaPadraoLink == capitulo && !p.Layout).ToList();
            Pagina pag = lista.First();

            var group = pag.Story.SubStory.Where(str => str.Pagina.Count > 0).Skip((int)substory - 1).First(); 
             var group2 = group.Grupo.Where(str => str.Pagina.Count > 0).Skip((int)grupo - 1).First(); 
             var group3 = group2.SubGrupo.Where(str => str.Pagina.Count > 0).Skip((int)subgrupo - 1).First(); 
            Pagina pag2 = group3.Pagina.Where(p => ! p.Layout).Skip((int)indice - 1).First();
            
             Pagina pagina = lista.First(p => p.Id == pag2.Id);
             int vers = lista.IndexOf(pagina) + 1;                       
            
                ViewBag.quantidadePaginas = group3.Pagina.Count(p => ! p.Layout);
                ViewBag.group = group3;
                ViewBag.versiculo = vers;
                ViewBag.grupoindexsubstory = substory;
                 ViewBag.grupoindexgrupo = grupo;
                ViewBag.grupoindexsubgrupo = subgrupo;
                ViewBag.story = pagina.Story.Nome;
                string html = "";
                if(!string.IsNullOrEmpty(pagina.Sobreescrita))
                html = pagina.Sobreescrita;
                else
                html =  epositoryPagina.renderizarPagina(pagina);
                ViewBag.Html = html;
                ViewBag.proximo = indice + 1;
                ViewBag.compartilhante = compartilhante;
                ViewBag.auto = auto;
                return View(pagina);            
        }

         [Route("SubSubGrupo/{capitulo?}/{substory}/{grupo}/{subgrupo}/{subsubgrupo}/{indice}/{auto}/{compartilhante}")]
         public async Task<IActionResult> SubSubGrupo(string Name, int indice, int? capitulo, int substory, int grupo, int subgrupo, int subsubgrupo, int auto, string compartilhante)
        {
             await Verificar(capitulo);
             var lista = RepositoryPagina.paginas.Where(p => p.Story.PaginaPadraoLink == capitulo && !p.Layout).ToList();
            Pagina pag = lista.First();

            var group = pag.Story.SubStory.Where(str => str.Pagina.Count > 0).Skip((int)substory - 1).First(); 
             var group2 = group.Grupo.Where(str => str.Pagina.Count > 0).Skip((int)grupo - 1).First(); 
             var group3 = group2.SubGrupo.Where(str => str.Pagina.Count > 0).Skip((int)subgrupo - 1).First(); 
              var group4 = group3.SubSubGrupo.Where(str => str.Pagina.Count > 0).Skip((int)subsubgrupo - 1).First(); 
            Pagina pag2 = group4.Pagina.Where(p => ! p.Layout).Skip((int)indice - 1).First();
            
             Pagina pagina = lista.First(p => p.Id == pag2.Id);
             int vers = lista.IndexOf(pagina) + 1;                    
            
                ViewBag.quantidadePaginas = group4.Pagina.Count(p => ! p.Layout);
                ViewBag.group = group4;
                ViewBag.versiculo = vers;
                ViewBag.grupoindexsubstory = substory;
                ViewBag.grupoindexgrupo = grupo;
                ViewBag.grupoindexsubgrupo = subgrupo;
                ViewBag.grupoindexsubsubgrupo = subsubgrupo;
                ViewBag.story = pagina.Story.Nome;
                string html = "";
                if(!string.IsNullOrEmpty(pagina.Sobreescrita))
                html = pagina.Sobreescrita;
                else
                html =  epositoryPagina.renderizarPagina(pagina);
                ViewBag.Html = html;
                ViewBag.proximo = indice + 1;
                ViewBag.compartilhante = compartilhante;
                return View(pagina);            
        }    
         
         [Route("CamadaSeis/{capitulo?}/{substory}/{grupo}/{subgrupo}/{subsubgrupo}/{camadaseis}/{indice}/{auto}/{compartilhante}")]
         public async Task<IActionResult> CamadaSeis(string Name, int indice, int? capitulo, int substory,
          int grupo, int subgrupo, int subsubgrupo, int camadaseis, int auto, string compartilhante)
        {
             await Verificar(capitulo);
             var lista = RepositoryPagina.paginas.Where(p => p.Story.PaginaPadraoLink == capitulo && !p.Layout).ToList();
            Pagina pag = lista.First();

            var group = pag.Story.SubStory.Where(str => str.Pagina.Count > 0).Skip((int)substory - 1).First(); 
             var group2 = group.Grupo.Where(str => str.Pagina.Count > 0).Skip((int)grupo - 1).First(); 
             var group3 = group2.SubGrupo.Where(str => str.Pagina.Count > 0).Skip((int)subgrupo - 1).First(); 
              var group4 = group3.SubSubGrupo.Where(str => str.Pagina.Count > 0).Skip((int)subsubgrupo - 1).First(); 
              var group5 = group4.CamadaSeis.Where(str => str.Pagina.Count > 0).Skip((int)camadaseis - 1).First(); 
            Pagina pag2 = group5.Pagina.Where(p => ! p.Layout).Skip((int)indice - 1).First();
            
             Pagina pagina = lista.First(p => p.Id == pag2.Id);
             int vers = lista.IndexOf(pagina) + 1;                    
            
                ViewBag.quantidadePaginas = group5.Pagina.Count(p => ! p.Layout);
                ViewBag.group = group5;
                ViewBag.versiculo = vers;
                ViewBag.grupoindexsubstory = substory;
                ViewBag.grupoindexgrupo = grupo;
                ViewBag.grupoindexsubgrupo = subgrupo;
                ViewBag.grupoindexsubsubgrupo = subsubgrupo;
                ViewBag.grupoindexcamadaseis = camadaseis;
                ViewBag.story = pagina.Story.Nome;
                string html = "";
                if(!string.IsNullOrEmpty(pagina.Sobreescrita))
                html = pagina.Sobreescrita;
                else
                html =  epositoryPagina.renderizarPagina(pagina);
                ViewBag.Html = html;
                ViewBag.proximo = indice + 1;
                ViewBag.compartilhante = compartilhante;
                return View(pagina);            
        }    
         
         [Route("CamadaSete/{capitulo?}/{substory}/{grupo}/{subgrupo}/{subsubgrupo}/{camadaseis}/{camadasete}/{indice}/{auto}/{compartilhante}")]
         public async Task<IActionResult> CamadaSete(string Name, int indice, int? capitulo, int substory,
          int grupo, int subgrupo, int subsubgrupo, int camadaseis, int camadasete, int auto, string compartilhante)
        {
             await Verificar(capitulo);
             var lista = RepositoryPagina.paginas.Where(p => p.Story.PaginaPadraoLink == capitulo && !p.Layout).ToList();
            Pagina pag = lista.First();

            var group = pag.Story.SubStory.Where(str => str.Pagina.Count > 0).Skip((int)substory - 1).First(); 
             var group2 = group.Grupo.Where(str => str.Pagina.Count > 0).Skip((int)grupo - 1).First(); 
             var group3 = group2.SubGrupo.Where(str => str.Pagina.Count > 0).Skip((int)subgrupo - 1).First(); 
              var group4 = group3.SubSubGrupo.Where(str => str.Pagina.Count > 0).Skip((int)subsubgrupo - 1).First(); 
              var group5 = group4.CamadaSeis.Where(str => str.Pagina.Count > 0).Skip((int)camadaseis - 1).First(); 
              var group6 = group5.CamadaSete.Where(str => str.Pagina.Count > 0).Skip((int)camadasete - 1).First(); 
            Pagina pag2 = group6.Pagina.Where(p => ! p.Layout).Skip((int)indice - 1).First();
            
             Pagina pagina = lista.First(p => p.Id == pag2.Id);
             int vers = lista.IndexOf(pagina) + 1;                    
            
                ViewBag.quantidadePaginas = group6.Pagina.Count(p => ! p.Layout);
                ViewBag.group = group6;
                ViewBag.versiculo = vers;
                ViewBag.grupoindexsubstory = substory;
                ViewBag.grupoindexgrupo = grupo;
                ViewBag.grupoindexsubgrupo = subgrupo;
                ViewBag.grupoindexsubsubgrupo = subsubgrupo;
                ViewBag.grupoindexcamadaseis = camadaseis;
                ViewBag.grupoindexcamadasete = camadasete;
                ViewBag.story = pagina.Story.Nome;
                string html = "";
                if(!string.IsNullOrEmpty(pagina.Sobreescrita))
                html = pagina.Sobreescrita;
                else
                html =  epositoryPagina.renderizarPagina(pagina);
                ViewBag.Html = html;
                ViewBag.proximo = indice + 1;
                ViewBag.compartilhante = compartilhante;
                return View(pagina);            
        }    
         
         [Route("CamadaOito/{capitulo?}/{substory}/{grupo}/{subgrupo}/{subsubgrupo}/{camadaseis}/{camadasete}/{camadaoito}/{indice}/{auto}/{compartilhante}")]
         public async Task<IActionResult> CamadaOito(string Name, int indice, int? capitulo, int substory,
          int grupo, int subgrupo, int subsubgrupo, int camadaseis, int camadasete, int camadaoito, int auto, string compartilhante)
        {
             await Verificar(capitulo);
             var lista = RepositoryPagina.paginas.Where(p => p.Story.PaginaPadraoLink == capitulo && !p.Layout).ToList();
            Pagina pag = lista.First();

            var group = pag.Story.SubStory.Where(str => str.Pagina.Count > 0).Skip((int)substory - 1).First(); 
             var group2  = group.Grupo.Where(str => str.Pagina.Count > 0).Skip((int)grupo - 1).First(); 
             var group3  = group2.SubGrupo.Where(str => str.Pagina.Count > 0).Skip((int)subgrupo - 1).First(); 
              var group4 = group3.SubSubGrupo.Where(str => str.Pagina.Count > 0).Skip((int)subsubgrupo - 1).First(); 
              var group5 = group4.CamadaSeis.Where(str => str.Pagina.Count > 0).Skip((int)camadaseis - 1).First(); 
              var group6 = group5.CamadaSete.Where(str => str.Pagina.Count > 0).Skip((int)camadasete - 1).First(); 
              var group7 = group6.CamadaOito.Where(str => str.Pagina.Count > 0).Skip((int)camadaoito - 1).First(); 
            Pagina pag2 = group7.Pagina.Where(p => ! p.Layout).Skip((int)indice - 1).First();
            
             Pagina pagina = lista.First(p => p.Id == pag2.Id);
             int vers = lista.IndexOf(pagina) + 1;                    
            
                ViewBag.quantidadePaginas = group7.Pagina.Count(p => ! p.Layout);
                ViewBag.group = group7;
                ViewBag.versiculo = vers;
                ViewBag.grupoindexsubstory = substory;
                ViewBag.grupoindexgrupo = grupo;
                ViewBag.grupoindexsubgrupo = subgrupo;
                ViewBag.grupoindexsubsubgrupo = subsubgrupo;
                ViewBag.grupoindexcamadaseis = camadaseis;
                ViewBag.grupoindexcamadasete = camadasete;
                ViewBag.grupoindexcamadaoito = camadaoito;
                ViewBag.story = pagina.Story.Nome;
                string html = "";
                if(!string.IsNullOrEmpty(pagina.Sobreescrita))
                html = pagina.Sobreescrita;
                else
                html =  epositoryPagina.renderizarPagina(pagina);
                ViewBag.Html = html;
                ViewBag.proximo = indice + 1;
                ViewBag.compartilhante = compartilhante;
                return View(pagina);            
        }    
        
         [Route("CamadaNove/{capitulo?}/{substory}/{grupo}/{subgrupo}/{subsubgrupo}/{camadaseis}/{camadasete}/{camadaoito}/{camadanove}/{indice}/{auto}/{compartilhante}")]
         public async Task<IActionResult> CamadaNove(string Name, int indice, int? capitulo, int substory,
          int grupo, int subgrupo, int subsubgrupo, int camadaseis, int camadasete, int camadaoito,
           int camadanove, int auto, string compartilhante)
        {
             await Verificar(capitulo);
             var lista = RepositoryPagina.paginas.Where(p => p.Story.PaginaPadraoLink == capitulo && !p.Layout).ToList();
            Pagina pag = lista.First();

            var group = pag.Story.SubStory.Where(str => str.Pagina.Count > 0).Skip((int)substory - 1).First(); 
             var group2  = group.Grupo.Where(str => str.Pagina.Count > 0).Skip((int)grupo - 1).First(); 
             var group3  = group2.SubGrupo.Where(str => str.Pagina.Count > 0).Skip((int)subgrupo - 1).First(); 
              var group4 = group3.SubSubGrupo.Where(str => str.Pagina.Count > 0).Skip((int)subsubgrupo - 1).First(); 
              var group5 = group4.CamadaSeis.Where(str => str.Pagina.Count > 0).Skip((int)camadaseis - 1).First(); 
              var group6 = group5.CamadaSete.Where(str => str.Pagina.Count > 0).Skip((int)camadasete - 1).First(); 
              var group7 = group6.CamadaOito.Where(str => str.Pagina.Count > 0).Skip((int)camadaoito - 1).First(); 
              var group8 = group7.CamadaNove.Where(str => str.Pagina.Count > 0).Skip((int)camadanove - 1).First(); 
            Pagina pag2 = group8.Pagina.Where(p => ! p.Layout).Skip((int)indice - 1).First();
            
             Pagina pagina = lista.First(p => p.Id == pag2.Id);
             int vers = lista.IndexOf(pagina) + 1;                    
            
                ViewBag.quantidadePaginas = group8.Pagina.Count(p => ! p.Layout);
                ViewBag.group = group8;
                ViewBag.versiculo = vers;
                ViewBag.grupoindexsubstory = substory;
                ViewBag.grupoindexgrupo = grupo;
                ViewBag.grupoindexsubgrupo = subgrupo;
                ViewBag.grupoindexsubsubgrupo = subsubgrupo;
                ViewBag.grupoindexcamadaseis = camadaseis;
                ViewBag.grupoindexcamadasete = camadasete;
                ViewBag.grupoindexcamadaoito = camadaoito;
                ViewBag.grupoindexcamadanove = camadanove;
                ViewBag.story = pagina.Story.Nome;
                string html = "";
                if(!string.IsNullOrEmpty(pagina.Sobreescrita))
                html = pagina.Sobreescrita;
                else
                html =  epositoryPagina.renderizarPagina(pagina);
                ViewBag.Html = html;
                ViewBag.proximo = indice + 1;
                ViewBag.compartilhante = compartilhante;
                return View(pagina);            
        }    
        
         [Route("CamadaDez/{capitulo?}/{substory}/{grupo}/{subgrupo}/{subsubgrupo}/{camadaseis}/{camadasete}/{camadaoito}/{camadanove}/{camadadez}/{indice}/{auto}/{compartilhante}")]
         public async Task<IActionResult> CamadaDez(string Name, int indice, int? capitulo, int substory,
          int grupo, int subgrupo, int subsubgrupo, int camadaseis, int camadasete, int camadaoito,
           int camadanove, int camadadez, int auto, string compartilhante)
        {
             await Verificar(capitulo);
             var lista = RepositoryPagina.paginas.Where(p => p.Story.PaginaPadraoLink == capitulo && !p.Layout).ToList();
            Pagina pag = lista.First();

            var group = pag.Story.SubStory.Where(str => str.Pagina.Count > 0).Skip((int)substory - 1).First(); 
             var group2  = group.Grupo.Where(str => str.Pagina.Count > 0).Skip((int)grupo - 1).First(); 
             var group3  = group2.SubGrupo.Where(str => str.Pagina.Count > 0).Skip((int)subgrupo - 1).First(); 
              var group4 = group3.SubSubGrupo.Where(str => str.Pagina.Count > 0).Skip((int)subsubgrupo - 1).First(); 
              var group5 = group4.CamadaSeis.Where(str => str.Pagina.Count > 0).Skip((int)camadaseis - 1).First(); 
              var group6 = group5.CamadaSete.Where(str => str.Pagina.Count > 0).Skip((int)camadasete - 1).First(); 
              var group7 = group6.CamadaOito.Where(str => str.Pagina.Count > 0).Skip((int)camadaoito - 1).First(); 
              var group8 = group7.CamadaNove.Where(str => str.Pagina.Count > 0).Skip((int)camadanove - 1).First(); 
              var group9 = group8.CamadaDez.Where(str => str.Pagina.Count > 0).Skip((int)camadadez - 1).First(); 
            Pagina pag2 = group9.Pagina.Where(p => ! p.Layout).Skip((int)indice - 1).First();
            
             Pagina pagina = lista.First(p => p.Id == pag2.Id);
             int vers = lista.IndexOf(pagina) + 1;                    
            
                ViewBag.quantidadePaginas = group9.Pagina.Count(p => ! p.Layout);
                ViewBag.group = group9;
                ViewBag.versiculo = vers;
                ViewBag.grupoindexsubstory = substory;
                ViewBag.grupoindexgrupo = grupo;
                ViewBag.grupoindexsubgrupo = subgrupo;
                ViewBag.grupoindexsubsubgrupo = subsubgrupo;
                ViewBag.grupoindexcamadaseis = camadaseis;
                ViewBag.grupoindexcamadasete = camadasete;
                ViewBag.grupoindexcamadaoito = camadaoito;
                ViewBag.grupoindexcamadanove = camadanove;
                ViewBag.grupoindexcamadadez = camadadez;
                ViewBag.story = pagina.Story.Nome;
                string html = "";
                if(!string.IsNullOrEmpty(pagina.Sobreescrita))
                html = pagina.Sobreescrita;
                else
                html =  epositoryPagina.renderizarPagina(pagina);
                ViewBag.Html = html;
                ViewBag.proximo = indice + 1;
                ViewBag.compartilhante = compartilhante;
                return View(pagina);            
        }    

        [Route("Comentarios/{Id}/{indice}")]
        public async Task<IActionResult> Comentarios(long Id, int indice)
        { 
            if(await db.Comentario.FirstOrDefaultAsync(p => p.IdPagina == Id) != null)
            {
                var lista = await db.Comentario
                .Where(p => p.IdPagina == Id)
                .OrderBy(p => p.Id)
                .ToListAsync();

                var comentario =  lista.Skip(indice - 1).First();

                var story = await db.Story
                .Include(str => str.Pagina)
                .FirstAsync(str => str.PaginaPadraoLink == comentario.Capitulo);
                var page = story.Pagina.OrderBy(p => p.Id).Skip(comentario.Verso - 1).First();
                ViewBag.html = epositoryPagina.renderizarPagina(page);
                ViewBag.quant = lista.Count;
                ViewBag.PaginaComentada = Id;
                ViewBag.proximo = indice + 1;

            return View(page);            
            }          
            
            return View();            
        } 


        public IActionResult HttpNotFound()
        {
            return View();
        }  

        
        private static int buscarCount(SqlConnection con, SqlCommand cmd, Type item, string conexao, int? capitulo)
        {
           
            var _TotalRegistros = 0;
            try
            {
                using (con = new SqlConnection(conexao))
                {
                    cmd = new SqlCommand($"SELECT COUNT(*) FROM Story where PaginaPadraoLink={capitulo}", con);
                    con.Open();
                    _TotalRegistros = int.Parse(cmd.ExecuteScalar().ToString());
                    con.Close();
                }
            }
            catch (Exception)
            {
                _TotalRegistros = 0;
            }
            return _TotalRegistros;
        }
       
        private static int CountComentarios(SqlConnection con, SqlCommand cmd, Type item, string conexao)
        {
           
            var _TotalRegistros = 0;
            try
            {
                using (con = new SqlConnection(conexao))
                {
                    cmd = new SqlCommand($"SELECT COUNT(*) FROM Pagina as P inner join Story as S on P.StoryId=S.Id  where S.Comentario='True'", con);
                    con.Open();
                    _TotalRegistros = int.Parse(cmd.ExecuteScalar().ToString());
                    con.Close();
                }
            }
            catch (Exception)
            {
                _TotalRegistros = 0;
            }
            return _TotalRegistros;
        }

        private async Task Verificar(int? capitulo)
        {
             var quant  = buscarCount(null, null, new Story().GetType(),
              Configuration.GetConnectionString("DefaultConnection"), capitulo);
             var comentarios  = CountComentarios(null, null, new Story().GetType(),
              Configuration.GetConnectionString("DefaultConnection"));

              if(RepositoryPagina.paginas.Where(p => p.Story.Comentario).ToList().Count != comentarios)
              {
                RepositoryPagina.paginas.RemoveAll(p => p.Story.Comentario);
                RepositoryPagina.paginas.AddRange(await epositoryPagina.includes()
                .Where(p => p.Story.Comentario).ToListAsync());
              }

            if(
                RepositoryPagina.paginas.Where(p => p.Story.PaginaPadraoLink ==
                capitulo && !p.Layout).ToList().Count == 0 ||
                quant != RepositoryPagina.paginas.Where(p => p.Story.PaginaPadraoLink ==
                capitulo && !p.Layout).ToList().Count
              )
             {                
                RepositoryPagina.paginas.RemoveAll(p => p.Story.PaginaPadraoLink == capitulo);
                RepositoryPagina.paginas.AddRange(await epositoryPagina.includes()
                .Where(p => p.Story.PaginaPadraoLink == capitulo && !p.Layout).OrderBy(p => p.Id).ToListAsync());
             }
        }

         [Authorize]
        [Route("Comentar/{idPagina?}")]
        public async Task <IActionResult> Comentar( long? idPagina)
        {
            if(idPagina != null)
            ViewBag.idPagina = idPagina;
            else
            ViewBag.idPagina = 0;

            
            var lista = await db.Comentario.Where(c => c.IdPagina == idPagina)
            .OrderBy(c => c.Id)
            .ToListAsync();
            var lista2 = new List<string>();

            foreach(var item in lista)
            {
                var p = RepositoryPagina.paginas
                .Where(pa => pa.Story.PaginaPadraoLink == item.Capitulo)
                .OrderBy(pa => pa.Id)
                .Skip(item.Verso - 1).First();
                var html = epositoryPagina
                .renderizarPagina(p);
                lista2.Add( html + $" <hr /> <p> Capitulo {item.Capitulo} Verso {item.Verso}  </p>" );
            }

            ViewBag.comentarios = lista2;

            return PartialView(lista2);
        }        

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<ComentarioUsuario> FazerComentario([FromBody]ComentarioUsuario comentario)
        {
            if(comentario.IdPagina == 0)
            return
             new ComentarioUsuario
             {
                 IdPagina = 0,
                  Conteudo = "",
                   Message = "Erro ao fazer comentário!!!"
             };
            
            var user = await UserManager.GetUserAsync(this.User);
            var Quant = await db.Story.Where(st => st.Nome != "Padrao").ToListAsync();
            var comenta = await db.Story.Include(st => st.Pagina)
            .Where(st => st.Comentario)
            .OrderBy(st => st.Id)
            .ToListAsync();
            var Story = comenta.LastOrDefault();

            if (Story == null || Story.Pagina.Where(p => !p.Layout).ToList().Count > 499)
            {
                Story = new Story
                {
                    Nome = "Comentario " + (comenta.Count + 1),
                    Comentario = true,
                    PaginaPadraoLink = Quant.Count + 1

                };
                db.Add(Story);
                db.SaveChanges();

                var str = await db.Story.FirstAsync(st => st.Nome == "Padrao");

                var p = new Pagina()
                {
                    Data = DateTime.Now,
                    ArquivoMusic = "",
                    Titulo = "Story - " + str.Nome,
                    CarouselPagina = new List<PaginaCarouselPagina>(),
                    StoryId = str.Id,
                    Sobreescrita = null,
                    SubStoryId = null,
                    GrupoId = null,
                    SubGrupoId = null,
                    SubSubGrupoId = null,
                    Layout = false,
                    Music = false,
                    Tempo = 11000
                };
                p.Div = null;

                db.Add(p);
                db.SaveChanges();

                var pagi = new Pagina(1);
                pagi.Div.First(d => d.Container.Content).Container.Div
                .First(d => d.Div.Content).Div.Elemento = new List<DivElemento>();
                pagi.Div.First(d => d.Container.Content).Container.Div
                .First(d => d.Div.Content).Div.Elemento.Add(new DivElemento
                {
                    Div = pagi.Div.First(d => d.Container.Content).Container.Div
                    .First(d => d.Div.Content).Div,
                    Elemento = new LinkBody
                    {
                        Pagina_ = p.Id,
                        TextoLink = "#LinkPadrao",
                        Texto = new Texto
                        {
                            Pagina_ = p.Id,
                            PalavrasTexto = "<h1> Story " + Story.Nome + "</h1>"
                        },
                    }
                });

                p.Div = new List<PaginaContainer>();
                foreach (var item in pagi.Div)
                    p.IncluiDiv(item.Container);
                db.SaveChanges();
            }

            var pagina = new Pagina()
            {
                Data = DateTime.Now,
                ArquivoMusic = "",
                Titulo = "Story - " + Story.Nome,
                CarouselPagina = new List<PaginaCarouselPagina>(),
                StoryId = Story.Id,
                Sobreescrita = null,
                SubStoryId = null,
                GrupoId = null,
                SubGrupoId = null,
                SubSubGrupoId = null,
                Layout = false,
                Music = false,
                Tempo = 11000,
                Comentario = comentario.IdPagina
            };
            pagina.Div = null;

            db.Add(pagina);
            db.SaveChanges();

            var pagin = new Pagina(1);
            pagin.Div.First(d => d.Container.Content).Container.Div
            .First(d => d.Div.Content).Div.Elemento = new List<DivElemento>();
            pagin.Div.First(d => d.Container.Content).Container.Div
            .First(d => d.Div.Content).Div.Elemento.Add(new DivElemento
            {
                Div = pagin.Div.First(d => d.Container.Content).Container.Div
                .First(d => d.Div.Content).Div,
                
                Elemento = new Texto
                {
                    Pagina_ = pagina.Id,
                    PalavrasTexto = 
                    $"<div id='usuario' style='display:nome;'>" +
                    $" <img src='{user.Image}' width='30' >{user.Name} :</div> <br/> <br/> {comentario.Conteudo}"
                }

            });
            pagin.Div.First(d => d.Container.Content).Container.Height = 50;
            pagin.Div.First(d => d.Container.Content).Container.Div
            .First(d => d.Div.Content).Div.Elemento.First().Div.Height = 50;

            pagina.Div = new List<PaginaContainer>();
            foreach (var item in pagin.Div)

                pagina.IncluiDiv(item.Container);

            db.SaveChanges();
            RepositoryPagina.paginas.Add(pagina);

            if(comentario.IdPagina != 0)
            {
                var comentar = new Comentario
                {
                    IdPagina = comentario.IdPagina,
                     Capitulo = Story.PaginaPadraoLink,
                     Verso = Story.Pagina.Where(p => !p.Layout).ToList().Count
                };
                db.Add(comentar);
                db.SaveChanges();
            }

            comentario.Message = $"Comentário feito com sucesso!!! Compartilhe!!! \n capitulo {Story.PaginaPadraoLink} \n verso {Story.Pagina.Where(p => !p.Layout).ToList().Count}";

            return comentario;
        }

    }

}