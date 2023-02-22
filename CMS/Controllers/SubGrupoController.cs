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
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace CMS.Controllers
{
   [Authorize(Roles ="Admin")]
    public class SubGrupoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserManager<UserModel> UserManager { get; }

        public SubGrupoController(ApplicationDbContext context, UserManager<UserModel> userManager)
        {
            _context = context;
            UserManager = userManager;
        }

        // GET: SubGrupo
        [Route("SubGrupo/Index/{pagina?}")]
        public async Task<IActionResult> Index(int? pagina)
        {
            var usuario = await UserManager.GetUserAsync(this.User);
            int numeroPagina = (pagina ?? 1);
            const int TAMANHO_PAGINA = 5;
            ViewBag.pagina = numeroPagina;

            var subgrupos = await _context.SubGrupo
            .Include(s => s.Grupo)
            .ThenInclude(s => s.SubStory)
            .ThenInclude(s => s.Story)
            .Skip((numeroPagina - 1) * TAMANHO_PAGINA)
            .Take(TAMANHO_PAGINA)
            .ToListAsync();
            return View(subgrupos);
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
        public async Task<IActionResult> Create()
        {
            var usuario = await UserManager.GetUserAsync(this.User);
            ViewBag.IdentificacaoUser = usuario.Id;
            return View();
        }

        // POST: SubGrupo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( SubGrupo subGrupo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(subGrupo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            var usuario = await UserManager.GetUserAsync(this.User);
            ViewBag.IdentificacaoUser = usuario.Id;
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
            var usuario = await UserManager.GetUserAsync(this.User);
            ViewBag.IdentificacaoUser = usuario.Id;
            return View(subGrupo);
        }

        // POST: SubGrupo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit( SubGrupo subGrupo)
        {            

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
            var usuario = await UserManager.GetUserAsync(this.User);
            ViewBag.IdentificacaoUser = usuario.Id;
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
