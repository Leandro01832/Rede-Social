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

namespace MeuProjetoAgora.Controllers
{
    public class VisualizarController : Controller
    {
        public IRepositoryPagina epositoryPagina { get; }
        public UserManager<UserModel> UserManager { get; }

        public VisualizarController(IRepositoryPagina repositoryPagina, UserManager<UserModel> userManager)
        {
            epositoryPagina = repositoryPagina;
            UserManager = userManager;
        }
        

         [Route("Renderizar/{capitulo?}/{indice}/{auto}/{compartilhante}")]
        public async Task<IActionResult> Renderizar( int indice, int? capitulo, int auto, string compartilhante)
        {           
             if(RepositoryPagina.paginas.Where(p => p.Story.PaginaPadraoLink == capitulo && !p.Layout).ToList().Count == 0)
            RepositoryPagina.paginas.AddRange(await epositoryPagina.includes().Where(p => p.Story.PaginaPadraoLink == capitulo && !p.Layout).ToListAsync());
            var lista = RepositoryPagina.paginas.Where(p => p.Story.PaginaPadraoLink == capitulo && !p.Layout).ToList();
            Pagina pagina = lista.Skip((int)indice - 1).FirstOrDefault();

            while (pagina != null &&  pagina.Pular && pagina.Id != lista.Last().Id)
            pagina = lista[lista.IndexOf(pagina) + 1];

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
                html = await epositoryPagina.renderizarPagina(pagina);
            }
            else
            html = "Instagleo";
            ViewBag.Html = html;
            ViewBag.proximo = indice + 1;
            ViewBag.compartilhante = compartilhante;
            ViewBag.auto = auto;
            return View(pagina);            
        }

        

        [Route("SubStory/{capitulo?}/{substory}/{indice}/{auto}/{compartilhante}")]
         public async Task<IActionResult> SubStory( int indice, int? capitulo, int substory, int auto, string compartilhante)
        {
              if(RepositoryPagina.paginas.Where(p => p.Story.PaginaPadraoLink == capitulo && !p.Layout).ToList().Count == 0)
            RepositoryPagina.paginas.AddRange(await epositoryPagina.includes().Where(p => p.Story.PaginaPadraoLink == capitulo && !p.Layout).ToListAsync());
            var lista = RepositoryPagina.paginas.Where(p => p.Story.PaginaPadraoLink == capitulo && !p.Layout).ToList();
            Pagina pag = lista.First();

            var group = pag.Story.SubStory.Where(str => str.Pagina.Count > 0).Skip((int)substory - 1).First(); 
            Pagina pag2 = group.Pagina.Where(p => ! p.Layout).Skip((int)indice - 1).First();

             while (pag2.Pular && pag2.Id != group.Pagina.Where(p => ! p.Layout).ToList().Last().Id)
            pag2 = group.Pagina.Where(p => ! p.Layout).ToList()[group.Pagina.Where(p => ! p.Layout).ToList().IndexOf(pag2) + 1];  

             Pagina pagina = lista.First(p => p.Id == pag2.Id);
             int vers = lista.IndexOf(pagina) + 1; 

                   

                ViewBag.quantidadePaginas = group.Pagina.Count(p => ! p.Layout);
                ViewBag.group = group;
                ViewBag.versiculo = vers;
                ViewBag.grupoindexsubstory = substory;
                ViewBag.story = pagina.Story.Nome;
                string html = "";
               if(!string.IsNullOrEmpty(pagina.Sobreescrita))
                html = pagina.Sobreescrita;
                else
                html = await epositoryPagina.renderizarPagina(pagina);
                ViewBag.Html = html;
                ViewBag.proximo = indice + 1;
                ViewBag.compartilhante = compartilhante;
                ViewBag.auto = auto;
                return View(pagina);             
        }

        [Route("Grupo/{capitulo?}/{substory}/{grupo}/{indice}/{auto}/{compartilhante}")]
         public async Task<IActionResult> Grupo( int indice, int? capitulo, int substory, int grupo, int auto, string compartilhante)
        {             
             if(RepositoryPagina.paginas.Where(p => p.Story.PaginaPadraoLink == capitulo && !p.Layout).ToList().Count == 0)
            RepositoryPagina.paginas.AddRange(await epositoryPagina.includes().Where(p => p.Story.PaginaPadraoLink == capitulo && !p.Layout).ToListAsync());
            var lista = RepositoryPagina.paginas.Where(p => p.Story.PaginaPadraoLink == capitulo && !p.Layout).ToList();
            Pagina pag = lista.First();

            var group = pag.Story.SubStory.Where(str => str.Pagina.Count > 0).Skip((int)substory - 1).First(); 
             var group2 = group.Grupo.Where(str => str.Pagina.Count > 0).Skip((int)grupo - 1).First(); 
            Pagina pag2 = group2.Pagina.Where(p => ! p.Layout).Skip((int)indice - 1).First();

            while (pag2.Pular && pag2.Id != group2.Pagina.Where(p => ! p.Layout).ToList().Last().Id)
            pag2 = group2.Pagina.Where(p => ! p.Layout).ToList()[group2.Pagina.Where(p => ! p.Layout).ToList().IndexOf(pag2) + 1]; 

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
                html = await epositoryPagina.renderizarPagina(pagina);
                ViewBag.Html = html;
                ViewBag.proximo = indice + 1;
                ViewBag.compartilhante = compartilhante;
                ViewBag.auto = auto;
                return View(pagina);            
        }

