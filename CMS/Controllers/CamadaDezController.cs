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
    public class CamadaDezController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CamadaDezController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CamadaDez
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CamadaDez.Include(c => c.CamadaNove);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CamadaDez/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var camadaDez = await _context.CamadaDez
                .Include(c => c.CamadaNove)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (camadaDez == null)
            {
                return NotFound();
            }

            return View(camadaDez);
        }

        // GET: CamadaDez/Create
        public IActionResult Create()
        {
            ViewData["CamadaNoveId"] = new SelectList(_context.CamadaNove, "Id", "Id");
            return View();
        }

        // POST: CamadaDez/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nome,CamadaNoveId,Id")] CamadaDez camadaDez)
        {
            if (ModelState.IsValid)
            {
                _context.Add(camadaDez);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CamadaNoveId"] = new SelectList(_context.CamadaNove, "Id", "Id", camadaDez.CamadaNoveId);
            return View(camadaDez);
        }

        // GET: CamadaDez/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var camadaDez = await _context.CamadaDez.FindAsync(id);
            if (camadaDez == null)
            {
                return NotFound();
            }
            ViewData["CamadaNoveId"] = new SelectList(_context.CamadaNove, "Id", "Id", camadaDez.CamadaNoveId);
            return View(camadaDez);
        }

        // POST: CamadaDez/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Nome,CamadaNoveId,Id")] CamadaDez camadaDez)
        {
            if (id != camadaDez.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(camadaDez);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CamadaDezExists(camadaDez.Id))
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
            ViewData["CamadaNoveId"] = new SelectList(_context.CamadaNove, "Id", "Id", camadaDez.CamadaNoveId);
            return View(camadaDez);
        }

        // GET: CamadaDez/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var camadaDez = await _context.CamadaDez
                .Include(c => c.CamadaNove)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (camadaDez == null)
            {
                return NotFound();
            }

            return View(camadaDez);
        }

        // POST: CamadaDez/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var camadaDez = await _context.CamadaDez.FindAsync(id);
            _context.CamadaDez.Remove(camadaDez);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CamadaDezExists(long id)
        {
            return _context.CamadaDez.Any(e => e.Id == id);
        }
    }
}
