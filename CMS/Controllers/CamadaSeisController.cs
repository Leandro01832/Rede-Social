using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CMS.Data;
using business.business.Group;
using Microsoft.AspNetCore.Authorization;

namespace Controllers
{
    [Authorize(Roles ="Admin")]
    public class CamadaSeisController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CamadaSeisController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CamadaSeis
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CamadaSeis.Include(c => c.SubSubGrupo);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CamadaSeis/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var camadaSeis = await _context.CamadaSeis
                .Include(c => c.SubSubGrupo)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (camadaSeis == null)
            {
                return NotFound();
            }

            return View(camadaSeis);
        }

        // GET: CamadaSeis/Create
        public IActionResult Create()
        {
            ViewData["SubSubGrupoId"] = new SelectList(_context.SubSubGrupo, "Id", "Id");
            return View();
        }

        // POST: CamadaSeis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nome,SubSubGrupoId,Id")] CamadaSeis camadaSeis)
        {
            if (ModelState.IsValid)
            {
                _context.Add(camadaSeis);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SubSubGrupoId"] = new SelectList(_context.SubSubGrupo, "Id", "Id", camadaSeis.SubSubGrupoId);
            return View(camadaSeis);
        }

        // GET: CamadaSeis/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var camadaSeis = await _context.CamadaSeis.FindAsync(id);
            if (camadaSeis == null)
            {
                return NotFound();
            }
            ViewData["SubSubGrupoId"] = new SelectList(_context.SubSubGrupo, "Id", "Id", camadaSeis.SubSubGrupoId);
            return View(camadaSeis);
        }

        // POST: CamadaSeis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Nome,SubSubGrupoId,Id")] CamadaSeis camadaSeis)
        {
            if (id != camadaSeis.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(camadaSeis);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CamadaSeisExists(camadaSeis.Id))
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
            ViewData["SubSubGrupoId"] = new SelectList(_context.SubSubGrupo, "Id", "Id", camadaSeis.SubSubGrupoId);
            return View(camadaSeis);
        }

        // GET: CamadaSeis/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var camadaSeis = await _context.CamadaSeis
                .Include(c => c.SubSubGrupo)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (camadaSeis == null)
            {
                return NotFound();
            }

            return View(camadaSeis);
        }

        // POST: CamadaSeis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var camadaSeis = await _context.CamadaSeis.FindAsync(id);
            _context.CamadaSeis.Remove(camadaSeis);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CamadaSeisExists(long id)
        {
            return _context.CamadaSeis.Any(e => e.Id == id);
        }
    }
}
