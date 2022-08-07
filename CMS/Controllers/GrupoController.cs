using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CMS.Data;
using business.business.Group;

namespace CMS.Controllers
{
    public class GrupoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GrupoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Grupo
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Grupo.Include(g => g.SubStory);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Grupo/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var grupo = await _context.Grupo
                .Include(g => g.SubStory)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (grupo == null)
            {
                return NotFound();
            }

            return View(grupo);
        }

        // GET: Grupo/Create
        public IActionResult Create()
        {
            ViewData["SubStoryId"] = new SelectList(_context.SubStory, "Id", "Id");
            return View();
        }

        // POST: Grupo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SubStoryId,Id")] Grupo grupo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(grupo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SubStoryId"] = new SelectList(_context.SubStory, "Id", "Id", grupo.SubStoryId);
            return View(grupo);
        }

        // GET: Grupo/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var grupo = await _context.Grupo.FindAsync(id);
            if (grupo == null)
            {
                return NotFound();
            }
            ViewData["SubStoryId"] = new SelectList(_context.SubStory, "Id", "Id", grupo.SubStoryId);
            return View(grupo);
        }

        // POST: Grupo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("SubStoryId,Id")] Grupo grupo)
        {
            if (id != grupo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(grupo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GrupoExists(grupo.Id))
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
            ViewData["SubStoryId"] = new SelectList(_context.SubStory, "Id", "Id", grupo.SubStoryId);
            return View(grupo);
        }

        // GET: Grupo/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var grupo = await _context.Grupo
                .Include(g => g.SubStory)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (grupo == null)
            {
                return NotFound();
            }

            return View(grupo);
        }

        // POST: Grupo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var grupo = await _context.Grupo.FindAsync(id);
            _context.Grupo.Remove(grupo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GrupoExists(long id)
        {
            return _context.Grupo.Any(e => e.Id == id);
        }
    }
}
