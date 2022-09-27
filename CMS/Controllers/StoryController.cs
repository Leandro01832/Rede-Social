using business.Back;
using business.business;
using business.business.Group;
using business.business.Elementos.texto;
using business.business.link;
using business.div;
using business.Join;
using CMS.Data;
using CMS.Models;
using CMS.Models.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using business.business.div;

namespace CMS.Controllers
{
    [Authorize(Roles = "Admin")]
    public class StoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserManager<UserModel> UserManager { get; }
        public IRepositoryPagina epositoryPagina { get; }

        public StoryController(ApplicationDbContext context, UserManager<UserModel> userManager,
            IRepositoryPagina repositoryPagina)
        {
            _context = context;
            UserManager = userManager;
            epositoryPagina = repositoryPagina;
        }

        // GET: Story
        [Route("Story/Index/{pagina?}")]
        public async Task<IActionResult> Index(int? pagina)
        {
            var usuario = await UserManager.GetUserAsync(this.User);
            int numeroPagina = (pagina ?? 1);
            const int TAMANHO_PAGINA = 5;
            ViewBag.pagina = numeroPagina;

            var stories = await _context.Story
            .Where(str => str.UserId == usuario.Id)
            .Skip((numeroPagina - 1) * TAMANHO_PAGINA)
            .Take(TAMANHO_PAGINA)
            .ToListAsync();
            return View(stories);
        }
        
        public async Task<IActionResult> Details(Int64? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var story = await _context.Story
                .FirstOrDefaultAsync(m => m.Id == id);
            if (story == null)
            {
                return NotFound();
            }

            return View(story);
        }
        
        public async Task<IActionResult> Create()
        {
            var user = await UserManager.GetUserAsync(this.User);
            ViewBag.UserId = user.Id;
            var lst = await _context.Story.Where(st => st.Nome != "Padrao" && st.UserId == user.Id).ToListAsync();
            Story story = new Story
            {
                PaginaPadraoLink = lst.Count + 1
            };
            return View(story);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Story story)
        {
            
            var user = await UserManager.GetUserAsync(this.User);
            ViewBag.UserId = user.Id;
            var str = await _context.Story.
            FirstOrDefaultAsync(st => st.Nome.ToLower() == story.Nome.ToLower() && st.UserId == user.Id);
            if (str != null)
            {
                ModelState.AddModelError("", "Este story ja existe!!!");
                return View(story);
            }

            _context.Add(story);
            await _context.SaveChangesAsync();

            var Story = await _context.Story.FirstAsync(st => st.Nome == "Padrao" && st.UserId == user.Id);

            var pagina = new Pagina()
            {
                 Data = DateTime.Now,
                    ArquivoMusic = "",
                    UserId = user.Id,
                    Html = "",
                    Titulo = "Story - " + story.Nome,
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
            
           var  pagin = new Pagina(1);  
            pagin.Div.First(d => d.Container.Content).Container.Div
            .First(d => d.Div.Content).Div.Elemento = new List<DivElemento>();
            pagin.Div.First(d => d.Container.Content).Container.Div
            .First(d => d.Div.Content).Div.Elemento.Add(new DivElemento
            {
                Div = pagin.Div.First(d => d.Container.Content).Container.Div
                .First(d => d.Div.Content).Div,
                Elemento = new LinkBody
                {
                    Pagina_ = pagina.Id,
                    TextoLink = "#LinkPadrao",
                    Texto = new Texto
                    {
                        Pagina_ = pagina.Id,
                        PalavrasTexto = "<h1> Story " + story.Nome + "</h1>"
                    },
                }
            });

                pagina.Div = new List<PaginaContainer>();                
            foreach (var item in pagin.Div)
            
                pagina.IncluiDiv(item.Container);
             
                _context.SaveChanges();   
            

             Pagina pag = await epositoryPagina.includes().FirstOrDefaultAsync(p => p.Id == pagina.Id);

             foreach (var item in RepositoryPagina.paginas)  
             {
                if(item == null || item.FirstOrDefault(i => i.UserId == user.Id) == null)
                    continue;

                if(item.FirstOrDefault(p => p.Id == pag.Id) != null)
                {
                    item.Remove(item.First(p => p.Id == pag.Id));
                    item.Add(pag);
                    break;
                }
             }

            return RedirectToAction(nameof(Index));
        }
        
        public async Task<IActionResult> Edit(Int64? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var story = await _context.Story.FindAsync(id);
            if (story == null)
            {
                return NotFound();
            }
            var user = await UserManager.GetUserAsync(this.User);
            ViewBag.UserId = user.Id;
            return View(story);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Story story)
        {
            var user = await UserManager.GetUserAsync(this.User);
            ViewBag.UserId = user.Id;
            var str = await _context.Story.
            FirstOrDefaultAsync(st => st.Nome.ToLower() == story.Nome.ToLower() && st.UserId == user.Id);
            if (str != null)
            {
                ModelState.AddModelError("", "Este story já existe!!!");
                return View(story);
            }

            try
            {
                _context.Update(story);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                if (!StoryExists(story.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: Story/Delete/5
        public async Task<IActionResult> Delete(Int64? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var story = await _context.Story
                .FirstOrDefaultAsync(m => m.Id == id);
            if (story == null)
            {
                return NotFound();
            }

            return View(story);
        }

        // POST: Story/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var story = await _context.Story.FindAsync(id);
            foreach (var item in story.Pagina)           
            _context.Remove(await _context.Pagina.FirstAsync(p => p.Id == item.Id));
            await _context.SaveChangesAsync();
            var pag = new Pagina();
            pag.StoryId = story.Id;
            pag.Div = new List<PaginaContainer>();
            pag.Titulo = "Capa";
            pag.UserId = story.UserId;
            pag.Sobreescrita = "";
            pag.CarouselPagina = new List<PaginaCarouselPagina>();
            _context.Add(pag);
            _context.SaveChanges();

            for (int indice = 0; indice < RepositoryPagina.paginas.Length; indice++)
                    {
                        if(RepositoryPagina.paginas[indice] == null ||
                         RepositoryPagina.paginas[indice].FirstOrDefault(i => i.StoryId == story.Id) == null) continue;

                        if(RepositoryPagina.paginas[indice].FirstOrDefault(i => i.StoryId == story.Id) != null)
                        {
                            RepositoryPagina.paginas[indice].RemoveAll(i => i.StoryId == story.Id);
                            RepositoryPagina.paginas[indice].Add(pag);
                            break;
                        }
                    }
            return RedirectToAction(nameof(Index));
        }

        private bool StoryExists(Int64 id)
        {
            return _context.Story.Any(e => e.Id == id);
        }
    }
}
