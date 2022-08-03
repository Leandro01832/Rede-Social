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
            var user = UserHelper.Users.FirstOrDefault(u => u.Name.ToLower() == User.Trim().ToLower());
            if (user == null)
            {
                user = await UserManager.Users.FirstOrDefaultAsync(u => u.Name.ToLower() == User.Trim().ToLower());
                UserHelper.Users.Add(user);
            }
            var paginas = new List<Pagina>();
            foreach (var item in RepositoryPagina.paginas)
            {
             paginas.AddRange( item.Where(s => s.UserId == user.Id).ToList());
            }
            var stories = new List<Story>();

            foreach (var item in paginas)
            if(stories.FirstOrDefault(str => str.Nome == item.Story.Nome) == null)
            stories.Add(item.Story);

            stories = stories.OrderBy(s => s.PaginaPadraoLink).ToList();

            try
            {
                var story = stories[Indice + 1];
                return Json(story.PaginaPadraoLink);
            }
            catch (Exception)
            {
                return Json(stories[1].PaginaPadraoLink);
            }            
        }

        public JsonResult GetStories(string valor)
        {
            var stories = db.Story.Where(s => s.Id >= 1);

            return Json(stories);
        }

        public async Task<JsonResult> GetUser(string valor)
        {

            IQueryable users;
            var lista = new List<UserModel>();
            if (valor != null)
            {
                lista = await UserManager.Users.Where(s => s.Name.ToLower().Contains(valor.ToLower())).ToListAsync();
                foreach(var item in lista)
                {
                    var user = UserHelper.Users.FirstOrDefault(u => u.Name.ToLower() == item.Name.Trim().ToLower());
                    if (user == null)
                    UserHelper.Users.Add(item);                    
                }
            }
            else
                lista = new List<UserModel>();

            users = lista.AsQueryable();

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

        public JsonResult GetCores(Int64 Background)
        {
            var cores = db.Cor.Where(b => b.BackgroundId == Background);

            return Json(cores);
        }

        public JsonResult Mensagens(Int64 Pagina)
        {
            var pastas = db.MensagemChat.Where(b => b.Pagina == Pagina);

            return Json(pastas);
        }

        public async Task<JsonResult> GetPaginas(Int64 Pagina)
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

        public JsonResult Elementos(Int64 Pagina, string Tipo)
        {
            var els = db.Elemento.Where(ele => ele.GetType().Name == Tipo && ele.Pagina_ == Pagina);
            return Json(els);
        }
    }
}