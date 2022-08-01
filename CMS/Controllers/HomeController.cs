using business.Back;
using business.business;
using business.business.Elementos.texto;
using business.div;
using business.Join;
using CMS.Data;
using CMS.Models;
using CMS.Models.Repository;
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

        
        public IActionResult Index()
        {
            var option = Request.Cookies["automatico"];
            var option2 = Request.Cookies["story"];
            if (option == null)
                Set("automatico", "0", 12);
            if (option2 == null)
                Set("story", "0", 12);

         var p = RepositoryPagina.paginas.FirstOrDefault();

            return View();
        }

        [Route("Perfil/{Name}")]
        public async Task<IActionResult> Perfil(string Name)
        {
            var user = UserHelper.Users.FirstOrDefault(u => u.Name.ToLower() == Name);
            if (user == null)
            {
                user = await UserManager.Users.FirstOrDefaultAsync(u => u.Name.ToLower() == Name);
                UserHelper.Users.Add(user);
            }

          //  if (RepositoryPagina.paginas.FirstOrDefault(p => p.UserId == user.Id) == null)
          //  {
          //      RepositoryPagina.paginas.RemoveAll(p => p.UserId == user.Id);
          //      var lst = await epositoryPagina.MostrarPageModels(user.Id);
          //      var quant = lst.Where(l => !l.Layout && !l.LayoutModelo).ToList().Count;
          //      RepositoryPagina.paginas.AddRange(lst.Where(l => !l.Layout && !l.LayoutModelo).ToList());

               // if (RepositoryPagina.paginas.Where(p => p.UserId == user.Id &&
               // !p.Layout && !p.LayoutModelo).ToList().Count != quant)
               // {
               //     RepositoryPagina.paginas.RemoveAll(p => p.UserId == user.Id);
               //     RepositoryPagina.paginas.AddRange(lst.Where(l => !l.Layout && !l.LayoutModelo).ToList());
               // }
          //  }

            user.Seguidores = await _context.Seguidor.Where(u => u.User == user.Id).ToListAsync();
            user.Seguindo = await _context.Seguindo.Where(u => u.User == user.Id).ToListAsync();
            var stories = await _context.Story.Where(str => str.UserId == user.Id && str.Nome != "Padrao")
                .OrderBy(st => st.Nome)
                .ToListAsync();

            var seguidores = new List<UserModel>();
            var seguindo = new List<UserModel>();

            foreach (var item in user.Seguidores)
                seguidores.Add(await UserManager.Users.FirstAsync(u => u.Id == item.UserIdSeguidor));

            foreach (var item in user.Seguindo)
                seguindo.Add(await UserManager.Users.FirstAsync(u => u.Id == item.UserIdSeguindo));

            var solicitacoes = await _context.Solicitacao.
                Where(sol => sol.UserId == user.Id &&
                seguidores.FirstOrDefault(u => u.Id == sol.UserIdSolicitando) == null).ToListAsync();

            var UsuarioSolicitando = new List<UserModel>();

            foreach (var item in solicitacoes)
                UsuarioSolicitando.Add(await UserManager.Users.FirstOrDefaultAsync(u => u.Id == item.UserIdSolicitando));

            ViewBag.seguidores = seguidores;
            ViewBag.seguindo = seguindo;
            ViewBag.stories = stories;
            ViewBag.solicitacoes = UsuarioSolicitando;

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
            var user2 = await UserManager.Users.FirstOrDefaultAsync(u => u.Id == user.Id);
            user2.Image = "/ImagensUsers/" + user2.Name + ".jpg";
            user2.Facebook = user.Facebook;
            user2.Twitter = user.Twitter;
            user2.Instagram = user.Instagram;

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

            return View(user2);
        }

        [Authorize]
        public async Task<IActionResult> Seguir(string Name)
        {
            var usuario = await UserManager.GetUserAsync(this.User);
            var user = await UserManager.Users.FirstOrDefaultAsync(u => u.Name == Name);

            MailMessage mail = new MailMessage(usuario.UserName, user.UserName);

            var solicitacao = new Solicitacao { UserIdSolicitando = usuario.Id, UserId = user.Id };

            mail.Subject = "Solicitação para seguir";
            mail.Body = "<img class='img-circle img-responsive' src='@Model.Image width='100' /> <br />";
            mail.Body += "<p> Você aceita o usuário " + usuario.Name + " - " + usuario.UserName + " como seguidor? </p>";
            mail.Body += "<form action='/Home/Aceitar' method='Post' > ";
            mail.Body += " <input type='hidden' value='" + usuario.Name + "' name='Seguidor' id='Seguidor'  /> ";
            mail.Body += " <input type='hidden' value='" + user.Name + "' name='Seguindo' id='Seguindo'  /> ";
            mail.Body += " <input type='submit' value='Aceitar' class='btn btn-default' /> ";
            mail.Body += " </form>";

            try
            {
                await EmailSender.SendEmailAsync(
                            null,
                            mail.Subject,
                            mail.Body);

            }
            catch (Exception)
            {
                View("NaoEnviado");
            }
            return View(user);
        }
        
        public async Task<IActionResult> Aceitar(string Seguidor, string Seguindo)
        {
            var usuario = await UserManager.GetUserAsync(this.User);
            var userSeguidor = await UserManager.Users.FirstOrDefaultAsync(u => u.Name == Seguidor);
            var userSeguindo = await UserManager.Users.FirstOrDefaultAsync(u => u.Name == Seguindo);

            var registroSeguidor = new Seguidor { UserIdSeguidor = userSeguidor.Id, User = userSeguindo.Id };
            var registroSeguindo = new Seguindo { UserIdSeguindo = userSeguindo.Id, User = userSeguidor.Id };

            await _context.AddAsync(registroSeguidor);
            await _context.AddAsync(registroSeguindo);

            await _context.SaveChangesAsync();

            return View();
        }

        [Authorize]
        public async Task<IActionResult> CreatePagina()
        {
            var user = await UserManager.GetUserAsync(this.User);
            var lista = await _context.Story.Where(st => st.UserId == user.Id && st.Nome != "Padrao").ToListAsync();
            var layouts = await _context.Pagina.Where(p => p.UserId == user.Id && p.Layout).ToListAsync();

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
            return View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreatePagina(string Titulo, string UserId, Int64 StoryId, string Conteudo, Int64 Layout)
        {
            var user = await UserManager.GetUserAsync(this.User);            
            
                var page = await _context.Pagina.
                    Include(p => p.Div).
                    ThenInclude(p => p.Div).
                    ThenInclude(p => p.Elemento).
                    Include(p => p.Div).
                    ThenInclude(p => p.Div).
                    ThenInclude(p => p.Background).
                    FirstAsync(p => p.Id == Layout);

                Pagina pagina = new Pagina
                {
                    ArquivoMusic = "",
                    Margem = false,
                    Music = false,                    
                    Titulo = Titulo,
                    Layout = false,
                    UserId = UserId,
                    StoryId = StoryId
                };

                pagina.Div = new List<DivPagina>();

                foreach (var item in page.Div)
                    pagina.Div.Add(new DivPagina { Div = item.Div, Pagina = pagina });

                if (pagina.Div.Count > 6)
                {
                    pagina.Div[6].Div.Elemento.Add(new DivElemento
                    {
                        Div = pagina.Div[6].Div,
                        Elemento = new Texto
                        {
                            PalavrasTexto = Conteudo
                        }
                    });
                }
                else
                {
                    var div = new DivPagina
                    {
                        Div = new DivComum(),
                        Pagina = pagina

                    };
                    pagina.Div.Add(div);
                    pagina.Div[6].Div.Elemento = new List<DivElemento>
                        {
                            new DivElemento
                            {
                                 Div = pagina.Div[6].Div,
                                 Elemento = new Texto
                                 {
                                     PalavrasTexto = Conteudo
                                 }
                            }
                        };
                }
                await _context.AddAsync(pagina);
                await _context.SaveChangesAsync();

                pagina.Div[6].Div.Elemento.OrderBy(e => e.Elemento.Id).Last().Elemento.PaginaEscolhida = pagina.Id;
                pagina.Div[6].Div.Elemento.OrderBy(e => e.Elemento.Id).Last().Elemento.Pagina_ = pagina.Id;

                _context.Elemento.Update(pagina.Div[6].Div.Elemento.OrderBy(e => e.Elemento.Id).Last().Elemento);
                await _context.SaveChangesAsync();
                RepositoryPagina.paginas.Add(pagina);           
                       
            
            var story = await _context.Story.Include(st => st.Pagina).FirstAsync(st => st.Id == pagina.StoryId);
            var versiculos = story.Pagina.Where(p => !p.Layout).ToList().Count;

            return RedirectToAction(nameof(PaginaCriada),
                new { user = user.Name, capitulo = story.PaginaPadraoLink, versiculo = versiculos });
        }
        
        public async Task<ActionResult> Preview(Int64 Layout, string Conteudo, string UserId)
        {
            Pagina pagina = new Pagina
            {
                ArquivoMusic = "",
                Margem = false,
                Music = false,
                Titulo = "Default",
                Layout = false,
                UserId = UserId,
                StoryId = 0
            };

            var page = await epositoryPagina.includes().FirstAsync(p => p.Id == Layout);
            pagina.Div = page.Div;
            if (pagina.Div.Count > 6)
            {
                pagina.Div[6].Div.Elemento.Add(new DivElemento
                {
                    Div = pagina.Div[6].Div,
                    Elemento = new Texto
                    {
                        PalavrasTexto = Conteudo
                    }
                });
            }
            else
            {
                var div = new DivPagina
                {
                    Div = new DivComum(),
                    Pagina = pagina

                };
                pagina.Div.Add(div);
                pagina.Div[6].Div.Elemento = new List<DivElemento>
                        {
                            new DivElemento
                            {
                                 Div = pagina.Div[6].Div,
                                 Elemento = new Texto
                                 {
                                     PalavrasTexto = Conteudo
                                 }
                            }
                        };
                pagina.Div[6].Div.Id = 1;
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
