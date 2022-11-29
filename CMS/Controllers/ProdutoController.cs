using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CMS.Data;
using business.business;
using business.Join;
using CMS.Models;
using CMS.Models.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace CMS.Controllers
{
    [Authorize]
    public class ProdutoController : Controller
    {
        private readonly ApplicationDbContext _context;
        public UserManager<UserModel> UserManager { get; }
         public IRepositoryPagina epositoryPagina { get; }

        public ProdutoController(ApplicationDbContext context, UserManager<UserModel> userManager,
        IRepositoryPagina repositoryPagina)
        {
            _context = context;
            UserManager = userManager;
             epositoryPagina = repositoryPagina;
        }

        // GET: Produto
        [Route("Produto/{pagina?}")]
        public async Task<IActionResult> Index(int? pagina)
        {
            int numeroPagina = (pagina ?? 1);
            const int TAMANHO_PAGINA = 5;

            ViewBag.pagina = numeroPagina;
            var applicationDbContext = await _context.Produto
                .Include(l => l.Pagina)
                .ThenInclude(l => l.Pagina)
                .ThenInclude(l => l.Story)
                .Include(l => l.Itens)
                .Where(l => l.Pagina.FirstOrDefault(p => p.Pagina.ListaGrupo == null) != null)
                .Skip((numeroPagina - 1) * TAMANHO_PAGINA)
                .Take(TAMANHO_PAGINA).ToListAsync();
            
            return View(applicationDbContext);
        }

        [Route("paginacao/{pagina?}")]
        public async Task<IActionResult> paginacao(int? pagina)
        {
            int numeroPagina = (pagina ?? 1);
            const int TAMANHO_PAGINA = 15;

            ViewBag.pagina = numeroPagina;
            var applicationDbContext = await _context.Produto
                .Include(l => l.Pagina)
                .ThenInclude(l => l.Pagina)
                .ThenInclude(l => l.Story)
                .ThenInclude(l => l.Pagina)
                .Include(l => l.Itens)
                .Where(l => l.Pagina.FirstOrDefault(p => p.Pagina.ListaGrupo == null) != null)
                .Skip((numeroPagina - 1) * TAMANHO_PAGINA)
                .Take(TAMANHO_PAGINA).OrderBy(p => p.Nome).ToListAsync();
            
            return View(applicationDbContext);
        }

        // GET: Produto/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produto = await _context.Produto
                .FirstOrDefaultAsync(m => m.Id == id);
            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

        // GET: Produto/Create
        public async Task<ActionResult> Create()
        {
            var user = await UserManager.GetUserAsync(this.User);
            var stories = await _context.Story
            .Where(str => str.UserId == user.Id && str.Nome != "Padrao").ToListAsync();

            if(stories.Count == 0)
            {
                ViewBag.Error = "Crie seu story primeiro!!!";
                RedirectToAction("Create", "Story");
            }

             ViewBag.StoryId = new SelectList(stories, "Id", "CapituloComNome");
            return View();
        }

        // POST: Produto/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Produto produto, long StoryId,
         long SubStoryId, long GrupoId, long SubGrupoId, int SubSubGrupoId)
        {
            if (ModelState.IsValid)
            {
                var user = await UserManager.GetUserAsync(this.User);
                Pagina pagina = new Pagina();
                pagina.Div = null;
                pagina.Produto = null;
                pagina.UserId = user.Id;
                pagina.Tempo = 15000;
                pagina.Titulo = produto.Nome;
                pagina.StoryId = StoryId;
                pagina.SubStoryId = SubStoryId;
                pagina.GrupoId = GrupoId;
                pagina.SubGrupoId = SubGrupoId;
                pagina.SubSubGrupoId = SubSubGrupoId;
                _context.Pagina.Add(pagina);
                _context.SaveChanges();              

                var p = new Pagina(1);

                pagina.Div = new List<PaginaContainer>();                
                foreach (var item in p.Div)            
                pagina.IncluiDiv(item.Container);             
                await  _context.SaveChangesAsync(); 

                pagina.Produto = new List<PaginaProduto>();
                pagina.IncluiProduto(produto);
                await  _context.SaveChangesAsync(); 

                for (int indice = 0; indice <= RepositoryPagina.paginas.Length; indice++)
                    {
                          if(RepositoryPagina.paginas[indice] != null && RepositoryPagina.paginas[indice].Count >= 1000000000) continue;

                        if(RepositoryPagina.paginas[indice] == null) RepositoryPagina.paginas[indice] = new List<Pagina>();
                        if(RepositoryPagina.paginas[indice].Count < 1000000000)
                        {
                            RepositoryPagina.paginas[indice].Add(pagina);
                            break;
                        }
                    }
                return RedirectToAction(nameof(Index));
            }
            return View(produto);
        }

        // GET: Produto/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produto = await _context.Produto.FindAsync(id);
            if (produto == null)
            {
                return NotFound();
            }
            return View(produto);
        }

        // POST: Produto/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, Produto produto)
        {
            if (id != produto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(produto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProdutoExists(produto.Id))
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
            return View(produto);
        }

        // GET: Produto/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produto = await _context.Produto
                .FirstOrDefaultAsync(m => m.Id == id);
            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

        // POST: Produto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var produto = await _context.Produto.FindAsync(id);
            _context.Produto.Remove(produto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProdutoExists(long id)
        {
            return _context.Produto.Any(e => e.Id == id);
        }
    }
}
