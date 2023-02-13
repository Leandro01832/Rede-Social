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
using business.business.link;

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

            var stories = await _context.Story.Where(str => str.Nome != "Padrao")
           .OrderBy(st => st.Nome)
           .ToListAsync();
            var users = UserManager.Users.ToList().Count;

            if (string.IsNullOrEmpty(compartilhante)) compartilhante = "user";

            ViewBag.stories = stories;
            ViewBag.compartilhante = compartilhante;
            ViewBag.users = users;
            return View();
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
            var comenta = await _context.Story.Include(st => st.Pagina).Where(st => st.Comentario).ToListAsync();
            var Story = comenta.LastOrDefault();

            if (Story == null || Story.Pagina.Where(p => !p.Layout).ToList().Count > 499)
            {
                Story = new Story
                {
                    Nome = "Comentario " + (comenta.Count + 1),
                    Comentario = true,
                    PaginaPadraoLink = Quant.Count + 1

                };
                _context.Add(Story);
                _context.SaveChanges();

                var str = await _context.Story.FirstAsync(st => st.Nome == "Padrao");

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
                    Music = false
                };
                p.Div = null;

                _context.Add(p);
                _context.SaveChanges();

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
                _context.SaveChanges();
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
                Music = false
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
                Elemento = new Texto
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
            RepositoryPagina.paginas.Clear();

            return RedirectToAction(nameof(PaginaCriada),
            new { capitulo = Story.PaginaPadraoLink, versiculo = Story.Pagina.Where(p => !p.Layout).ToList().Count });

        }

        public ActionResult Preview(string Conteudo)
        {
            ViewBag.html = Conteudo;
            //return Json(html);
            return PartialView("Preview");
        }

        public ActionResult PaginaCriada(int capitulo, int versiculo)
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



    }
}
