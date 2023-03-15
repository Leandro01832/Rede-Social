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
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

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
        [Route("{capitulo?}/{verso?}")]
        [Route("{verso:int?}")]
        [Route("")]
        public async Task<IActionResult> Index(string compartilhante, int? capitulo, int? verso)
        {
            var usuario = await UserManager.GetUserAsync(this.User);
            if(usuario != null)
            {
                    var lista = await  UserManager.GetRolesAsync(usuario);
                    if(lista.FirstOrDefault(i => i == "Admin") != null)
                    ViewBag.user = usuario.UserName;
                    else
                    ViewBag.user = "";
            }

            var stories = await _context.Story.Where(str => str.Nome != "Padrao")
           .OrderBy(st => st.Nome)
           .ToListAsync();
            var users = UserManager.Users.ToList().Count;

            if (string.IsNullOrEmpty(compartilhante)) compartilhante = "user";

            
            ViewBag.stories = stories;
            ViewBag.compartilhante = compartilhante;
            ViewBag.users = users;
            ViewBag.livro = RepositoryPagina.outroLivro;
            ViewBag.capitulo = RepositoryPagina.outroCapitulo;
            ViewBag.livro1 = RepositoryPagina.livros[0];
            ViewBag.livro2 = RepositoryPagina.livros[1];
            ViewBag.livro3 = RepositoryPagina.livros[2];
            ViewBag.livro4 = RepositoryPagina.livros[3];
            ViewBag.livro5 = RepositoryPagina.livros[4];
            ViewBag.livro6 = RepositoryPagina.livros[5];
            ViewBag.livro7 = RepositoryPagina.livros[6];
            ViewBag.livro8 = RepositoryPagina.livros[7];
            ViewBag.livro9 = RepositoryPagina.livros[8];
            ViewBag.livro10 = RepositoryPagina.livros[9];

            if(capitulo != null)
            {
              return  RedirectToAction("Renderizar", "Visualizar",
                 new{indice = verso, capitulo = capitulo, auto = 0, compartilhante = "user"});
            }
            if(verso != null)
            {
              return  Redirect($"{RepositoryPagina.outroLivro}/Renderizar/{RepositoryPagina.outroCapitulo}/{verso}/0/user");
            }
            return View();
        }

         
        [Authorize]
        public async Task<IActionResult> Edit()
        {
            var user = await UserManager.GetUserAsync(this.User);
            return View(user);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Edit(string Livro, IFormFile imagem)
        {
            var user = await UserManager.GetUserAsync(this.User);
            user.Livro = Livro;

          var result = await  UserManager.UpdateAsync(user);

           if (result.Succeeded && Request.Form.Files.Count > 0)
            {
                var Image = imagem;
                byte[] buffer = new byte[16 * 1024];
                using (FileStream output = System.IO.File.Create(this.HostingEnvironment.WebRootPath + "\\ImagensUsers\\" +
                    user.Name + ".jpg"))
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
            }

          if(result.Succeeded)
            return RedirectToAction("Index");
            else
            return View(user);
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

          [Authorize]
        public async Task<ActionResult> Transmissao(string email)
        {
             var usuario = await UserManager.GetUserAsync(this.User);
            ViewBag.email = email;

            return View(usuario);
        }

        [Authorize]
        public async Task<ActionResult> MinhaSala()
        {
            var usuario = await UserManager.GetUserAsync(this.User);
            var lista = await  UserManager.GetRolesAsync(usuario);
                    if(lista.FirstOrDefault(i => i == "Admin") != null)
                ViewBag.condicao = true;
                    else
                ViewBag.condicao = false;


            return PartialView(usuario);
        }

         [Authorize]
        [Route("Comentario/{idPagina?}")]
        public IActionResult Comentar()
        {
            return PartialView();
        }

        [HttpPost]
         public async Task<IActionResult> Comentar(string Conteudo)
        {
            var user = await UserManager.GetUserAsync(this.User);
            var Quant = await _context.Story.Where(st => st.Nome != "Padrao").ToListAsync();
            var comenta = await _context.Story.Include(st => st.Pagina)
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
                    Music = false,
                    Tempo = 11000
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
                Music = false,
                Tempo = 11000
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
                    PalavrasTexto = 
                    $"<div id='usuario' style='display:nome;'>" +
                    $" <img src='{user.Image}' width='30' >{user.UserName}</div> <br/> <br/> {Conteudo}"
                }

            });

            pagina.Div = new List<PaginaContainer>();
            foreach (var item in pagin.Div)

                pagina.IncluiDiv(item.Container);

            _context.SaveChanges();
            RepositoryPagina.paginas.Clear();           

            return View("Index", "Home");
        }

    }
}
