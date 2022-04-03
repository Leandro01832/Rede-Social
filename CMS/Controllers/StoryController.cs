using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CMS.Data;
using business.business;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using CMS.Models;

namespace CMS.Controllers
{
    [Authorize(Roles = "Admin")]
    public class StoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserManager<UserModel> UserManager { get; }

        public StoryController(ApplicationDbContext context, UserManager<UserModel> userManager)
        {
            _context = context;
            UserManager = userManager;
        }

        // GET: Story
        public async Task<IActionResult> Index()
        {
            var usuario = await UserManager.GetUserAsync(this.User);
            var stories = await _context.Story.Where(str => str.UserId == usuario.Id).ToListAsync();
            return View(stories);
        }

        // GET: Story/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var story = await _context.Story
                .FirstOrDefaultAsync(m => m.Id == id);
            if (story == null)
            {
                return NotFound();
            }

            return View(story);
        }

        // GET: Story/Create
        public async Task<IActionResult> Create()
        {
            var user = await UserManager.GetUserAsync(this.User);
            ViewBag.UserId = user.Id;
            return View();
        }

        // POST: Story/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nome,UserId,PaginaPadraoLink,Id")] Story story)
        {
            var user = await UserManager.GetUserAsync(this.User);
            ViewBag.UserId = user.Id;
            var str = await _context.Story.
            FirstOrDefaultAsync(st => st.Nome.ToLower() == story.Nome.ToLower() && st.UserId == user.Id);
            if (str != null)
            {
                ModelState.AddModelError("", "Este story ja existe!!!");
                return View(story);
            }

            if (story.Nome != "Padrao" && story.PaginaPadraoLink == 0)
            {
                ModelState.AddModelError("", "Informe a pagina padrão que será o link para acessar story!!!");
                return View(story);
            }

            if (ModelState.IsValid)
            {
                _context.Add(story);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(story);
        }

        // GET: Story/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var story = await _context.Story.FindAsync(id);
            if (story == null)
            {
                return NotFound();
            }
            var user = await UserManager.GetUserAsync(this.User);
            ViewBag.UserId = user.Id;
            return View(story);
        }

        // POST: Story/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Story story)
        {
            var user = await UserManager.GetUserAsync(this.User);
            ViewBag.UserId = user.Id;
            var str = await _context.Story.
            FirstOrDefaultAsync(st => st.Nome.ToLower() == story.Nome.ToLower() && st.UserId == user.Id);
            if (str != null)
            {
                ModelState.AddModelError("", "Este story ja existe!!!");
                return View(story);
            }

            if (story.Nome != "Padrao" && story.PaginaPadraoLink == 0)
            {
                ModelState.AddModelError("", "Informe a pagina padrão que será o link para acessar story!!!");
                return View(story);
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(story);
                    await _context.SaveChangesAsync();
                }
                catch (Exception)
                {

                    if (!StoryExists(story.Id))
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
            return View(story);
        }

        // GET: Story/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var story = await _context.Story
                .FirstOrDefaultAsync(m => m.Id == id);
            if (story == null)
            {
                return NotFound();
            }

            return View(story);
        }

        // POST: Story/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var story = await _context.Story.FindAsync(id);
            _context.Story.Remove(story);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StoryExists(int id)
        {
            return _context.Story.Any(e => e.Id == id);
        }
    }
}
