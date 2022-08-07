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
    public class SubGrupoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SubGrupoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SubGrupo
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.SubGrupo.Include(s => s.Grupo);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: SubGrupo/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subGrupo = await _context.SubGrupo
                .Include(s => s.Grupo)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subGrupo == null)
            {
                return NotFound();
            }

            return View(subGrupo);
        }

        // GET: SubGrupo/Create
        public IActionResult Create()
        {
            ViewData["GrupoId"] = new SelectList(_context.Grupo, "Id", "Id");
            return View();
        }

        // POST: SubGrupo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GrupoId,Id")] SubGrupo subGrupo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(subGrupo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GrupoId"] = new SelectList(_context.Grupo, "Id", "Id", subGrupo.GrupoId);
            return View(subGrupo);
        }

        // GET: SubGrupo/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subGrupo = await _context.SubGrupo.FindAsync(id);
            if (subGrupo == null)
            {
                return NotFound();
            }
            ViewData["GrupoId"] = new SelectList(_context.Grupo, "Id", "Id", subGrupo.GrupoId);
            return View(subGrupo);
        }

        // POST: SubGrupo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("GrupoId,Id")] SubGrupo subGrupo)
        {
            if (id != subGrupo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(subGrupo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubGrupoExists(subGrupo.Id))
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
            ViewData["GrupoId"] = new SelectList(_context.Grupo, "Id", "Id", subGrupo.GrupoId);
            return View(subGrupo);
        }

        // GET: SubGrupo/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subGrupo = await _context.SubGrupo
                .Include(s => s.Grupo)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subGrupo == null)
            {
                return NotFound();
            }

            return View(subGrupo);
        }

        // POST: SubGrupo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var subGrupo = await _context.SubGrupo.FindAsync(id);
            _context.SubGrupo.Remove(subGrupo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SubGrupoExists(long id)
        {
            return _context.SubGrupo.Any(e => e.Id == id);
        }
    }
}
