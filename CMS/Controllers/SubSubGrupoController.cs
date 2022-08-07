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
    public class SubSubGrupoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SubSubGrupoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SubSubGrupo
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.SubSubGrupo.Include(s => s.SubGrupo);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: SubSubGrupo/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subSubGrupo = await _context.SubSubGrupo
                .Include(s => s.SubGrupo)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subSubGrupo == null)
            {
                return NotFound();
            }

            return View(subSubGrupo);
        }

        // GET: SubSubGrupo/Create
        public IActionResult Create()
        {
            ViewData["SubGrupoId"] = new SelectList(_context.SubGrupo, "Id", "Id");
            return View();
        }

        // POST: SubSubGrupo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SubGrupoId,Id")] SubSubGrupo subSubGrupo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(subSubGrupo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SubGrupoId"] = new SelectList(_context.SubGrupo, "Id", "Id", subSubGrupo.SubGrupoId);
            return View(subSubGrupo);
        }

        // GET: SubSubGrupo/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subSubGrupo = await _context.SubSubGrupo.FindAsync(id);
            if (subSubGrupo == null)
            {
                return NotFound();
            }
            ViewData["SubGrupoId"] = new SelectList(_context.SubGrupo, "Id", "Id", subSubGrupo.SubGrupoId);
            return View(subSubGrupo);
        }

        // POST: SubSubGrupo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("SubGrupoId,Id")] SubSubGrupo subSubGrupo)
        {
            if (id != subSubGrupo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(subSubGrupo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubSubGrupoExists(subSubGrupo.Id))
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
            ViewData["SubGrupoId"] = new SelectList(_context.SubGrupo, "Id", "Id", subSubGrupo.SubGrupoId);
            return View(subSubGrupo);
        }

        // GET: SubSubGrupo/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subSubGrupo = await _context.SubSubGrupo
                .Include(s => s.SubGrupo)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subSubGrupo == null)
            {
                return NotFound();
            }

            return View(subSubGrupo);
        }

        // POST: SubSubGrupo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var subSubGrupo = await _context.SubSubGrupo.FindAsync(id);
            _context.SubSubGrupo.Remove(subSubGrupo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SubSubGrupoExists(long id)
        {
            return _context.SubSubGrupo.Any(e => e.Id == id);
        }
    }
}
