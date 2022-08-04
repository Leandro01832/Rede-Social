using business.Back;
using business.business;
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
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Controllers
{
    [Authorize(Roles = "SuperAdmin")]
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
        public async Task<IActionResult> IndexBackground()
        {
            var applicationDbContext = _context.Background;
            return View(await applicationDbContext.ToListAsync());
        }
        public async Task<IActionResult> IndexElementoDependente()
        {
            var elementos = _context.ElementoDependente;
            return View(await elementos.ToListAsync());
        }

        #endregion
        
        //Região Detalhes
        #region
        public async Task<IActionResult> DetailsBackground(Int64? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var background = await _context.Background
                .FirstOrDefaultAsync(m => m.Id == id);
            if (background == null)
            {
                return NotFound();
            }

            return View(background);
        }
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

            pagina.Div = new List<DivPagina>();

            pagina.Div.AddRange(new List<DivPagina> {
                new DivPagina{ Div = new DivComum() }, new DivPagina{ Div = new DivComum() },
                new DivPagina{ Div = new DivComum() }, new DivPagina{ Div = new DivComum() },
                new DivPagina{ Div = new DivComum() }, new DivPagina{ Div = new DivComum() }
            });

            for (int i = 0; i <= 5; i++)
            {
                pagina.Div[i].Div = new DivComum
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

            for (int indice = 0; indice <= RepositoryPagina.paginas.Length; indice++)
                    {
                         if(RepositoryPagina.paginas[indice] != null && RepositoryPagina.paginas[indice].Count >= 1000000000) continue;

                        if(RepositoryPagina.paginas[indice] == null) RepositoryPagina.paginas[indice] = new List<Pagina>();
                        if(RepositoryPagina.paginas[indice].Count < 1000000000)
                        {
                            RepositoryPagina.paginas[indice].Add(pagina);
                            break;
                        }
                    }

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
