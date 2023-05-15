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
using CMS;

namespace MeuProjetoAgora.Controllers
{
    public class VisualizarController : Controller
    {
        private readonly ApplicationDbContext db;
        public IRepositoryPagina epositoryPagina { get; }
        public UserManager<UserModel> UserManager { get; }
        public IConfiguration Configuration { get; }

        public ClassArray Arr;


        public VisualizarController(IRepositoryPagina repositoryPagina, UserManager<UserModel> userManager,
         IConfiguration configuration, ApplicationDbContext context)
        {
            db = context;
            epositoryPagina = repositoryPagina;
            UserManager = userManager;
            Configuration = configuration;
            Arr = new ClassArray();
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
                {
                    try
                    {
                        html =  epositoryPagina.renderizarPagina(pagina);
                    }
                    catch(Exception ex)
                    {
                        return Content("Erro: " + ex.Message);
                    }
                }
            }
            else if(pagina.Produto == null)
            html = RepositoryPagina.Capa;
            ViewBag.Html = html;
            ViewBag.proximo = indice + 1;
            ViewBag.compartilhante = compartilhante;
            ViewBag.auto = auto;
            ViewBag.Livro =  Configuration.GetConnectionString("Livro");

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

                string[] classificacoes = null;

                if (pagina.SubStory != null)
                    {    
                        if(pagina.CamadaDez != null)
                        {
                            classificacoes = new string[9];
                            classificacoes[0] = pagina.SubStory.Nome;
                            classificacoes[1] = pagina.Grupo.Nome;
                            classificacoes[2] = pagina.SubGrupo.Nome;
                            classificacoes[3] = pagina.SubSubGrupo.Nome;
                            classificacoes[4] = pagina.CamadaSeis.Nome;
                            classificacoes[5] = pagina.CamadaSete.Nome;
                            classificacoes[6] = pagina.CamadaOito.Nome;
                            classificacoes[7] = pagina.CamadaNove.Nome;
                            classificacoes[8] = pagina.CamadaDez.Nome;
                        }                        
                        else
                        if(pagina.CamadaNove != null)
                        {
                            classificacoes = new string[8];
                            classificacoes[0] = pagina.SubStory.Nome;
                            classificacoes[1] = pagina.Grupo.Nome;
                            classificacoes[2] = pagina.SubGrupo.Nome;
                            classificacoes[3] = pagina.SubSubGrupo.Nome;
                            classificacoes[4] = pagina.CamadaSeis.Nome;
                            classificacoes[5] = pagina.CamadaSete.Nome;
                            classificacoes[6] = pagina.CamadaOito.Nome;
                            classificacoes[7] = pagina.CamadaNove.Nome;
                        }                        
                        else
                        if(pagina.CamadaOito != null)
                        {
                            classificacoes = new string[7];
                            classificacoes[0] = pagina.SubStory.Nome;
                            classificacoes[1] = pagina.Grupo.Nome;
                            classificacoes[2] = pagina.SubGrupo.Nome;
                            classificacoes[3] = pagina.SubSubGrupo.Nome;
                            classificacoes[4] = pagina.CamadaSeis.Nome;
                            classificacoes[5] = pagina.CamadaSete.Nome;
                            classificacoes[6] = pagina.CamadaOito.Nome;
                        }                        
                        else
                        if(pagina.CamadaSete != null)
                        {
                            classificacoes = new string[6];
                            classificacoes[0] = pagina.SubStory.Nome;
                            classificacoes[1] = pagina.Grupo.Nome;
                            classificacoes[2] = pagina.SubGrupo.Nome;
                            classificacoes[3] = pagina.SubSubGrupo.Nome;
                            classificacoes[4] = pagina.CamadaSeis.Nome;
                            classificacoes[5] = pagina.CamadaSete.Nome;
                        }                        
                        else
                        if(pagina.CamadaSeis != null)
                        {
                            classificacoes = new string[5];
                            classificacoes[0] = pagina.SubStory.Nome;
                            classificacoes[1] = pagina.Grupo.Nome;
                            classificacoes[2] = pagina.SubGrupo.Nome;
                            classificacoes[3] = pagina.SubSubGrupo.Nome;
                            classificacoes[4] = pagina.CamadaSeis.Nome;
                        }                        
                        else
                        if(pagina.SubSubGrupo != null)
                        {
                            classificacoes = new string[4];
                            classificacoes[0] = pagina.SubStory.Nome;
                            classificacoes[1] = pagina.Grupo.Nome;
                            classificacoes[2] = pagina.SubGrupo.Nome;
                            classificacoes[3] = pagina.SubSubGrupo.Nome;
                        }                        
                        else
                        if(pagina.SubGrupo != null)
                        {
                            classificacoes = new string[3];
                            classificacoes[0] = pagina.SubStory.Nome;
                            classificacoes[1] = pagina.Grupo.Nome;
                            classificacoes[2] = pagina.SubGrupo.Nome;
                        }                        
                        else
                        if(pagina.Grupo != null)
                        {
                            classificacoes = new string[2];
                            classificacoes[0] = pagina.SubStory.Nome;
                            classificacoes[1] = pagina.Grupo.Nome;
                        }                        
                        else
                        if(pagina.SubStory != null)
                        {
                            classificacoes = new string[1];
                            classificacoes[0] = pagina.SubStory.Nome;
                        }                        
                        ViewBag.classificacoes = classificacoes;
                    }
            }

