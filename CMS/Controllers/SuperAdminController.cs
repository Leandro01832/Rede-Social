using business.Back;
using business.business;
using business.business.div;
using business.div;
using business.Join;
using CMS.Data;
using CMS.Models;
using CMS.Models.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using business.business.Elementos.texto;

namespace CMS.Controllers
{
    [Authorize(Roles = "Admin")]
    public class SuperAdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserManager<UserModel> UserManager { get; }
        public IRepositoryPagina epositoryPagina { get; }

        public SuperAdminController(ApplicationDbContext context, UserManager<UserModel> userManager,
            IRepositoryPagina repositoryPagina)
        {
            _context = context;
            UserManager = userManager;
            epositoryPagina = repositoryPagina;
        }

        //Região Index
        #region        
         public async Task<ActionResult> Admin()
        {
            var user = await UserManager.GetUserAsync(this.User);
            var stories = await _context.Story.Where(str =>  str.Nome != "Padrao" && !str.Comentario).ToListAsync();

            if(stories.Count == 0)
            {
                ViewBag.Error = "Crie seu story primeiro!!!";
                RedirectToAction("Create", "Story");
            }

            ViewBag.UserId = user.Id;
            ViewBag.cap = new SelectList(stories, "Id", "CapituloComNome");

            return View();
        }
         
         public async Task<ActionResult> BaixarHtmlLivro()
        {
            var user = await UserManager.GetUserAsync(this.User);
            var stories = await _context.Story.Where(str =>  str.Nome != "Padrao" && !str.Comentario).ToListAsync();

            if(stories.Count == 0)
            {
                ViewBag.Error = "Crie seu story primeiro!!!";
                RedirectToAction("Create", "Story");
            }

            ViewBag.UserId = user.Id;
            ViewBag.cap = new SelectList(stories, "Id", "CapituloComNome");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> BaixarHtmlLivro(string livro, int capitulo, int versiculo, int cap)
        {
            var url = livro + "/" + capitulo + "/" + versiculo + "/1/user";
            
            WebClient client = new WebClient();
            var html = client.DownloadString(url);

            var story = await _context.Story
            .Include(str => str.Pagina)
            .ThenInclude(str => str.Produto)
            .Include(str => str.Pagina)
            .ThenInclude(str => str.Div)
            .FirstAsync(str => str.Id == cap);

            var pag = story.Pagina.FirstOrDefault(p => p.Div.Count == 0);

            if(pag != null)
            {
                var p = new Pagina(1, 1);

                pag.Div = new List<PaginaContainer>();                
                foreach (var item in p.Div)            
                pag.IncluiDiv(item.Container);             
                await  _context.SaveChangesAsync();  

                  
            pag.Div.First(d => d.Container.Content).Container.Div
            .First(d => d.Div.Content).Div.Elemento = new List<DivElemento>();
            pag.Div.First(d => d.Container.Content).Container.Div
            .First(d => d.Div.Content).Div.Elemento.Add(new DivElemento
            {
                Div = pag.Div.First(d => d.Container.Content).Container.Div
                .First(d => d.Div.Content).Div,
                Elemento =  new Texto
                    {
                        Pagina_ = pag.Id,
                        PalavrasTexto = html
                    },
                
            }); 
                await  _context.SaveChangesAsync();  
            return RedirectToAction("Index", "Home");
            }
            else if(story.Pagina
                .FirstOrDefault(p => p.Data > DateTime.Now.AddDays(-2) && p.Produto == null) != null)
            {
                pag = story.Pagina
                .First(p => p.Data > DateTime.Now.AddDays(-2) && p.Produto == null);

                 _context.Remove(pag.Div.First(d => d.Container.Content).Container.Div
            .First(d => d.Div.Content).Div.Elemento.First());
                await  _context.SaveChangesAsync();  
                 pag.Div.First(d => d.Container.Content).Container.Div
            .First(d => d.Div.Content).Div.Elemento.Add(new DivElemento
            {
                Div = pag.Div.First(d => d.Container.Content).Container.Div
                .First(d => d.Div.Content).Div,
                Elemento =  new Texto
                    {
                        Pagina_ = pag.Id,
                        PalavrasTexto = html
                    },
                
            }); 
                await  _context.SaveChangesAsync();  
                return RedirectToAction("Index", "Home");
            }
            else
            return View();

            
        }

        
        [Route("Mensagens")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.MensagemChat.ToListAsync());
        }
        [Route("Usuarios")]
        public IActionResult IndexUsers()
        {
            var usuarios = UserManager.Users.ToList();
            return View(usuarios);
        }
        
