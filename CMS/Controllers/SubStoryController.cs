using System;
using CMS.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CMS.Data;
using business.business.Group;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace CMS.Controllers
{
    [Authorize]
    public class SubStoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserManager<UserModel> UserManager { get; }

        public SubStoryController(ApplicationDbContext context, UserManager<UserModel> userManager)
        {
            _context = context;
            UserManager = userManager;
        }

        // GET: SubStory
        [Route("SubStory/Index/{pagina?}")]
        public async Task<IActionResult> Index(int? pagina)
        {
             var usuario = await UserManager.GetUserAsync(this.User);
             int numeroPagina = (pagina ?? 1);
            const int TAMANHO_PAGINA = 5;
            ViewBag.pagina = numeroPagina;

            var substories = await _context.SubStory
            .Include(s => s.Story)
            .Where(str => str.Story.UserId == usuario.Id)
            .Skip((numeroPagina - 1) * TAMANHO_PAGINA)
            .Take(TAMANHO_PAGINA)
            .ToListAsync();
            return View(substories);
        }

        // GET: SubStory/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subStory = await _context.SubStory
                .Include(s => s.Story)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subStory == null)
            {
                return NotFound();
            }

            return View(subStory);
        }

        // GET: SubStory/Create
        public async Task<IActionResult> Create()
        {
            var user = await UserManager.GetUserAsync(this.User);
            var stories = await _context.Story.Where(str => str.UserId == user.Id && str.Nome != "Padrao").ToListAsync();
            ViewData["StoryId"] = new SelectList(stories, "Id", "CapituloComNome");
            return View();
        }

        // POST: SubStory/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( SubStory subStory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(subStory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

             var user = await UserManager.GetUserAsync(this.User);
            var stories = await _context.Story.Where(str => str.UserId == user.Id && str.Nome != "Padrao").ToListAsync();
            ViewData["StoryId"] = new SelectList(stories, "Id", "CapituloComNome", subStory.StoryId);
            return View(subStory);
        }

        // GET: SubStory/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subStory = await _context.SubStory.FindAsync(id);
            if (subStory == null)
            {
                return NotFound();
            }
             var user = await UserManager.GetUserAsync(this.User);
            var stories = await _context.Story.Where(str => str.UserId == user.Id && str.Nome != "Padrao").ToListAsync();
            ViewData["StoryId"] = new SelectList(stories, "Id", "CapituloComNome", subStory.StoryId);
            return View(subStory);
        }

        // POST: SubStory/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(SubStory subStory)
        {
            

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(subStory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubStoryExists(subStory.Id))
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
             var user = await UserManager.GetUserAsync(this.User);
            var stories = await _context.Story.Where(str => str.UserId == user.Id && str.Nome != "Padrao").ToListAsync();
            ViewData["StoryId"] = new SelectList(stories, "Id", "CapituloComNome", subStory.StoryId);
            return View(subStory);
        }

        // GET: SubStory/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subStory = await _context.SubStory
                .Include(s => s.Story)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subStory == null)
            {
                return NotFound();
            }

            return View(subStory);
        }

        // POST: SubStory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var subStory = await _context.SubStory.FindAsync(id);
            _context.SubStory.Remove(subStory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SubStoryExists(long id)
        {
            return _context.SubStory.Any(e => e.Id == id);
        }
    }
}
