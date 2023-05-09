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
using business.business;

namespace Controllers
{
    [Authorize(Roles ="Admin")]
    public class CamadaNoveController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CamadaNoveController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CamadaNove
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CamadaNove.Include(c => c.CamadaOito);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CamadaNove/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var camadaNove = await _context.CamadaNove
                .Include(c => c.CamadaOito)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (camadaNove == null)
            {
                return NotFound();
            }

            return View(camadaNove);
        }

        // GET: CamadaNove/Create
        public IActionResult Create()
        {
            ViewData["CamadaOitoId"] = new SelectList(_context.CamadaOito, "Id", "Id");
            return View();
        }

        // POST: CamadaNove/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nome,CamadaOitoId,Id")] CamadaNove camadaNove)
        {
            if (ModelState.IsValid)
            {
                long story = 0;
                var form = await Request.ReadFormAsync();
                 foreach(var item in form)
                {
                    if(item.Key.ToString() == "StoryId")
                    {
                        story = long.Parse(item.Value);
                        break;
                    }
                }
                _context.Add(camadaNove);
                 _context.SaveChanges();
                _context.Add(new Filtro{CamadaOito = camadaNove.Id, StoryId = story});
                 _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CamadaOitoId"] = new SelectList(_context.CamadaOito, "Id", "Id", camadaNove.CamadaOitoId);
            return View(camadaNove);
        }

        // GET: CamadaNove/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var camadaNove = await _context.CamadaNove.FindAsync(id);
            if (camadaNove == null)
            {
                return NotFound();
            }
            ViewData["CamadaOitoId"] = new SelectList(_context.CamadaOito, "Id", "Id", camadaNove.CamadaOitoId);
            return View(camadaNove);
        }

        // POST: CamadaNove/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Nome,CamadaOitoId,Id")] CamadaNove camadaNove)
        {
            if (id != camadaNove.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(camadaNove);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CamadaNoveExists(camadaNove.Id))
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
            ViewData["CamadaOitoId"] = new SelectList(_context.CamadaOito, "Id", "Id", camadaNove.CamadaOitoId);
            return View(camadaNove);
        }

        // GET: CamadaNove/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var camadaNove = await _context.CamadaNove
                .Include(c => c.CamadaOito)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (camadaNove == null)
            {
                return NotFound();
            }

            return View(camadaNove);
        }

        // POST: CamadaNove/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var camadaNove = await _context.CamadaNove.FindAsync(id);
            _context.CamadaNove.Remove(camadaNove);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CamadaNoveExists(long id)
        {
            return _context.CamadaNove.Any(e => e.Id == id);
        }
    }
}
