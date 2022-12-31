using business.Back;
using business.business;
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
        public async Task<IActionResult> CreatePagina()
        {
            var user = await UserManager.GetUserAsync(this.User);
            var lista = await _context.Story.Where(st => st.UserId == user.Id && st.Nome != "Padrao").ToListAsync();
            var layouts = await _context.Pagina.Where(p => p.UserId == user.Id && p.Layout).ToListAsync();
            var pastas = new List<PastaImagem>(){new PastaImagem(){Nome = "Informe a pasta.", Id = 0}};
            var listaPastas = await _context.PastaImagem.Where(p => p.UserId == user.Id).ToListAsync();
            var elementos = new List<Elemento>(){new Texto(){Nome = "Informe o elemento.", Id = 0}};
            var listaElementos = await _context.Elemento.ToListAsync();
            pastas.AddRange(listaPastas);
            elementos.AddRange(listaElementos);
            

             if (lista.Count == 0)
            {
                ViewBag.Error = "Crie seu story primeiro!!!";
                RedirectToAction("Create", "Story");
            }

             if (layouts.Count == 0)
            {
                ViewBag.Error = "Crie seu primeiro layout!!!";
                RedirectToAction("CreatePagina", "Pedido");
            }           

            ViewBag.UserId = user.Id;
            ViewBag.StoryId = new SelectList(lista, "Id", "Nome");
            ViewBag.Layout = new SelectList(layouts, "Id", "NomeComId");
            ViewBag.Pasta = new SelectList(pastas, "Id", "Identifica");
            ViewBag.Elemento = new SelectList(elementos, "Id", "NomeComId");

            var page = new Pagina();
            return View(page);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreatePagina(Pagina pag, string Conteudo, 
        Int64 Layout, Int64 Pasta, Int64 Elemento)
        {
            var user = await UserManager.GetUserAsync(this.User);   
            
                var page = await _context.Pagina.
                    Include(p => p.Div).
                    ThenInclude(p => p.Container).
                    ThenInclude(p => p.Div).
                    ThenInclude(p => p.Div).
                    ThenInclude(p => p.Elemento).
                    Include(p => p.Div).
                    ThenInclude(p => p.Container).
                     ThenInclude(p => p.Div).
                    ThenInclude(p => p.Div).
                    ThenInclude(p => p.Background).
                    FirstAsync(p => p.Id == Layout);    

                var cap = _context.Story.Include(s => s.Pagina).ThenInclude(s => s.Div).First(s => s.Id == pag.StoryId);

                if(Pasta != 0)
                {
                var pasta = _context.PastaImagem.Include(s => s.Imagens).First(s => s.Id == Pasta);
                foreach (var item in pasta.Imagens)
                {
                    var p = new Pagina(1);
                      p.ArquivoMusic = "";
                      p.Titulo =  "Imagem - " + item.Id;
                      p.UserId = user.Id;
                        p.Pular = false;
                        p.Layout = false;
                        p.StoryId = pag.StoryId;
                        p.SubStoryId = null;
                        p.GrupoId = null;
                        p.SubGrupoId = null;
                        p.SubSubGrupoId = null;
                        p.Div = null;

                        _context.Add(p);
                        _context.SaveChanges();

                        p.Div = new List<PaginaContainer>();
                        foreach (var item2 in page.Div)
                            p.IncluiDiv(item2.Container);                        
                            _context.SaveChanges();

                    try
                    {
                    _context.Add(new DivElemento
                    {
                        DivId = p.Div.First(d => d.Container.Content).Container.Div
                        .First(d => d.Div.Content).Div.Id,
                        ElementoId = item.Id
                    });
                            _context.SaveChanges(); 
                    }
                    catch(Exception ex){}
                    item.PaginaEscolhida = p.Id;
                    _context.Update(item);
                            _context.SaveChanges(); 
                            
                }
                return RedirectToAction(nameof(PaginasCriadas),
                new { user = user.Name, capitulo = cap.PaginaPadraoLink });

                }
                else
                {

                    if(Elemento != 0)
                    {
                         var elemento = _context.Elemento.First(s => s.Id == Elemento);

                          pag.ArquivoMusic = "";
                            pag.Pular = false;
                            pag.Layout = false;
                            pag.Div = null;

                            _context.Add(pag);
                            _context.SaveChanges();

                            pag.Div = new List<PaginaContainer>();
                            foreach (var item in page.Div)
                                pag.IncluiDiv(item.Container);                        
                                _context.SaveChanges();

                                pag.Div.First(d => d.Container.Content).Container.Div
                                .First(d => d.Div.Content).Div.Elemento = new List<DivElemento>();
                                pag.Div.First(d => d.Container.Content).Container.Div
                                .First(d => d.Div.Content).Div.Elemento.Add(new DivElemento
                                {
                                    Div = pag.Div.First(d => d.Container.Content).Container.Div
                                    .First(d => d.Div.Content).Div,
                                    Elemento = elemento
                                });
                                _context.SaveChanges();     
                                                
                            var story = await _context.Story.Include(st => st.Pagina).FirstAsync(st => st.Id == pag.StoryId);
                            var versiculos = story.Pagina.Where(p => !p.Layout).ToList().Count;

                            epositoryPagina.AtualizarPaginaStory(cap);
                            return RedirectToAction(nameof(PaginaCriada),
                                new { user = user.Name, capitulo = cap.PaginaPadraoLink, versiculo = cap.Pagina.Where(p => !p.Layout).ToList().Count });
                    }
                    else
                    {
                        if(cap.Pagina.FirstOrDefault(p => p.Div.Count == 0) == null)
                        {
                            pag.ArquivoMusic = "";
                            pag.Pular = false;
                            pag.Layout = false;
                            pag.Div = null;

                            _context.Add(pag);
                            _context.SaveChanges();

                            pag.Div = new List<PaginaContainer>();
                            foreach (var item in page.Div)
                                pag.IncluiDiv(item.Container);                        
                                _context.SaveChanges();

                                pag.Div.First(d => d.Container.Content).Container.Div
                                .First(d => d.Div.Content).Div.Elemento = new List<DivElemento>();
                                pag.Div.First(d => d.Container.Content).Container.Div
                                .First(d => d.Div.Content).Div.Elemento.Add(new DivElemento
                                {
                                    Div = pag.Div.First(d => d.Container.Content).Container.Div
                                    .First(d => d.Div.Content).Div,
                                    Elemento = new Texto
                                    {
                                    PalavrasTexto = Conteudo
                                    }
                                });
                                _context.SaveChanges();   
                                                     
                            var story = await _context.Story.Include(st => st.Pagina).FirstAsync(st => st.Id == pag.StoryId);
                            var versiculos = story.Pagina.Where(p => !p.Layout).ToList().Count;

                           // epositoryPagina.AtualizarPaginaStory(cap);
                            return RedirectToAction(nameof(PaginaCriada),
                                new { user = user.Name, capitulo = cap.PaginaPadraoLink, versiculo = cap.Pagina.Where(p => !p.Layout).ToList().Count });
                        }

                        else{

                            var p = cap.Pagina.FirstOrDefault(pa => pa.Div.Count == 0);
                            var pagi = _context.Pagina.Include(s => s.Story).Include(s => s.Div).First(pa => pa.Id == p.Id);

                            foreach (var item in page.Div)
                                pagi.IncluiDiv(item.Container);                        
                                _context.SaveChanges();

                            pagi.Div.First(d => d.Container.Content).Container.Div
                            .First(d => d.Div.Content).Div.Elemento = new List<DivElemento>();
                                pagi.Div.First(d => d.Container.Content).Container.Div
                                .First(d => d.Div.Content).Div.Elemento.Add(new DivElemento
                                {
                                    Div = p.Div.First(d => d.Container.Content).Container.Div
                                    .First(d => d.Div.Content).Div,
                                    Elemento = new Texto
                                    {
                                    PalavrasTexto = Conteudo
                                    }
                                });

                                _context.SaveChanges();                            

                                    epositoryPagina.AtualizarPaginaStory(cap);
                                    return RedirectToAction(nameof(PaginaCriada),
                                        new { user = user.Name, capitulo = cap.PaginaPadraoLink, versiculo = cap.Pagina.IndexOf(pagi) + 1 });

                        }            

                    }


                }

        }
        
        public async Task<ActionResult> Preview(Int64 Layout, string Conteudo,
         string UserId, Int64 Pasta, Int64 Elemento)
        {
            var page = await epositoryPagina.includes().FirstAsync(p => p.Id == Layout);
            Pagina pagina = new Pagina(1)
            {
                ArquivoMusic = "",
                Music = false,
                Titulo = "Default",
                Layout = false,
                UserId = UserId,
                StoryId = 0,
                FlexDirection = page.FlexDirection,
                AlignItems = page.AlignItems
            };

        
             pagina.Div = new List<PaginaContainer>();
                        foreach (var item2 in page.Div)
                            pagina.IncluiDiv(item2.Container);                        
                        
            if(Elemento != 0)
            {
                var elemento = _context.Elemento.First(s => s.Id == Elemento);
                 pagina.Div.First(d => d.Container.Content).Container.Div
                                .First(d => d.Div.Content).Div.Elemento = new List<DivElemento>();
                                pagina.Div.First(d => d.Container.Content).Container.Div
                                .First(d => d.Div.Content).Div.Elemento.Add(new DivElemento
                                {
                                    Div = pagina.Div.First(d => d.Container.Content).Container.Div
                                    .First(d => d.Div.Content).Div,
                                    Elemento = elemento
                                });
            }
            else
            {
                pagina.Div.First(d => d.Container.Content).Container.Div
                            .First(d => d.Div.Content).Div.Elemento = new List<DivElemento>();
                                pagina.Div.First(d => d.Container.Content).Container.Div
                                .First(d => d.Div.Content).Div.Elemento.Add(new DivElemento
                                {
                                    Div = pagina.Div.First(d => d.Container.Content).Container.Div
                                    .First(d => d.Div.Content).Div,
                                    Elemento = new Texto
                                    {
                                    PalavrasTexto = Conteudo
                                    }
                                });
            }


            string html = await epositoryPagina.renderizarPagina(pagina);
            ViewBag.html = html;

            //return Json(html);
            return PartialView("Preview");
        }
        
        public ActionResult PaginaCriada(string user, int capitulo, int versiculo)
        {
            ViewBag.user = user;            
            ViewBag.capitulo = capitulo;
            ViewBag.versiculo = versiculo;
            return View();
        }

        public ActionResult PaginasCriadas(string user, int capitulo)
        {
            ViewBag.user = user;            
            ViewBag.capitulo = capitulo;
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
