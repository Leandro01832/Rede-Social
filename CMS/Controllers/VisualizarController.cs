
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
        

         [Route("Renderizar/{Name}/{capitulo?}/{indice}")]
        [Route("capitulo/{Name}/{capitulo?}/{indice}")]
        [Route("padrao/{Name}/{story}/{indice}")]
        public async Task<IActionResult> Renderizar(string Name, string story, int indice, int? capitulo)
        {
            var user = UserHelper.Users.FirstOrDefault(u => u.Name.ToLower() == Name.Trim().ToLower());
            if (user == null)
            {
                user = await UserManager.Users.FirstOrDefaultAsync(u => u.Name.ToLower() == Name.Trim().ToLower());
                UserHelper.Users.Add(user);
            }
            List<Pagina> lista = await RetornarLista(user.Name, story, capitulo);
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
                html = await epositoryPagina.renderizarPagina(pagina);
            else
            html = user.Capa;
            ViewBag.Html = html;
            ViewBag.proximo = indice + 1;
            return View(pagina);            
        }

         [Route("SubStory/{Name}/{capitulo?}/{substory}/{indice}")]
         public async Task<IActionResult> SubStory(string Name, int indice, int? capitulo, int substory)
        {
            List<Pagina> lista = await RetornarLista(Name, "", capitulo);
            Pagina pag = lista.First();

            var group = pag.Story.SubStory.Where(str => str.Pagina.Count > 0).Skip((int)substory - 1).First(); 
            Pagina pag2 = group.Pagina.Where(p => ! p.Layout).Skip((int)indice - 1).First();
             Pagina pagina = lista.First(p => p.Id == pag2.Id);
             int vers = lista.IndexOf(pagina) + 1;          

                ViewBag.quantidadePaginas = group.Pagina.Count(p => ! p.Layout);
                ViewBag.group = group;
                ViewBag.versiculo = vers;
                ViewBag.grupoindexsubstory = substory;
                ViewBag.story = pagina.Story.Nome;
                string html = await epositoryPagina.renderizarPagina(pagina);
                ViewBag.Html = html;
                ViewBag.proximo = indice + 1;
                return View(pagina);             
        }

        [Route("Grupo/{Name}/{capitulo?}/{substory}/{grupo}/{indice}")]
         public async Task<IActionResult> Grupo(string Name, int indice, int? capitulo, int substory, int grupo)
        {
            List<Pagina> lista = await RetornarLista(Name, "", capitulo);
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
                string html = await epositoryPagina.renderizarPagina(pagina);
                ViewBag.Html = html;
                ViewBag.proximo = indice + 1;
                return View(pagina);            
        }

         [Route("SubGrupo/{Name}/{capitulo?}/{substory}/{grupo}/{subgrupo}/{indice}")]
         public async Task<IActionResult> SubGrupo(string Name, int indice, int? capitulo, int substory, int grupo, int subgrupo)
        {
            List<Pagina> lista = await RetornarLista(Name, "", capitulo);
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
                string html = await epositoryPagina.renderizarPagina(pagina);
                ViewBag.Html = html;
                ViewBag.proximo = indice + 1;
                return View(pagina);            
        }

         [Route("SubSubGrupo/{Name}/{capitulo?}/{substory}/{grupo}/{subgrupo}/{subsubgrupo}/{indice}")]
         public async Task<IActionResult> SubSubGrupo(string Name, int indice, int? capitulo, int substory, int grupo, int subgrupo, int subsubgrupo)
        {
            List<Pagina> lista = await RetornarLista(Name, "", capitulo);
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
                string html = await epositoryPagina.renderizarPagina(pagina);
                ViewBag.Html = html;
                ViewBag.proximo = indice + 1;
                return View(pagina);            
        }       

        private async Task<List<Pagina>> RetornarLista(string Name, string story, int? capitulo)
        {
            var user = UserHelper.Users.FirstOrDefault(u => u.Name.ToLower() == Name.Trim().ToLower());
            if (user == null)
            {
                user = await UserManager.Users.FirstOrDefaultAsync(u => u.Name.ToLower() == Name.Trim().ToLower());
                UserHelper.Users.Add(user);
            }

            ViewBag.user = user.Name;

            var lista = new List<Pagina>();
            if (capitulo == null)
                foreach (var item in RepositoryPagina.paginas)
                {
                    if (item == null || item.FirstOrDefault(i => i.UserId == user.Id) == null)
                        continue;
                    lista.AddRange(item.Where(p => p.Story.Nome == story && p.Story.UserId == user.Id && !p.Layout).ToList());
                }

            else
                foreach (var item in RepositoryPagina.paginas)
                {
                    if (item == null || item.FirstOrDefault(i => i.UserId == user.Id) == null)
                        continue;
                    lista.AddRange(item.Where(p => p.Story.PaginaPadraoLink == capitulo && p.Story.UserId == user.Id && !p.Layout).ToList());
                }

            return lista;
        }

    }

}