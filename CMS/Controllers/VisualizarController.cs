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

        private async Task Verificar(int? capitulo)
        {
             var quant  = buscarCount(null, null, new Story().GetType(),
              Configuration.GetConnectionString("DefaultConnection"), capitulo);

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
        

    }

}