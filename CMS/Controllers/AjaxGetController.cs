using business.Back;
using business.business.carousel;
using business.business.Elementos;
using business.business.Elementos.element;
using business.business.Elementos.imagem;
using business.business.Elementos.texto;
using business.business.link;
using CMS.Data;
using CMS.Models;
using CMS.Models.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Controllers
{
    public class AjaxGetController : Controller
    {
        private readonly ApplicationDbContext db;        
        public IRepositoryPagina RepositoryPagina { get; }
        public IHttpHelper HttpHelper { get; }
        public UserManager<UserModel> UserManager { get; }

        public AjaxGetController(ApplicationDbContext context, IRepositoryPagina repositoryPagina,
            IHttpHelper httpHelper, UserManager<UserModel> userManager)
        {
            db = context;
            RepositoryPagina = repositoryPagina;
            HttpHelper = httpHelper;
            UserManager = userManager;
        }

        public JsonResult GetStories(string valor)
        {
            var stories = db.Story.Where(s => s.Id >= 1);

            return Json(stories);
        }

        public JsonResult GetUser(string valor)
        {
            IQueryable users;
            if(valor != null)
             users = UserManager.Users.Where(s => s.Name.ToLower().Contains(valor.ToLower()));
            else
            users = new List<UserModel>().AsQueryable();

            return Json(users);
        }

        public JsonResult GetPastas(string Pagina)
        {
            var page = db.Pagina.First(b => b.UserId == Pagina);
            var pastas = db.PastaImagem.Where(b => b.UserId == page.UserId);

            return Json(pastas);
        }

        public JsonResult GetCores(int Background)
        {
            var cores = db.Cor.Where(b => b.BackgroundId == Background);

            return Json(cores);
        }

        public JsonResult Mensagens(int Pagina)
        {
            var pastas = db.MensagemChat.Where(b => b.Pagina == Pagina);

            return Json(pastas);
        }

        public async Task<JsonResult> GetPaginas(int Pagina)
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

        public JsonResult Elementos(int Pagina, string Tipo)
        {        
            var els = db.Elemento.Where(ele => ele.GetType().Name == Tipo && ele.Pagina_ == Pagina);
            return Json(els);
        }
    }
}