         [Route("SubGrupo/{capitulo?}/{substory}/{grupo}/{subgrupo}/{indice}/{auto}/{compartilhante}")]
         public async Task<IActionResult> SubGrupo(int indice, int? capitulo, int substory, int grupo, int subgrupo, int auto, string compartilhante)
        {
             if(RepositoryPagina.paginas.Where(p => p.Story.PaginaPadraoLink == capitulo && !p.Layout).ToList().Count == 0)
            RepositoryPagina.paginas.AddRange(await epositoryPagina.includes().Where(p => p.Story.PaginaPadraoLink == capitulo && !p.Layout).ToListAsync());
             var lista = RepositoryPagina.paginas.Where(p => p.Story.PaginaPadraoLink == capitulo && !p.Layout).ToList();
            Pagina pag = lista.First();

            var group = pag.Story.SubStory.Where(str => str.Pagina.Count > 0).Skip((int)substory - 1).First(); 
             var group2 = group.Grupo.Where(str => str.Pagina.Count > 0).Skip((int)grupo - 1).First(); 
             var group3 = group2.SubGrupo.Where(str => str.Pagina.Count > 0).Skip((int)subgrupo - 1).First(); 
            Pagina pag2 = group3.Pagina.Where(p => ! p.Layout).Skip((int)indice - 1).First();

            while (pag2.Pular && pag2.Id != group3.Pagina.Where(p => ! p.Layout).ToList().Last().Id)
            pag2 = group3.Pagina.Where(p => ! p.Layout).ToList()[group3.Pagina.Where(p => ! p.Layout).ToList().IndexOf(pag2) + 1]; 

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
                html = await epositoryPagina.renderizarPagina(pagina);
                ViewBag.Html = html;
                ViewBag.proximo = indice + 1;
                ViewBag.compartilhante = compartilhante;
                ViewBag.auto = auto;
                return View(pagina);            
        }

         [Route("SubSubGrupo/{capitulo?}/{substory}/{grupo}/{subgrupo}/{subsubgrupo}/{indice}/{auto}/{compartilhante}")]
         public async Task<IActionResult> SubSubGrupo(string Name, int indice, int? capitulo, int substory, int grupo, int subgrupo, int subsubgrupo, int auto, string compartilhante)
        {
             if(RepositoryPagina.paginas.Where(p => p.Story.PaginaPadraoLink == capitulo && !p.Layout).ToList().Count == 0)
            RepositoryPagina.paginas.AddRange(await epositoryPagina.includes().Where(p => p.Story.PaginaPadraoLink == capitulo && !p.Layout).ToListAsync());
             var lista = RepositoryPagina.paginas.Where(p => p.Story.PaginaPadraoLink == capitulo && !p.Layout).ToList();
            Pagina pag = lista.First();

            var group = pag.Story.SubStory.Where(str => str.Pagina.Count > 0).Skip((int)substory - 1).First(); 
             var group2 = group.Grupo.Where(str => str.Pagina.Count > 0).Skip((int)grupo - 1).First(); 
             var group3 = group2.SubGrupo.Where(str => str.Pagina.Count > 0).Skip((int)subgrupo - 1).First(); 
              var group4 = group3.SubSubGrupo.Where(str => str.Pagina.Count > 0).Skip((int)subsubgrupo - 1).First(); 
            Pagina pag2 = group4.Pagina.Where(p => ! p.Layout).Skip((int)indice - 1).First();

                while (pag2.Pular && pag2.Id != group4.Pagina.Where(p => ! p.Layout).ToList().Last().Id)
            pag2 = group4.Pagina.Where(p => ! p.Layout).ToList()[group4.Pagina.Where(p => ! p.Layout).ToList().IndexOf(pag2) + 1];

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
                html = await epositoryPagina.renderizarPagina(pagina);
                ViewBag.Html = html;
                ViewBag.proximo = indice + 1;
                ViewBag.compartilhante = compartilhante;
                return View(pagina);            
        }       

        

        

    }

}