        public async Task<IActionResult> IndexElementoDependente()
        {
            var elementos = _context.ElementoDependente;
            return View(await elementos.ToListAsync());
        }

        #endregion
        
        //Região Detalhes
        #region
        
        public async Task<IActionResult> DetailsElementoDependente(Int64? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var elemento = await _context.ElementoDependente
                .FirstOrDefaultAsync(m => m.Id == id);
            if (elemento == null)
            {
                return NotFound();
            }

            return View(elemento);
        }
        public async Task<IActionResult> Details(Int64? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mensagemChat = await _context.MensagemChat
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mensagemChat == null)
            {
                return NotFound();
            }

            return View(mensagemChat);
        }
        #endregion


        #region Create
        public async Task<IActionResult> CreatePaginaModelo()
        {
            var user = await UserManager.GetUserAsync(this.User);
            var stories = await _context.Story.Where(str => str.UserId == user.Id && str.Nome != "Padrao").ToListAsync();            

            ViewBag.UserId = user.Id;
            ViewBag.StoryId = new SelectList(stories, "Id", "Nome");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreatePaginaModelo(Pagina pagina)
        {
            var user = await UserManager.GetUserAsync(this.User);
            var stories = await _context.Story.Where(str => str.UserId == user.Id).ToListAsync();

            pagina.Div = new List<PaginaContainer>();

            pagina.Div.AddRange(new List<PaginaContainer> {
                new PaginaContainer{ Container = new Container() }, new PaginaContainer{ Container = new Container() },
                new PaginaContainer{ Container = new Container() }, new PaginaContainer{ Container = new Container() },
                new PaginaContainer{ Container = new Container() }, new PaginaContainer{ Container = new Container() }
            });

            for (int i = 0; i <= 5; i++)
            {
                 foreach(var item in pagina.Div[i].Container.Div)
                item.Div = new DivComum
                {
                    Background = new BackgroundCor
                    {
                        backgroundTransparente = true,
                        Cor = "transparent"
                    }
                };
            }

            pagina.Layout = true;
            await _context.Pagina.AddAsync(pagina);
            await _context.SaveChangesAsync();            

            return RedirectToAction("Index", "Home");
        }


        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdMensagem,Pagina,NomeUsuario,Mensagem")] MensagemChat mensagemChat)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mensagemChat);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mensagemChat);
        }
        public IActionResult CreateElementoDependente()
        {
            ViewData["ElementoId"] = new SelectList(_context.Elemento, "IdElemento", "Discriminator");
            ViewData["ElementoDependenteId"] = new SelectList(_context.ElementoDependente, "IdElementoDependente", "IdElementoDependente");
            return View();
        }
        
        #endregion

        //Região Editar
        #region
        public async Task<IActionResult> Edit(Int64? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mensagemChat = await _context.MensagemChat.FindAsync(id);
            if (mensagemChat == null)
            {
                return NotFound();
            }
            return View(mensagemChat);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Int64 id, [Bind("IdMensagem,Pagina,NomeUsuario,Mensagem")] MensagemChat mensagemChat)
        {
            if (id != mensagemChat.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mensagemChat);
                    await _context.SaveChangesAsync();
                }
                catch (Exception)
                {
                    return NotFound();
                }
                return RedirectToAction(nameof(Index));
            }
            return View(mensagemChat);
        }

           
        #endregion

        //Região Ddelete
        #region
        public async Task<IActionResult> Delete(Int64? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mensagemChat = await _context.MensagemChat
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mensagemChat == null)
            {
                return NotFound();
            }

            return View(mensagemChat);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Int64 id)
        {
            var mensagemChat = await _context.MensagemChat.FindAsync(id);
            _context.MensagemChat.Remove(mensagemChat);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        #endregion

    }
}
