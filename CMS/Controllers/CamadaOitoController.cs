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
    public class CamadaOitoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CamadaOitoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CamadaOito
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CamadaOito.Include(c => c.CamadaSete);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CamadaOito/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var camadaOito = await _context.CamadaOito
                .Include(c => c.CamadaSete)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (camadaOito == null)
            {
                return NotFound();
            }

            return View(camadaOito);
        }

        // GET: CamadaOito/Create
        public IActionResult Create()
        {
            ViewData["CamadaSeteId"] = new SelectList(_context.CamadaSete, "Id", "Id");
            return View();
        }

        // POST: CamadaOito/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nome,CamadaSeteId,Id")] CamadaOito camadaOito)
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
                _context.Add(camadaOito);
                 _context.SaveChanges();
                _context.Add(new Filtro{CamadaOito = camadaOito.Id, StoryId = story});
                 _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CamadaSeteId"] = new SelectList(_context.CamadaSete, "Id", "Id", camadaOito.CamadaSeteId);
            return View(camadaOito);
        }

        // GET: CamadaOito/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var camadaOito = await _context.CamadaOito.FindAsync(id);
            if (camadaOito == null)
            {
                return NotFound();
            }
            ViewData["CamadaSeteId"] = new SelectList(_context.CamadaSete, "Id", "Id", camadaOito.CamadaSeteId);
            return View(camadaOito);
        }

        // POST: CamadaOito/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Nome,CamadaSeteId,Id")] CamadaOito camadaOito)
        {
            if (id != camadaOito.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(camadaOito);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CamadaOitoExists(camadaOito.Id))
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
            ViewData["CamadaSeteId"] = new SelectList(_context.CamadaSete, "Id", "Id", camadaOito.CamadaSeteId);
            return View(camadaOito);
        }

        // GET: CamadaOito/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var camadaOito = await _context.CamadaOito
                .Include(c => c.CamadaSete)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (camadaOito == null)
            {
                return NotFound();
            }

            return View(camadaOito);
        }

        // POST: CamadaOito/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var camadaOito = await _context.CamadaOito.FindAsync(id);
            _context.CamadaOito.Remove(camadaOito);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CamadaOitoExists(long id)
        {
            return _context.CamadaOito.Any(e => e.Id == id);
        }
    }
}
