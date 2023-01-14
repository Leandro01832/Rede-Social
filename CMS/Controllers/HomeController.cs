using business.Back;
using business.business;
using business.business.Group;
using business.business.Elementos.texto;
using business.div;
using business.Join;
using CMS.Data;
using CMS.Models;
using CMS.Models.Repository;
using business.business.Elementos.element;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace CMS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public UserManager<UserModel> UserManager { get; }
        public IRepositoryPagina epositoryPagina { get; }
        public IHostingEnvironment HostingEnvironment { get; }
        public IConfiguration Configuration { get; }
        public IServiceEmailSender EmailSender { get; }
        public IRepositoryDiv RepositoryDiv { get; }

        public HomeController(UserManager<UserModel> userManager, IRepositoryPagina repositoryPagina,
            ApplicationDbContext context, IHostingEnvironment hostingEnvironment,
            IConfiguration configuration, IServiceEmailSender emailSender, IRepositoryDiv repositoryDiv)
        {
            UserManager = userManager;
            epositoryPagina = repositoryPagina;
            _context = context;
            HostingEnvironment = hostingEnvironment;
            Configuration = configuration;
            EmailSender = emailSender;
            RepositoryDiv = repositoryDiv;
        }

        [Route("{compartilhante}")]
        [Route("")]
        public async Task<IActionResult> Index(string compartilhante)
        {
            var option = Request.Cookies["automatico"];
            var option2 = Request.Cookies["story"];
            if (option == null)
                Set("automatico", "0", 12);
            if (option2 == null)
                Set("story", "0", 12);

                 var stories = await _context.Story.Where(str => str.Nome != "Padrao")
                .OrderBy(st => st.Nome)
                .ToListAsync();

                if(string.IsNullOrEmpty(compartilhante)) compartilhante = "user";

                ViewBag.stories = stories;
                ViewBag.compartilhante = compartilhante;
            return View();
        }

        [Authorize]
        [Route("Perfil")]
        public async Task<IActionResult> Perfil()
        {
            var user = await UserManager.GetUserAsync(this.User);
            return View(user);
        }

        [Authorize]
        public async Task<IActionResult> Alterar()
        {
            var user = await UserManager.GetUserAsync(this.User);
            ViewBag.UserId = user.Id;
            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> Alterar(UserModel user)
        {
            var user2 = await UserManager.GetUserAsync(this.User);
            user2.Image = "/ImagensUsers/" + user2.Name + ".jpg";
            user2.Facebook = user.Facebook;
            user2.Twitter = user.Twitter;
            user2.Instagram = user.Instagram;
            user2.Capa = user.Capa;

            var result = await UserManager.UpdateAsync(user2);                


            if (result.Succeeded && Request.Form.Files.Count > 0)
            {
                var Image = Request.Form.Files[0];
                byte[] buffer = new byte[16 * 1024];
                using (FileStream output = System.IO.File.Create(this.HostingEnvironment.WebRootPath + "\\ImagensUsers\\" +
                    user2.Name + ".jpg"))
                {
                    using (Stream input = Image.OpenReadStream())
                    {
                        long totalReadBytes = 0;
                        int readBytes;

                        while ((readBytes = input.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            await output.WriteAsync(buffer, 0, readBytes);
                            totalReadBytes += readBytes;
                        }
                    }
                }
                return RedirectToAction("Perfil", new { Name = user2.Name });
            }

            return RedirectToAction("Perfil", new { Name = user2.Name });
        }       

        [Authorize]
        public IActionResult Comentar()
        {    
            return View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Comentar(string Conteudo)
        {
            var user = await UserManager.GetUserAsync(this.User);
            var Quant = await _context.Story.Where(st => st.Nome != "Padrao").ToListAsync();
            var story = await _context.Story.Include(st => st.Pagina).Where(st => st.Comentario).ToListAsync();
            var Story = story.LastOrDefault();

            if (Story == null || Story.Pagina.Where(p => !p.Layout).ToList().Count > 499) 
            {
                Story = new Story
                {
                    Nome = "Comentario " + (story.Count + 1),
                    Comentario = true,
                    PaginaPadraoLink = Quant.Count + 1,
                     UserId = ""
                      
                };
                _context.Add(Story);
                _context.SaveChanges();
            }

            var pagina = new Pagina()
            {
                Data = DateTime.Now,
                ArquivoMusic = "",
                UserId = user.Id,
                Html = "",
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
                Pular = false
            };
            pagina.Div = null;

            _context.Add(pagina);
            _context.SaveChanges();

            var pagin = new Pagina(1);
            pagin.Div.First(d => d.Container.Content).Container.Div
            .First(d => d.Div.Content).Div.Elemento = new List<DivElemento>();
            pagin.Div.First(d => d.Container.Content).Container.Div
            .First(d => d.Div.Content).Div.Elemento.Add(new DivElemento
            {
                Div = pagin.Div.First(d => d.Container.Content).Container.Div
                .First(d => d.Div.Content).Div,
                Elemento =  new Texto
                    {
                        Pagina_ = pagina.Id,
                        PalavrasTexto = $"<img src='{user.Image}' width='50' >" +
                        $"<p> {user.UserName} </p>" +
                        Conteudo
                    }
                
            });

            pagina.Div = new List<PaginaContainer>();
            foreach (var item in pagin.Div)

                pagina.IncluiDiv(item.Container);

            _context.SaveChanges();

            return RedirectToAction(nameof(PaginaCriada),
            new { capitulo = Story.PaginaPadraoLink, versiculo = Story.Pagina.Where(p => !p.Layout).ToList().Count });

        }
        
        public ActionResult Preview(string Conteudo)
        {          
            ViewBag.html = Conteudo;
            //return Json(html);
            return PartialView("Preview");
        }
        
        public ActionResult PaginaCriada( int capitulo, int versiculo)
        {            
            ViewBag.capitulo = capitulo;
            ViewBag.versiculo = versiculo;
            return View();
        }       
        
        public IActionResult Privacy()
        {
            return View();
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private void Set(string key, string value, int? expireTime)
        {
            CookieOptions option = new CookieOptions();

            if (expireTime.HasValue)
                option.Expires = DateTime.Now.AddHours(expireTime.Value);
            else
                option.Expires = DateTime.Now.AddHours(10);

            option.HttpOnly = false;
            option.Path = "/";

            Response.Cookies.Append(key, value, option);
        }
        
    }
}
