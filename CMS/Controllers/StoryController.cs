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
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using business.business.div;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CMS.Controllers
{
    [Authorize(Roles = "Admin")]
    public class StoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserManager<UserModel> UserManager { get; }
        public IRepositoryPagina epositoryPagina { get; }
        public IHostingEnvironment HostingEnvironment { get; }

        public StoryController(ApplicationDbContext context, UserManager<UserModel> userManager,
            IRepositoryPagina repositoryPagina, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            UserManager = userManager;
            epositoryPagina = repositoryPagina;
            HostingEnvironment = hostingEnvironment;
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
            var lst = await _context.Story.Where(st => st.Nome != "Padrao").ToListAsync();
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
            FirstOrDefaultAsync(st => st.Nome.ToLower() == story.Nome.ToLower());
            if (str != null)
            {
                ModelState.AddModelError("", "Este story ja existe!!!");
                return View(story);
            }

            _context.Add(story);
            await _context.SaveChangesAsync();

            var Story = await _context.Story.FirstAsync(st => st.Nome == "Padrao");

           Pagina.entity = true;
            var pagina = new Pagina()
            {
                Titulo = "Story - " + Story.Nome,
                StoryId = Story.Id,                
                Layout = false
            };
            Pagina.entity = false;             

             _context.Add(pagina);
             _context.SaveChanges(); 
            
           var  pagin = new Pagina(1);  
            pagin.setarElemento
            (new Texto { Pagina_ = pagina.Id, 
            PalavrasTexto = "<h1> Story " + story.Nome + "</h1>" });

                pagina.Div = new List<PaginaContainer>();                
            foreach (var item in pagin.Div)
            
                pagina.IncluiDiv(item.Container);
             
                _context.SaveChanges();   

                 string path = this.HostingEnvironment.WebRootPath + "\\Stories\\" + story.Id + "\\";

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);             

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
            FirstOrDefaultAsync(st => st.Nome.ToLower() == story.Nome.ToLower());
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
            
            Pagina.entity = true;
            var pag = new Pagina()
            {
                Titulo = "Story - " + story.Nome,
                StoryId = story.Id,                
                Layout = false
            };
            Pagina.entity = false;
            _context.Add(pag);
            _context.SaveChanges();
            
            return RedirectToAction(nameof(Index));
        }

        private bool StoryExists(Int64 id)
        {
            return _context.Story.Any(e => e.Id == id);
        }

        
        public async Task<IActionResult> DeleteStory()
        {
            var stories = await _context.Story.Where(st => st.Nome != "Padrao").ToListAsync();            
            ViewBag.id = new SelectList(stories, "Id", "CapituloComNome");
            return View();
        }

        [HttpPost, ActionName("DeleteStory")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmedStory(long id)
        {
            var str = await _context.Story
            .Include(p => p.Pagina)
            .ThenInclude(p => p.Div)
            .FirstAsync(p => p.Id == id);
            foreach(var item in str.Pagina.Where(p => p.Div.Count > 0)) 
             {

                foreach(var item2 in item.Div)
                _context.Remove(item2);            
                await _context.SaveChangesAsync();           
                item.Titulo = "Capa";
                if(item.SubStoryId != null) item.SubStoryId = null;
                if(item.GrupoId != null) item.GrupoId = null;
                if(item.SubGrupoId != null) item.SubGrupoId = null;
                if(item.SubSubGrupoId != null) item.SubSubGrupoId = null;
                _context.Update(item);
                await _context.SaveChangesAsync();           
             }
            
            RepositoryPagina.paginas.Clear();

            return RedirectToAction("Galeria", "Pedido");
        }
    }
}
