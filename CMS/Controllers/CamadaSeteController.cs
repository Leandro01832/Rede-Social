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
    public class CamadaSeteController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CamadaSeteController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CamadaSete
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CamadaSete.Include(c => c.CamadaSeis);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CamadaSete/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var camadaSete = await _context.CamadaSete
                .Include(c => c.CamadaSeis)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (camadaSete == null)
            {
                return NotFound();
            }

            return View(camadaSete);
        }

        // GET: CamadaSete/Create
        public IActionResult Create()
        {
            ViewData["CamadaSeisId"] = new SelectList(_context.CamadaSeis, "Id", "Id");
            return View();
        }

        // POST: CamadaSete/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nome,CamadaSeisId,Id")] CamadaSete camadaSete)
        {
            if (ModelState.IsValid)
            {
                _context.Add(camadaSete);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CamadaSeisId"] = new SelectList(_context.CamadaSeis, "Id", "Id", camadaSete.CamadaSeisId);
            return View(camadaSete);
        }

        // GET: CamadaSete/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var camadaSete = await _context.CamadaSete.FindAsync(id);
            if (camadaSete == null)
            {
                return NotFound();
            }
            ViewData["CamadaSeisId"] = new SelectList(_context.CamadaSeis, "Id", "Id", camadaSete.CamadaSeisId);
            return View(camadaSete);
        }

        // POST: CamadaSete/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Nome,CamadaSeisId,Id")] CamadaSete camadaSete)
        {
            if (id != camadaSete.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(camadaSete);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CamadaSeteExists(camadaSete.Id))
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
            ViewData["CamadaSeisId"] = new SelectList(_context.CamadaSeis, "Id", "Id", camadaSete.CamadaSeisId);
            return View(camadaSete);
        }

        // GET: CamadaSete/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var camadaSete = await _context.CamadaSete
                .Include(c => c.CamadaSeis)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (camadaSete == null)
            {
                return NotFound();
            }

            return View(camadaSete);
        }

        // POST: CamadaSete/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var camadaSete = await _context.CamadaSete.FindAsync(id);
            _context.CamadaSete.Remove(camadaSete);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CamadaSeteExists(long id)
        {
            return _context.CamadaSete.Any(e => e.Id == id);
        }
    }
}
