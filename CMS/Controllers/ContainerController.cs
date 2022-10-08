using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using CMS.Data;
using business.business;
using business.business.div;
using business.Join;
using CMS.Models;
using CMS.Models.Repository;

namespace CMS.Controllers
{
    public class ContainerController : Controller
    {
        private readonly ApplicationDbContext _context;
         public UserManager<UserModel> UserManager { get; }
         public IRepositoryPagina RepositoryPagina { get; }

        public ContainerController(ApplicationDbContext context,
        UserManager<UserModel> userManager, IRepositoryPagina repositoryPagina)
        {
            _context = context;
            UserManager = userManager;
            RepositoryPagina = repositoryPagina;
        }

        // GET: Container
        public async Task<IActionResult> Index()
        {
            List<Container> lista = new List<Container>();
            var user = await UserManager.GetUserAsync(this.User);

            var paginas = await RepositoryPagina.includes()
            .Where(p => p.UserId == user.Id).ToListAsync();     

            Pagina pagina = new Pagina(1);
            pagina.Div = new List<PaginaContainer>();
            pagina.UserId = user.Id;
            pagina.FlexDirection = "column";
            pagina.AlignItems = "stretch";
            pagina.MostrarDados = 1;


            foreach (var page in paginas)
            foreach (var item in page.Div)
            lista.Add(item.Container);

            foreach (var item in lista)
           pagina.Div.Add
           (
                new PaginaContainer
                {
                    Pagina = pagina,
                    Container = item
                }
           );

           string html = await RepositoryPagina.renderizarPagina(pagina);
            ViewBag.Html = html;

            return PartialView(pagina);
        }

        // GET: Container/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var container = await _context.Container
                .FirstOrDefaultAsync(m => m.Id == id);
            if (container == null)
            {
                return NotFound();
            }

            return View(container);
        }

        // GET: Container/Create
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<string> Create([FromBody] Container container)
        {
            if (ModelState.IsValid)
            {
                _context.Add(container);
                await _context.SaveChangesAsync();
                return container.Id.ToString();
            }
            return "";
        }

        // GET: Container/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var container = await _context.Container.FindAsync(id);
            if (container == null)
            {
                return NotFound();
            }
            return View(container);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<string> Editar([FromBody] Container container)
        {         
            if (ModelState.IsValid)
            {
                try
                {
                    container.Background = null;
                    _context.Update(container);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContainerExists(container.Id))
                    {
                        return "Este container não existe.";
                    }
                    else
                    {
                        throw;
                    }
                }
                return "";
            }
            return "Modelo invalidado!!!";
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<string> Adicionar(long? id, long? div)
        {
            var container = await _context.Container.Include(p => p.Div).FirstAsync(p => p.Id == id);
            var bl = await _context.DivComum.FirstOrDefaultAsync(p => p.Id == div);            

           try
            {
                if(bl == null)
                container.IncluiDiv(new DivComum());
                else
                    container.IncluiDiv(bl);
                _context.SaveChanges();
            }
            catch (System.Exception)
            {
                return "Error3";
            }

            return "";
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<string> Remover(long? id, long? pagina)
        {            
           try
            {
                _context.Remove(await _context.PaginaContainer
                .FirstAsync(p => p.PaginaId == pagina && p.ContainerId == id));
                _context.SaveChanges();
            }
            catch (System.Exception)
            {
                return "Error3";
            }

            return "";
        }

        // GET: Container/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var container = await _context.Container
                .FirstOrDefaultAsync(m => m.Id == id);
            if (container == null)
            {
                return NotFound();
            }

            return View(container);
        }

        // POST: Container/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var container = await _context.Container.FindAsync(id);
            _context.Container.Remove(container);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContainerExists(long id)
        {
            return _context.Container.Any(e => e.Id == id);
        }
    }
}
