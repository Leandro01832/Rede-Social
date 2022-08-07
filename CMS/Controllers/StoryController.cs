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
        public async Task<IActionResult> Index()
        {
            var usuario = await UserManager.GetUserAsync(this.User);
            var stories = await _context.Story.Where(str => str.UserId == usuario.Id).ToListAsync();
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

            var pagina = new Pagina
            {
                ArquivoMusic = "",
                Margem = false,
                Music = false,
                Titulo = "Link Padrao",
                Layout = false,
                UserId = user.Id,
                StoryId = Story.Id
            };

            pagina.Div = new List<DivPagina>();
            pagina.Div.AddRange(new List<DivPagina> {
                new DivPagina{ Div = new DivComum() }, new DivPagina{ Div = new DivComum() },
                new DivPagina{ Div = new DivComum() }, new DivPagina{ Div = new DivComum() },
                new DivPagina{ Div = new DivComum() }, new DivPagina{ Div = new DivComum() },
                new DivPagina{ Div = new DivComum() }


            });

            for (int i = 0; i <= 6; i++)
            {
                if (i <= 6)
                    pagina.Div[i].Div = new DivComum
                    {
                        Background = new BackgroundCor
                        {
                            backgroundTransparente = true,
                            Cor = "transparent"
                        }
                    };
            }

            pagina.Div[6].Div.Elemento = new List<DivElemento>();
            pagina.Div[6].Div.Elemento.Add(new DivElemento
            {
                Div = pagina.Div[6].Div,
                Elemento = new LinkBody
                {
                    TextoLink = "#LinkPadrao",
                    Texto = new Texto
                    {
                        PalavrasTexto = "<h1> Story " + story.Nome + "</h1>"
                    },
                }
            });

            await _context.AddAsync(pagina);
            await _context.SaveChangesAsync();          
            

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
            _context.Story.Remove(story);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StoryExists(Int64 id)
        {
            return _context.Story.Any(e => e.Id == id);
        }
    }
}
