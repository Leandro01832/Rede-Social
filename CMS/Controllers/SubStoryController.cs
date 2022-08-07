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
    public class SubStoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SubStoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SubStory
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.SubStory.Include(s => s.Story);
            return View(await applicationDbContext.ToListAsync());
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
        public IActionResult Create()
        {
            ViewData["StoryId"] = new SelectList(_context.Story, "Id", "Id");
            return View();
        }

        // POST: SubStory/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StoryId,Id")] SubStory subStory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(subStory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["StoryId"] = new SelectList(_context.Story, "Id", "Id", subStory.StoryId);
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
            ViewData["StoryId"] = new SelectList(_context.Story, "Id", "Id", subStory.StoryId);
            return View(subStory);
        }

        // POST: SubStory/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("StoryId,Id")] SubStory subStory)
        {
            if (id != subStory.Id)
            {
                return NotFound();
            }

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
            ViewData["StoryId"] = new SelectList(_context.Story, "Id", "Id", subStory.StoryId);
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
