using business.business;
using CMS.Data;
using CMS.Models;
using CMS.Models.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Controllers
{
    public class AjaxGetController : Controller
    {
        private readonly ApplicationDbContext db;
        public IRepositoryPagina epositoryPagina { get; }
        public IHttpHelper HttpHelper { get; }
        public UserManager<UserModel> UserManager { get; }

        public AjaxGetController(ApplicationDbContext context, IRepositoryPagina repositoryPagina,
            IHttpHelper httpHelper, UserManager<UserModel> userManager)
        {
            db = context;
            epositoryPagina = repositoryPagina;
            HttpHelper = httpHelper;
            UserManager = userManager;
        }

        public async Task<JsonResult> GetStory(int Indice, string User)
        {
            var usuario = await UserManager.Users.FirstOrDefaultAsync(u => u.Name == User);
            var paginas = RepositoryPagina.paginas.Where(s => s.UserId == usuario.Id).ToList();
            var stories = new List<Story>();

            foreach (var item in paginas)
            if(stories.FirstOrDefault(str => str.Nome == item.Story.Nome) == null)
            stories.Add(item.Story);

            stories = stories.OrderBy(s => s.PaginaPadraoLink).ToList();

            try
            {
                var story = stories[Indice + 1];
                return Json(story.Nome);
            }
            catch (Exception)
            {
                return Json(stories[1].Nome);
            }            
        }

        public JsonResult GetStories(string valor)
        {
            var stories = db.Story.Where(s => s.Id >= 1);

            return Json(stories);
        }

        public JsonResult GetUser(string valor)
        {
            IQueryable users;
            if (valor != null)
                users = UserManager.Users.Where(s => s.Name.ToLower().Contains(valor.ToLower()));
            else
                users = new List<UserModel>().AsQueryable();

            return Json(users);
        }

        public JsonResult GetPastas(string Pagina)
        {
            IQueryable pastas;
            var page = db.Pagina.FirstOrDefault(b => b.UserId == Pagina);
            if (page != null)
                pastas = db.PastaImagem.Where(b => b.UserId == page.UserId);
            else
                pastas = db.PastaImagem.Where(b => b.UserId == "");

            return Json(pastas);
        }

        public JsonResult GetCores(ulong Background)
        {
            var cores = db.Cor.Where(b => b.BackgroundId == Background);

            return Json(cores);
        }

        public JsonResult Mensagens(ulong Pagina)
        {
            var pastas = db.MensagemChat.Where(b => b.Pagina == Pagina);

            return Json(pastas);
        }

        public async Task<JsonResult> GetPaginas(ulong Pagina)
        {
            var pagina = await db.Pagina.FirstAsync(p => p.Id == Pagina);
            var PedidoId = pagina.UserId;
            var paginas = db.Pagina.Where(m => m.UserId == PedidoId);

            return Json(paginas);
        }

        public JsonResult GetPaginasDoSite(string Pagina)
        {
            var page = db.Pagina.First(b => b.UserId == Pagina);
            var paginas = db.Pagina.Where(m => m.UserId == page.UserId);

            return Json(paginas);
        }

        public JsonResult Elementos(ulong Pagina, string Tipo)
        {
            var els = db.Elemento.Where(ele => ele.GetType().Name == Tipo && ele.Pagina_ == Pagina);
            return Json(els);
        }
    }
}