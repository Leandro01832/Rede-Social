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
    [Authorize]
    public class SubSubGrupoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserManager<UserModel> UserManager { get; }

        public SubSubGrupoController(ApplicationDbContext context, UserManager<UserModel> userManager)
        {
            _context = context;
            UserManager = userManager;
        }

        // GET: SubSubGrupo
        [Route("SubSubGrupo/Index/{pagina?}")]
        public async Task<IActionResult> Index(int? pagina)
        {
            var usuario = await UserManager.GetUserAsync(this.User);
            int numeroPagina = (pagina ?? 1);
            const int TAMANHO_PAGINA = 5;
            ViewBag.pagina = numeroPagina;

            var subsubgrupos = await _context.SubSubGrupo
            .Include(s => s.SubGrupo)
            .ThenInclude(s => s.Grupo)
            .ThenInclude(s => s.SubStory)
            .ThenInclude(s => s.Story)
            .Skip((numeroPagina - 1) * TAMANHO_PAGINA)
            .Take(TAMANHO_PAGINA)
            .ToListAsync();
            return View(subsubgrupos);
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
        public async Task<IActionResult> Create()
        {
            var usuario = await UserManager.GetUserAsync(this.User);
            ViewBag.IdentificacaoUser = usuario.Id;
            return View();
        }

        // POST: SubSubGrupo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( SubSubGrupo subSubGrupo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(subSubGrupo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
             var usuario = await UserManager.GetUserAsync(this.User);
            ViewBag.IdentificacaoUser = usuario.Id;
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
             var usuario = await UserManager.GetUserAsync(this.User);
            ViewBag.IdentificacaoUser = usuario.Id;
            return View(subSubGrupo);
        }

        // POST: SubSubGrupo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit( SubSubGrupo subSubGrupo)
        {

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
             var usuario = await UserManager.GetUserAsync(this.User);
            ViewBag.IdentificacaoUser = usuario.Id;
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
