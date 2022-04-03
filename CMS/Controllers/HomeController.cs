using business.business;
using CMS.Data;
using CMS.Models;
using CMS.Models.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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

        public HomeController(UserManager<UserModel> userManager, IRepositoryPagina repositoryPagina,
            ApplicationDbContext context, IHostingEnvironment hostingEnvironment,
            IConfiguration configuration, IServiceEmailSender emailSender)
        {
            UserManager = userManager;
            epositoryPagina = repositoryPagina;
            _context = context;
            HostingEnvironment = hostingEnvironment;
            Configuration = configuration;
            EmailSender = emailSender;
        }

        [Route("Carousel")]
        [Route("Carrossel")]
        [Route("Pages")]
        [Route("Paginas")]
        [Route("Index")]
        [Route("")]
        public IActionResult Index()
        {
            var option = Request.Cookies["automatico"];
            var option2 = Request.Cookies["story"];
            if (option == null)
                Set("automatico", "0", 12);
            if (option2 == null)
                Set("story", "0", 12);
            
            return View();
        }

        [Route("Perfil/{Name}")]
        public async Task<IActionResult> Perfil(string Name)
        {
           var user = await UserManager.Users.FirstOrDefaultAsync(u => u.Name.ToLower() == Name.Trim().ToLower());

            if(RepositoryPagina.paginas.FirstOrDefault(p => p.UserId == user.Id) == null)
            {
                RepositoryPagina.paginas.
               AddRange(await epositoryPagina.includes().Where(p => p.UserId == user.Id).ToListAsync());
            }

            user.Seguidores = await _context.Seguidor.Where(u => u.User == user.Id).ToListAsync();
            user.Seguindo = await _context.Seguindo.Where(u => u.User == user.Id).ToListAsync();
            var stories = await _context.Story.Where(str => str.UserId == user.Id && str.Nome != "Padrao").ToListAsync();

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

            var result =  await UserManager.UpdateAsync(user2);


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
        [Route("Seguir/{Id}")]
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
            mail.Body += " <input type='hidden' value='" + usuario.Name +"' name='Seguidor' id='Seguidor'  /> ";
            mail.Body += " <input type='hidden' value='" + user.Name +"' name='Seguindo' id='Seguindo'  /> ";
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

            Response.Cookies.Append(key, value, option);
        }

        
    }
}