            return View(pagina);            
        }
        
        [Route("SubStory/{capitulo}/{filtrar}/{redirecionar?}")]
        [Route("SubStory/{capitulo}/{substory}/{indice}/{auto}/{compartilhante}")]
         public async Task<IActionResult> SubStory( int indice, int capitulo,
          int substory, int auto, int? redirecionar, string compartilhante, string filtrar)
        {
            await Verificar(capitulo);            
            var lista = RepositoryPagina.paginas.Where(p => p.Story.PaginaPadraoLink == capitulo && !p.Layout).ToList();
            Pagina pag = lista.First();            
            List<Pagina> listaComConteudo = null;
            if(filtrar != null)
            {
              var livro = await db.Livro.FirstOrDefaultAsync(l => l.Compartilhando);
                if( livro != null && redirecionar == null)
                Redirect($"{livro.url}/{capitulo}/{filtrar}/1");
                
                var indiceFiltro = int.Parse(filtrar.Replace("pasta-", ""));
                var fi =  pag.Story.Filtro.OrderBy(f => f.Id).ToList()[indiceFiltro];
                 var arr = Arr.RetornarArray(pag.Story, false, (long) fi.SubStory, capitulo, 1);
                indice = 1;
                auto = 1;
                compartilhante = "user";
                substory = arr[1];
            }

            var group = pag.Story.SubStory.Where(str => str.Pagina.Count > 0).Skip((int)substory - 1).First();

            if(group.Pagina.Where(p => !p.Layout && p.Produto != null).ToList().Count > 0)
             listaComConteudo = retornarListaComConteudo(lista,
              group.Pagina.Where(p => !p.Layout).ToList(), substory);
             else listaComConteudo = group.Pagina.Where(p => !p.Layout).ToList();
            Pagina pag2 = listaComConteudo.Where(p => !p.Layout).Skip((int)indice - 1).First();

            Pagina pagina = lista.First(p => p.Id == pag2.Id);
            int vers = lista.IndexOf(pagina) + 1;

            ViewBag.quantidadePaginas = listaComConteudo.Count(p => !p.Layout);
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
            var filtro = pag.Story.Filtro.First(f => f.SubStory == group.Id);
            ViewBag.filtro = pag.Story.Filtro.OrderBy(f => f.Id).ToList().IndexOf(filtro) + 1;
            return View(pagina);
        }

        

        [Route("Grupo/{capitulo}/{filtrar}/{redirecionar?}")]
        [Route("Grupo/{capitulo}/{substory}/{grupo}/{indice}/{auto}/{compartilhante}")]
         public async Task<IActionResult> Grupo( int indice, int capitulo, int substory,
          int grupo, int auto, int? redirecionar, string compartilhante, string filtrar)
        {             
             await Verificar(capitulo);
            var lista = RepositoryPagina.paginas.Where(p => p.Story.PaginaPadraoLink == capitulo && !p.Layout).ToList();
            Pagina pag = lista.First();
             List<Pagina> listaComConteudo = null;

             if(filtrar != null)
            {
                 var livro = await db.Livro.FirstOrDefaultAsync(l => l.Compartilhando);
                if( livro != null && redirecionar == null)
                Redirect($"{livro.url}/{capitulo}/{filtrar}/1");

                var indiceFiltro = int.Parse(filtrar.Replace("pasta-", ""));
                var fi =  pag.Story.Filtro.OrderBy(f => f.Id).ToList()[indiceFiltro];
                 var arr = Arr.RetornarArray(pag.Story, false, (long) fi.Grupo, capitulo, 1);
                indice = 1;
                auto = 1;
                compartilhante = "user";
                substory = arr[1];
                grupo = arr[2];
            }

            var group = pag.Story.SubStory.Where(str => str.Pagina.Count > 0).Skip((int)substory - 1).First(); 
             var group2 = group.Grupo.Where(str => str.Pagina.Count > 0).Skip((int)grupo - 1).First(); 
            if(group2.Pagina.Where(p => !p.Layout && p.Produto != null).ToList().Count > 0)
               listaComConteudo = retornarListaComConteudo(lista,
             group2.Pagina.Where(p => !p.Layout).ToList(), grupo);
             else listaComConteudo = group2.Pagina.Where(p => !p.Layout).ToList();
            Pagina pag2 = listaComConteudo.Where(p => ! p.Layout).Skip((int)indice - 1).First();
           
             Pagina pagina = lista.First(p => p.Id == pag2.Id);
             int vers = lista.IndexOf(pagina) + 1;          
            
                ViewBag.quantidadePaginas = listaComConteudo.Count(p => ! p.Layout);
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
                var filtro = pag.Story.Filtro.First(f => f.Grupo == group2.Id);
            ViewBag.filtro = pag.Story.Filtro.OrderBy(f => f.Id).ToList().IndexOf(filtro) + 1;
                return View(pagina);            
        }

         [Route("SubGrupo/{capitulo}/{filtrar}/{redirecionar?}")]
         [Route("SubGrupo/{capitulo}/{substory}/{grupo}/{subgrupo}/{indice}/{auto}/{compartilhante}")]
         public async Task<IActionResult> SubGrupo(int indice, int capitulo, int substory,
          int grupo, int subgrupo, int auto, int? redirecionar, string compartilhante, string filtrar)
        {
             await Verificar(capitulo);
             var lista = RepositoryPagina.paginas.Where(p => p.Story.PaginaPadraoLink == capitulo && !p.Layout).ToList();
            Pagina pag = lista.First();
            List<Pagina> listaComConteudo = null;

            if(filtrar != null)
            {
                 var livro = await db.Livro.FirstOrDefaultAsync(l => l.Compartilhando);
                if( livro != null && redirecionar == null)
                Redirect($"{livro.url}/{capitulo}/{filtrar}/1");

                var indiceFiltro = int.Parse(filtrar.Replace("pasta-", ""));
                var fi =  pag.Story.Filtro.OrderBy(f => f.Id).ToList()[indiceFiltro];
                 var arr = Arr.RetornarArray(pag.Story, false, (long) fi.SubGrupo, capitulo, 1);
                indice = 1;
                auto = 1;
                compartilhante = "user";
                substory = arr[1];
                grupo = arr[2];
                subgrupo = arr[3];
            }

            var group = pag.Story.SubStory.Where(str => str.Pagina.Count > 0).Skip((int)substory - 1).First(); 
             var group2 = group.Grupo.Where(str => str.Pagina.Count > 0).Skip((int)grupo - 1).First(); 
             var group3 = group2.SubGrupo.Where(str => str.Pagina.Count > 0).Skip((int)subgrupo - 1).First(); 
            if(group3.Pagina.Where(p => !p.Layout && p.Produto != null).ToList().Count > 0)
              listaComConteudo = retornarListaComConteudo(lista,
             group3.Pagina.Where(p => !p.Layout).ToList(), subgrupo);
             else listaComConteudo = group3.Pagina.Where(p => !p.Layout).ToList();
            Pagina pag2 = listaComConteudo.Where(p => ! p.Layout).Skip((int)indice - 1).First();
            
             Pagina pagina = lista.First(p => p.Id == pag2.Id);
             int vers = lista.IndexOf(pagina) + 1;                       
            
                ViewBag.quantidadePaginas = listaComConteudo.Count(p => ! p.Layout);
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
                var filtro = pag.Story.Filtro.First(f => f.SubGrupo == group3.Id);
            ViewBag.filtro = pag.Story.Filtro.OrderBy(f => f.Id).ToList().IndexOf(filtro) + 1;
                return View(pagina);            
        }

         [Route("SubSubGrupo/{capitulo}/{filtrar}/{grupo}")]
         [Route("SubSubGrupo/{capitulo}/{substory}/{grupo}/{subgrupo}/{subsubgrupo}/{indice}/{auto}/{compartilhante}")]
         public async Task<IActionResult> SubSubGrupo(string Name, int indice, int capitulo,  int substory,
          int grupo, int subgrupo, int subsubgrupo, int auto, int? redirecionar, string compartilhante,
           string filtrar)
        {
             await Verificar(capitulo);
             var lista = RepositoryPagina.paginas.Where(p => p.Story.PaginaPadraoLink == capitulo && !p.Layout).ToList();
            Pagina pag = lista.First();
              List<Pagina> listaComConteudo = null;

               if(filtrar != null)
            {
                 var livro = await db.Livro.FirstOrDefaultAsync(l => l.Compartilhando);
                if( livro != null && redirecionar == null)
                Redirect($"{livro.url}/{capitulo}/{filtrar}/1");

                var indiceFiltro = int.Parse(filtrar.Replace("pasta-", ""));
                var fi =  pag.Story.Filtro.OrderBy(f => f.Id).ToList()[indiceFiltro];
                 var arr = Arr.RetornarArray(pag.Story, false, (long) fi.SubSubGrupo, capitulo, 1);
                indice = 1;
                auto = 1;
                compartilhante = "user";
                substory = arr[1];
                grupo = arr[2];
                subgrupo = arr[3];
                subsubgrupo = arr[4];
            }

            var group = pag.Story.SubStory.Where(str => str.Pagina.Count > 0).Skip((int)substory - 1).First(); 
             var group2 = group.Grupo.Where(str => str.Pagina.Count > 0).Skip((int)grupo - 1).First(); 
             var group3 = group2.SubGrupo.Where(str => str.Pagina.Count > 0).Skip((int)subgrupo - 1).First(); 
              var group4 = group3.SubSubGrupo.Where(str => str.Pagina.Count > 0).Skip((int)subsubgrupo - 1).First();
            if(group4.Pagina.Where(p => !p.Layout && p.Produto != null).ToList().Count > 0)
              listaComConteudo = retornarListaComConteudo(lista,
             group4.Pagina.Where(p => !p.Layout).ToList(), subsubgrupo); 
             else listaComConteudo = group4.Pagina.Where(p => !p.Layout).ToList();
            Pagina pag2 = listaComConteudo.Where(p => ! p.Layout).Skip((int)indice - 1).First();
            
             Pagina pagina = lista.First(p => p.Id == pag2.Id);
             int vers = lista.IndexOf(pagina) + 1;                    
            
                ViewBag.quantidadePaginas = listaComConteudo.Count(p => ! p.Layout);
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
                var filtro = pag.Story.Filtro.First(f => f.SubSubGrupo == group4.Id);
            ViewBag.filtro = pag.Story.Filtro.OrderBy(f => f.Id).ToList().IndexOf(filtro) + 1;
                return View(pagina);            
        }    
         
         [Route("CamadaSeis/{capitulo}/{filtrar}/{redirecionar?}")]
         [Route("CamadaSeis/{capitulo}/{substory}/{grupo}/{subgrupo}/{subsubgrupo}/{camadaseis}/{indice}/{auto}/{compartilhante}")]
         public async Task<IActionResult> CamadaSeis(string Name, int indice, int capitulo, int substory,
          int grupo, int subgrupo, int subsubgrupo, int camadaseis, int auto, int? redirecionar,
           string compartilhante, string filtrar)
        {
             await Verificar(capitulo);
             var lista = RepositoryPagina.paginas.Where(p => p.Story.PaginaPadraoLink == capitulo && !p.Layout).ToList();
            Pagina pag = lista.First();
             List<Pagina> listaComConteudo = null;

             if(filtrar != null)
            {
                 var livro = await db.Livro.FirstOrDefaultAsync(l => l.Compartilhando);
                if( livro != null && redirecionar == null)
                Redirect($"{livro.url}/{capitulo}/{filtrar}/1");

                var indiceFiltro = int.Parse(filtrar.Replace("pasta-", ""));
                var fi =  pag.Story.Filtro.OrderBy(f => f.Id).ToList()[indiceFiltro];
                 var arr = Arr.RetornarArray(pag.Story, false, (long) fi.CamadaSeis, capitulo, 1);
                indice = 1;
                auto = 1;
                compartilhante = "user";
                substory = arr[1];
                grupo = arr[2];
                subgrupo = arr[3];
                subsubgrupo = arr[4];
                camadaseis = arr[5];
            }

            var group = pag.Story.SubStory.Where(str => str.Pagina.Count > 0).Skip((int)substory - 1).First(); 
             var group2 = group.Grupo.Where(str => str.Pagina.Count > 0).Skip((int)grupo - 1).First(); 
             var group3 = group2.SubGrupo.Where(str => str.Pagina.Count > 0).Skip((int)subgrupo - 1).First(); 
              var group4 = group3.SubSubGrupo.Where(str => str.Pagina.Count > 0).Skip((int)subsubgrupo - 1).First(); 
              var group5 = group4.CamadaSeis.Where(str => str.Pagina.Count > 0).Skip((int)camadaseis - 1).First(); 
            if(group5.Pagina.Where(p => !p.Layout && p.Produto != null).ToList().Count > 0)
                listaComConteudo = retornarListaComConteudo(lista,
             group5.Pagina.Where(p => !p.Layout).ToList(), camadaseis); 
             else listaComConteudo = group5.Pagina.Where(p => !p.Layout).ToList();
            Pagina pag2 = listaComConteudo.Where(p => ! p.Layout).Skip((int)indice - 1).First();
            
             Pagina pagina = lista.First(p => p.Id == pag2.Id);
             int vers = lista.IndexOf(pagina) + 1;                    
            
                ViewBag.quantidadePaginas = listaComConteudo.Count(p => ! p.Layout);
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
                var filtro = pag.Story.Filtro.First(f => f.CamadaSeis == group5.Id);
            ViewBag.filtro = pag.Story.Filtro.OrderBy(f => f.Id).ToList().IndexOf(filtro) + 1;
                return View(pagina);            
        }    
         
         [Route("CamadaSete/{capitulo}/{filtrar}/{redirecionar?}")]
         [Route("CamadaSete/{capitulo}/{substory}/{grupo}/{subgrupo}/{subsubgrupo}/{camadaseis}/{camadasete}/{indice}/{auto}/{compartilhante}")]
         public async Task<IActionResult> CamadaSete(string Name, int indice, int capitulo, int substory,
          int grupo, int subgrupo, int subsubgrupo, int camadaseis,
           int camadasete, int auto, int? redirecionar, string compartilhante, string filtrar)
        {
             await Verificar(capitulo);
             var lista = RepositoryPagina.paginas.Where(p => p.Story.PaginaPadraoLink == capitulo && !p.Layout).ToList();
            Pagina pag = lista.First();
             List<Pagina> listaComConteudo = null;

             if(filtrar != null)
            {
                 var livro = await db.Livro.FirstOrDefaultAsync(l => l.Compartilhando);
                if( livro != null && redirecionar == null)
                Redirect($"{livro.url}/{capitulo}/{filtrar}/1");

                var indiceFiltro = int.Parse(filtrar.Replace("pasta-", ""));
                var fi =  pag.Story.Filtro.OrderBy(f => f.Id).ToList()[indiceFiltro];
                 var arr = Arr.RetornarArray(pag.Story, false, (long) fi.CamadaSete, capitulo, 1);
                indice = 1;
                auto = 1;
                compartilhante = "user";
                substory = arr[1];
                grupo = arr[2];
                subgrupo = arr[3];
                subsubgrupo = arr[4];
                camadaseis = arr[5];
                camadasete = arr[6];
            }

            var group = pag.Story.SubStory.Where(str => str.Pagina.Count > 0).Skip((int)substory - 1).First(); 
             var group2 = group.Grupo.Where(str => str.Pagina.Count > 0).Skip((int)grupo - 1).First(); 
             var group3 = group2.SubGrupo.Where(str => str.Pagina.Count > 0).Skip((int)subgrupo - 1).First(); 
              var group4 = group3.SubSubGrupo.Where(str => str.Pagina.Count > 0).Skip((int)subsubgrupo - 1).First(); 
              var group5 = group4.CamadaSeis.Where(str => str.Pagina.Count > 0).Skip((int)camadaseis - 1).First(); 
              var group6 = group5.CamadaSete.Where(str => str.Pagina.Count > 0).Skip((int)camadasete - 1).First(); 
            if(group6.Pagina.Where(p => !p.Layout && p.Produto != null).ToList().Count > 0)
               listaComConteudo = retornarListaComConteudo(lista,
             group6.Pagina.Where(p => !p.Layout).ToList(), camadasete);
             else listaComConteudo = group6.Pagina.Where(p => !p.Layout).ToList();
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
                 var filtro = pag.Story.Filtro.First(f => f.CamadaSete == group6.Id);
            ViewBag.filtro = pag.Story.Filtro.OrderBy(f => f.Id).ToList().IndexOf(filtro) + 1;
                return View(pagina);            
        }    
         
         [Route("CamadaOito/{capitulo}/{filtrar}/{redirecionar?}")]
         [Route("CamadaOito/{capitulo}/{substory}/{grupo}/{subgrupo}/{subsubgrupo}/{camadaseis}/{camadasete}/{camadaoito}/{indice}/{auto}/{compartilhante}")]
         public async Task<IActionResult> CamadaOito(string Name, int indice, int capitulo, int substory,
          int grupo, int subgrupo, int subsubgrupo, int camadaseis,  int camadasete, int camadaoito,
           int auto, int? redirecionar, string compartilhante, string filtrar)
        {
             await Verificar(capitulo);
             var lista = RepositoryPagina.paginas.Where(p => p.Story.PaginaPadraoLink == capitulo && !p.Layout).ToList();
            Pagina pag = lista.First();
             List<Pagina> listaComConteudo = null;

             if(filtrar != null)
            {
                 var livro = await db.Livro.FirstOrDefaultAsync(l => l.Compartilhando);
                if( livro != null && redirecionar == null)
                Redirect($"{livro.url}/{capitulo}/{filtrar}/1");

                var indiceFiltro = int.Parse(filtrar.Replace("pasta-", ""));
                var fi =  pag.Story.Filtro.OrderBy(f => f.Id).ToList()[indiceFiltro];
                 var arr = Arr.RetornarArray(pag.Story, false, (long) fi.CamadaOito, capitulo, 1);
                indice = 1;
                auto = 1;
                compartilhante = "user";
                substory = arr[1];
                grupo = arr[2];
                subgrupo = arr[3];
                subsubgrupo = arr[4];
                camadaseis = arr[5];
                camadasete = arr[6];
                camadaoito = arr[7];
            }

            var group = pag.Story.SubStory.Where(str => str.Pagina.Count > 0).Skip((int)substory - 1).First(); 
             var group2  = group.Grupo.Where(str => str.Pagina.Count > 0).Skip((int)grupo - 1).First(); 
             var group3  = group2.SubGrupo.Where(str => str.Pagina.Count > 0).Skip((int)subgrupo - 1).First(); 
              var group4 = group3.SubSubGrupo.Where(str => str.Pagina.Count > 0).Skip((int)subsubgrupo - 1).First(); 
              var group5 = group4.CamadaSeis.Where(str => str.Pagina.Count > 0).Skip((int)camadaseis - 1).First(); 
              var group6 = group5.CamadaSete.Where(str => str.Pagina.Count > 0).Skip((int)camadasete - 1).First(); 
              var group7 = group6.CamadaOito.Where(str => str.Pagina.Count > 0).Skip((int)camadaoito - 1).First();
            if(group7.Pagina.Where(p => !p.Layout && p.Produto != null).ToList().Count > 0)
               listaComConteudo = retornarListaComConteudo(lista,
             group7.Pagina.Where(p => !p.Layout).ToList(), camadaoito); 
             else listaComConteudo =  group7.Pagina.Where(p => !p.Layout).ToList();
            Pagina pag2 = listaComConteudo.Where(p => ! p.Layout).Skip((int)indice - 1).First();
            
             Pagina pagina = lista.First(p => p.Id == pag2.Id);
             int vers = lista.IndexOf(pagina) + 1;                    
            
                ViewBag.quantidadePaginas = listaComConteudo.Count(p => ! p.Layout);
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
                var filtro = pag.Story.Filtro.First(f => f.CamadaOito == group7.Id);
            ViewBag.filtro = pag.Story.Filtro.OrderBy(f => f.Id).ToList().IndexOf(filtro) + 1;
                return View(pagina);            
        }    
        
         [Route("CamadaNove/{capitulo}/{filtrar}/{redirecionar?}")]
         [Route("CamadaNove/{capitulo}/{substory}/{grupo}/{subgrupo}/{subsubgrupo}/{camadaseis}/{camadasete}/{camadaoito}/{camadanove}/{indice}/{auto}/{compartilhante}")]
         public async Task<IActionResult> CamadaNove(string Name, int indice, int capitulo, int substory,
          int grupo, int subgrupo, int subsubgrupo, int camadaseis, int camadasete, int camadaoito,
           int camadanove, int auto, int? redirecionar, string compartilhante, string filtrar)
        {
             await Verificar(capitulo);
             var lista = RepositoryPagina.paginas.Where(p => p.Story.PaginaPadraoLink == capitulo && !p.Layout).ToList();
            Pagina pag = lista.First();
             List<Pagina> listaComConteudo = null;

              if(filtrar != null)
            {
                 var livro = await db.Livro.FirstOrDefaultAsync(l => l.Compartilhando);
                if( livro != null && redirecionar == null)
                Redirect($"{livro.url}/{capitulo}/{filtrar}/1");

                var indiceFiltro = int.Parse(filtrar.Replace("pasta-", ""));
                var fi =  pag.Story.Filtro.OrderBy(f => f.Id).ToList()[indiceFiltro];
                 var arr = Arr.RetornarArray(pag.Story, false, (long) fi.CamadaNove, capitulo, 1);
                indice = 1;
                auto = 1;
                compartilhante = "user";
                substory = arr[1];
                grupo = arr[2];
                subgrupo = arr[3];
                subsubgrupo = arr[4];
                camadaseis = arr[5];
                camadasete = arr[6];
                camadaoito = arr[7];
                camadanove = arr[8];
            }

            var group = pag.Story.SubStory.Where(str => str.Pagina.Count > 0).Skip((int)substory - 1).First(); 
             var group2  = group.Grupo.Where(str => str.Pagina.Count > 0).Skip((int)grupo - 1).First(); 
             var group3  = group2.SubGrupo.Where(str => str.Pagina.Count > 0).Skip((int)subgrupo - 1).First(); 
              var group4 = group3.SubSubGrupo.Where(str => str.Pagina.Count > 0).Skip((int)subsubgrupo - 1).First(); 
              var group5 = group4.CamadaSeis.Where(str => str.Pagina.Count > 0).Skip((int)camadaseis - 1).First(); 
              var group6 = group5.CamadaSete.Where(str => str.Pagina.Count > 0).Skip((int)camadasete - 1).First(); 
              var group7 = group6.CamadaOito.Where(str => str.Pagina.Count > 0).Skip((int)camadaoito - 1).First(); 
              var group8 = group7.CamadaNove.Where(str => str.Pagina.Count > 0).Skip((int)camadanove - 1).First(); 
            if(group8.Pagina.Where(p => !p.Layout && p.Produto != null).ToList().Count > 0)
              listaComConteudo = retornarListaComConteudo(lista,
             group8.Pagina.Where(p => !p.Layout).ToList(), camadanove); 
             else listaComConteudo = group8.Pagina.Where(p => !p.Layout).ToList();
            Pagina pag2 = listaComConteudo.Where(p => ! p.Layout).Skip((int)indice - 1).First();
            
             Pagina pagina = lista.First(p => p.Id == pag2.Id);
             int vers = lista.IndexOf(pagina) + 1;                    
            
                ViewBag.quantidadePaginas = listaComConteudo.Count(p => ! p.Layout);
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
                var filtro = pag.Story.Filtro.First(f => f.CamadaNove == group8.Id);
            ViewBag.filtro = pag.Story.Filtro.OrderBy(f => f.Id).ToList().IndexOf(filtro) + 1;
                return View(pagina);            
        }    
        
         [Route("CamadaDez/{capitulo}/{filtrar}/{redirecionar}")]
         [Route("CamadaDez/{capitulo}/{substory}/{grupo}/{subgrupo}/{subsubgrupo}/{camadaseis}/{camadasete}/{camadaoito}/{camadanove}/{camadadez}/{indice}/{auto}/{compartilhante}")]
         public async Task<IActionResult> CamadaDez(string Name, int indice, int capitulo, int substory,
          int grupo, int subgrupo, int subsubgrupo, int camadaseis, int camadasete, int camadaoito,
           int camadanove, int camadadez, int auto, int? redirecionar, string compartilhante, string filtrar)
        {
             await Verificar(capitulo);
             var lista = RepositoryPagina.paginas.Where(p => p.Story.PaginaPadraoLink == capitulo && !p.Layout).ToList();
            Pagina pag = lista.First();
              List<Pagina> listaComConteudo = null;

              if(filtrar != null)
            {
                 var livro = await db.Livro.FirstOrDefaultAsync(l => l.Compartilhando);
                if( livro != null && redirecionar == null)
                Redirect($"{livro.url}/{capitulo}/{filtrar}/1");

                var indiceFiltro = int.Parse(filtrar.Replace("pasta-", ""));
                var fi =  pag.Story.Filtro.OrderBy(f => f.Id).ToList()[indiceFiltro];
                 var arr = Arr.RetornarArray(pag.Story, false, (long) fi.CamadaDez, capitulo, 1);
                indice = 1;
                auto = 1;
                compartilhante = "user";
                substory = arr[1];
                grupo = arr[2];
                subgrupo = arr[3];
                subsubgrupo = arr[4];
                camadaseis = arr[5];
                camadasete = arr[6];
                camadaoito = arr[7];
                camadanove = arr[8];
                camadadez = arr[9];
            }

            var group = pag.Story.SubStory.Where(str => str.Pagina.Count > 0).Skip((int)substory - 1).First(); 
             var group2  = group.Grupo.Where(str => str.Pagina.Count > 0).Skip((int)grupo - 1).First(); 
             var group3  = group2.SubGrupo.Where(str => str.Pagina.Count > 0).Skip((int)subgrupo - 1).First(); 
              var group4 = group3.SubSubGrupo.Where(str => str.Pagina.Count > 0).Skip((int)subsubgrupo - 1).First(); 
              var group5 = group4.CamadaSeis.Where(str => str.Pagina.Count > 0).Skip((int)camadaseis - 1).First(); 
              var group6 = group5.CamadaSete.Where(str => str.Pagina.Count > 0).Skip((int)camadasete - 1).First(); 
              var group7 = group6.CamadaOito.Where(str => str.Pagina.Count > 0).Skip((int)camadaoito - 1).First(); 
              var group8 = group7.CamadaNove.Where(str => str.Pagina.Count > 0).Skip((int)camadanove - 1).First(); 
              var group9 = group8.CamadaDez.Where(str => str.Pagina.Count > 0).Skip((int)camadadez - 1).First(); 
            if(group9.Pagina.Where(p => !p.Layout && p.Produto != null).ToList().Count > 0)
                listaComConteudo = retornarListaComConteudo(lista,
             group9.Pagina.Where(p => !p.Layout).ToList(), camadadez);
             else listaComConteudo = group9.Pagina.Where(p => !p.Layout).ToList();
            Pagina pag2 = listaComConteudo.Where(p => ! p.Layout).Skip((int)indice - 1).First();
            
             Pagina pagina = lista.First(p => p.Id == pag2.Id);
             int vers = lista.IndexOf(pagina) + 1;                    
            
                ViewBag.quantidadePaginas = listaComConteudo.Count(p => ! p.Layout);
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
                var filtro = pag.Story.Filtro.First(f => f.CamadaNove == group8.Id);
            ViewBag.filtro = pag.Story.Filtro.OrderBy(f => f.Id).ToList().IndexOf(filtro) + 1;
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
                    cmd = new SqlCommand($"SELECT COUNT(*) FROM Pagina as P inner join Story as st on P.StoryId = st.Id where st.PaginaPadraoLink={capitulo}", con);
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
             var quantidadeCap = RepositoryPagina.paginas.Where(p => p.Story.PaginaPadraoLink ==
                capitulo && !p.Layout).ToList().Count;
                var quant = 0;
                if(RepositoryPagina.paginas.Count != 0 && 
                RepositoryPagina.paginas.Where(p => p.Story.PaginaPadraoLink ==
                capitulo).ToList().Count != 0 &&
                RepositoryPagina.paginas.FirstOrDefault(p => p.Story.PaginaPadraoLink ==
                capitulo).Story.Quantidade == 0)
                {
                    quant  = buscarCount(null, null, new Story().GetType(),
                    Startup.conexao, capitulo);                    
                    RepositoryPagina.paginas.First(p => p.Story.PaginaPadraoLink ==
                     capitulo).Story.Quantidade = quant;

                }
             else if(RepositoryPagina.paginas.Count != 0 && 
             RepositoryPagina.paginas.Where(p => p.Story.PaginaPadraoLink ==
                capitulo).ToList().Count != 0)
             {
                quant = RepositoryPagina.paginas.First(p => p.Story.PaginaPadraoLink ==
                        capitulo).Story.Quantidade;
             }

             var comentarios = 0;
                if(RepositoryPagina.paginas.Count != 0 &&
                 RepositoryPagina.paginas.FirstOrDefault().Story.QuantComentario == 0)
                {
              comentarios  = CountComentarios(null, null, new Story().GetType(), Startup.conexao);
                   RepositoryPagina.paginas.First().Story.QuantComentario = comentarios;
                }
              else if(RepositoryPagina.paginas.Count != 0)
              comentarios = RepositoryPagina.paginas.FirstOrDefault().Story.QuantComentario;

              if(
               quantidadeCap == 0 ||
                quant != quantidadeCap
              )
             {                
                RepositoryPagina.paginas.RemoveAll(p => p.Story.PaginaPadraoLink == capitulo);
                RepositoryPagina.paginas.AddRange(await epositoryPagina.includes()
                .Where(p => p.Story.PaginaPadraoLink == capitulo && !p.Layout).OrderBy(p => p.Id).ToListAsync());
             }

              if(RepositoryPagina.paginas.Where(p => p.Story.Comentario).ToList().Count != comentarios)
              {
                RepositoryPagina.paginas.RemoveAll(p => p.Story.Comentario);
                RepositoryPagina.paginas.AddRange(await epositoryPagina.includes()
                .Where(p => p.Story.Comentario).ToListAsync());
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

                Pagina.entity = true;
            var p = new Pagina()
            {
                Titulo = "Story - " + str.Nome,
                StoryId = str.Id,                
                Layout = false
            };
            Pagina.entity = false; 

                db.Add(p);
                db.SaveChanges();
                p.Story.Quantidade++;

                var pagi = new Pagina(1);
                pagi.setarElemento(new LinkBody
                {
                  Pagina_ = p.Id,
                  TextoLink = "#LinkPadrao",
                  Texto = new Texto
                  {
                    Pagina_ = p.Id,
                    PalavrasTexto = "<h1> Story " + Story.Nome + "</h1>"
                  }
                });

                p.Div = new List<PaginaContainer>();
                foreach (var item in pagi.Div)
                    p.IncluiDiv(item.Container);
                db.SaveChanges();
            }
                        
            Pagina.entity = true;
            var pagina = new Pagina()
            {
                Titulo = "Story - " + Story.Nome,
                StoryId = Story.Id,                
                Layout = false,
                Comentario = comentario.IdPagina
            };
            Pagina.entity = false; 

            db.Add(pagina);
            db.SaveChanges();
            pagina.Story.QuantComentario++;

            var pagin = new Pagina(1);
            pagin.setarElemento(new Texto
            {
              Pagina_ = pagina.Id,
              PalavrasTexto = 
              $"<div id='usuario' style='display:nome;'>" +
              $" <img src='{user.Image}' width='30' >{user.Name} : </div> <br/> <br/> {comentario.Conteudo}"
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

        private List<Pagina> retornarListaComConteudo(List<Pagina> content, List<Pagina> produtos, int grupo)
        {
            int pular = (int) (content.Count * 0.2);
            List<Pagina> conteudo = content.Where(p => p.Div.Count > 0).ToList();
            List<Pagina> conteudoPorGrupo = conteudo.Skip((grupo - 1) * pular).Take(pular).ToList();
            List<Pagina> listaComConteudo = new List<Pagina>();
            int interacao = 0;

            while(produtos.Skip(interacao * 2).ToList().Count >= 2) 
            {
                listaComConteudo.AddRange(produtos.Skip(interacao * 2).Take(2).ToList());
                if(conteudoPorGrupo.Skip(interacao).FirstOrDefault() != null)
                listaComConteudo.Add(conteudoPorGrupo.Skip(interacao).First());

                interacao++;
            }

            if(listaComConteudo.Count == 0) return produtos;
            if(!listaComConteudo.Contains(produtos.Last()))
            listaComConteudo.Add(produtos.Last());

            return listaComConteudo;
        }

        public async Task<IActionResult> filtrar(int capitulo, string filtro)
        {
            await Verificar(capitulo);
            var lista = RepositoryPagina.paginas
            .Where(p => p.Story.PaginaPadraoLink == capitulo && !p.Layout).ToList();
            Pagina pag = lista.First();
            var indiceFiltro = int.Parse(filtro.Replace("pasta-",""));
                Filtro f = pag.Story.Filtro.OrderBy(fil => fil.Id).ToList()[indiceFiltro];
            if(f.SubStory != null)
            {
                return Redirect("");                
            }
            else
            if(f.Grupo != null)
            {
                return Redirect("");
            }
            else
            if(f.SubGrupo != null)
            {
                return Redirect("");
            }
            else
            if(f.SubSubGrupo != null)
            {
                return Redirect("");
            }
            else
            if(f.CamadaSeis != null)
            {
                return Redirect("");
            }
            else
            if(f.CamadaSete != null)
            {
                return Redirect("");
            }
            else
            if(f.CamadaSete != null)
            {
                return Redirect("");
            }
            else
            if(f.CamadaOito != null)
            {
                return Redirect("");
            }
            else
            if(f.CamadaNove != null)
            {
                return Redirect("");
                
            }
            else
            if(f.CamadaDez != null)
            {
                return Redirect("");
            }

            return Redirect("/");
        }

        private async Task<List<Pagina>> retornarListaFiltro(Filtro filtro)
        {
            List<Pagina> retorno = null;
            if(filtro.SubStory != null)
            {
                var group = await db.SubStory.Include(s => s.Pagina)
                .FirstAsync(s => s.Id == filtro.SubStory);
                retorno = group.Pagina.Where(p => !p.Layout).ToList();
            }
            else
            if(filtro.Grupo != null)
            {
                var group = await db.Grupo.Include(s => s.Pagina)
                .FirstAsync(s => s.Id == filtro.Grupo);
                retorno = group.Pagina.Where(p => !p.Layout).ToList();
            }
            else
            if(filtro.SubGrupo != null)
            {
                var group = await db.SubGrupo.Include(s => s.Pagina)
                .FirstAsync(s => s.Id == filtro.SubGrupo);
                retorno = group.Pagina.Where(p => !p.Layout).ToList();
            }
            else
            if(filtro.SubSubGrupo != null)
            {
                var group = await db.SubSubGrupo.Include(s => s.Pagina)
                .FirstAsync(s => s.Id == filtro.SubSubGrupo);
                retorno = group.Pagina.Where(p => !p.Layout).ToList();
            }
            else
            if(filtro.CamadaSeis != null)
            {
                var group = await db.CamadaSeis.Include(s => s.Pagina)
                .FirstAsync(s => s.Id == filtro.CamadaSeis);
                retorno = group.Pagina.Where(p => !p.Layout).ToList();
            }
            else
            if(filtro.CamadaSete != null)
            {
                var group = await db.CamadaSete.Include(s => s.Pagina)
                .FirstAsync(s => s.Id == filtro.CamadaSete);
                retorno = group.Pagina.Where(p => !p.Layout).ToList();
            }
            else
            if(filtro.CamadaSete != null)
            {
                var group = await db.CamadaSete.Include(s => s.Pagina)
                .FirstAsync(s => s.Id == filtro.CamadaSete);
                retorno = group.Pagina.Where(p => !p.Layout).ToList();
            }
            else
            if(filtro.CamadaOito != null)
            {
                var group = await db.CamadaOito.Include(s => s.Pagina)
                .FirstAsync(s => s.Id == filtro.CamadaOito);
                retorno = group.Pagina.Where(p => !p.Layout).ToList();
            }
            else
            if(filtro.CamadaNove != null)
            {
                var group = await db.CamadaNove.Include(s => s.Pagina)
                .FirstAsync(s => s.Id == filtro.CamadaNove);
                retorno = group.Pagina.Where(p => !p.Layout).ToList();
            }
            else
            if(filtro.CamadaDez != null)
            {
                var group = await db.CamadaDez.Include(s => s.Pagina)
                .FirstAsync(s => s.Id == filtro.CamadaDez);
                retorno = group.Pagina.Where(p => !p.Layout).ToList();
            }

            return retorno;
        }

    }

}