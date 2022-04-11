using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CMS.Data;
using business.business;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using CMS.Models;
using business.Join;
using business.div;
using business.Back;
using business.business.link;
using business.business.Elementos.texto;
using CMS.Models.Repository;

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

        // GET: Story/Details/5
        public async Task<IActionResult> Details(int? id)
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

        // GET: Story/Create
        public async Task<IActionResult> Create()
        {
            var user = await UserManager.GetUserAsync(this.User);
            ViewBag.UserId = user.Id;
            return View();
        }

        // POST: Story/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nome,UserId,PaginaPadraoLink,Id")] Story story)
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

            if (story.Nome != "Padrao" && story.PaginaPadraoLink == 0)
            {
                ModelState.AddModelError("", "Informe a pagina padrão que será o link para acessar story!!!");
                return View(story);
            }

            if (ModelState.IsValid)
            {
                var lst = await _context.Story.Where(st => st.Nome != "Padrao").ToListAsync();
                story.PaginaPadraoLink = lst.Count + 1;
                _context.Add(story);
                await _context.SaveChangesAsync();

                var Story = await _context.Story.FirstAsync(st => st.Nome == "Padrao" && st.UserId == user.Id);

                var pagina = new Pagina
                {
                    ArquivoMusic = "",
                    Html = "",
                    Margem = false,
                    Music = false,
                    Rotas = "",
                    Titulo = "Default",
                    Layout = false,
                    UserId = user.Id,
                    Exibicao = false,
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
                        TextoLink = "/" + user.Name + "/Story-" + story.Nome + "-Pagina/1",
                        Texto = new Texto
                        {
                            PalavrasTexto = "<h1> Story " + story.Nome + "</h1>"
                        },
                    }
                });

               await  _context.AddAsync(pagina);
                await _context.SaveChangesAsync();

                Pagina pag = await epositoryPagina.includes().FirstOrDefaultAsync(p => p.Id == pagina.Id);
                var lista = await epositoryPagina.MostrarPageModels(pag.UserId);
                RepositoryPagina.paginas.RemoveAll(p => p.UserId == pag.UserId);
                RepositoryPagina.paginas.AddRange(lista.Where(l => !l.Layout).ToList());


                return RedirectToAction(nameof(Index));
            }
            return View(story);
        }

        // GET: Story/Edit/5
        public async Task<IActionResult> Edit(int? id)
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

        // POST: Story/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
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
                ModelState.AddModelError("", "Este story ja existe!!!");
                return View(story);
            }

            if (story.Nome != "Padrao" && story.PaginaPadraoLink == 0)
            {
                ModelState.AddModelError("", "Informe a pagina padrão que será o link para acessar story!!!");
                return View(story);
            }

            if (ModelState.IsValid)
            {
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
            return View(story);
        }

        // GET: Story/Delete/5
        public async Task<IActionResult> Delete(int? id)
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

        private bool StoryExists(int id)
        {
            return _context.Story.Any(e => e.Id == id);
        }
    }
}
