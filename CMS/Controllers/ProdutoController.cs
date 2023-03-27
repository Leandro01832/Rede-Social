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
using Microsoft.AspNetCore.Hosting;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace CMS.Controllers
{
    [Authorize(Roles ="Admin")]
    public class ProdutoController : Controller
    {
        private readonly ApplicationDbContext _context;
        public UserManager<UserModel> UserManager { get; }
         public IRepositoryPagina epositoryPagina { get; }
         public IHostingEnvironment HostingEnvironment { get; }

        public ProdutoController(ApplicationDbContext context, UserManager<UserModel> userManager,
        IRepositoryPagina repositoryPagina, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            UserManager = userManager;
             epositoryPagina = repositoryPagina;
             HostingEnvironment = hostingEnvironment;
        }

        // GET: Produto
        [Route("Produto/{pagina?}")]
        public async Task<IActionResult> Index(int? pagina)
        {
            int numeroPagina = (pagina ?? 1);
            const int TAMANHO_PAGINA = 5;

            ViewBag.pagina = numeroPagina;
            var applicationDbContext = await RetornarLista(numeroPagina, TAMANHO_PAGINA, "");
            
            return View(applicationDbContext);
        }

        [AllowAnonymous]
       [Route("paginacao/{pagina?}/{ordenar}/{automatico}/{tempo}/{tamanho}/{compartilhante}")]
        public async Task<IActionResult> paginacao(int? pagina, string ordenar,
         int automatico , int tempo, int tamanho, string compartilhante)
        {
            int numeroPagina = (pagina ?? 1);

            ViewBag.pagina = numeroPagina;
            ViewBag.ordenar = ordenar;
            ViewBag.automatico = automatico;
            ViewBag.tempo = tempo;
            ViewBag.tamanho = tamanho;
            ViewBag.compartilhante = compartilhante;
            List<Produto> applicationDbContext = await RetornarLista(numeroPagina, tamanho, ordenar);            
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
            .Where(str => str.Nome != "Padrao" && !str.Comentario).ToListAsync();

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
            if (ModelState.IsValid  && Request.Form.Files.Count > 0)
            {
                var user = await UserManager.GetUserAsync(this.User);
                Pagina pagina = new Pagina();
                pagina.Produto = produto;
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

                

                 foreach (IFormFile source in Request.Form.Files)
            {                
                ImagemProduto img = new ImagemProduto
                {
                    ArquivoImagem = "/ImagensProduto/" + produto.Id + "-Produto.jpg",
                    WidthImagem = 160,
                    ProdutoId = produto.Id
                };

                await _context.ImagemProduto.AddAsync(img);
                await _context.SaveChangesAsync();               

                byte[] buffer = new byte[16 * 1024];

                using (FileStream output = System.IO.File.Create(this.HostingEnvironment.WebRootPath
                 + "\\ImagensProduto\\" + produto.Id + "-Produto.jpg"))
                {
                    using (Stream input = source.OpenReadStream())
                    {
                        long totalReadBytes = 0;
                        int readBytes;

                        while ((readBytes = input.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            await output.WriteAsync(buffer, 0, readBytes);
                            totalReadBytes += readBytes;
                            // await Task.Delay(10); // It is only to make the process slower
                        }
                    }
                }
            }
                
                return RedirectToAction(nameof(Index));
            }
                ModelState.AddModelError("", "Informe a imagem do produto!!!");
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

        private async Task<List<Produto>> RetornarLista(int numeroPagina, int tamanho, string ordenar)
        {
            List<Produto> applicationDbContext = null;
            if(ordenar == "nome")
             applicationDbContext = await _context.Produto               
                .Include(l => l.Imagem)                
                .Include(l => l.Itens)  
                .Include(l => l.Pagina)
                .ThenInclude(l => l.Story)
                .ThenInclude(l => l.Pagina)
                .OrderBy(p => p.Nome)
                .Skip((numeroPagina - 1) * tamanho)
                .Take(tamanho).ToListAsync();
           else
            if(ordenar == "preco")
             applicationDbContext = await _context.Produto               
                .Include(l => l.Imagem)                
                .Include(l => l.Itens)  
                .Include(l => l.Pagina)
                .ThenInclude(l => l.Story)
                .ThenInclude(l => l.Pagina)
                .OrderBy(p => p.Preco)
                .Skip((numeroPagina - 1) * tamanho)
                .Take(tamanho).ToListAsync();
            else
            if(ordenar == "capitulo")
             applicationDbContext = await _context.Produto               
                .Include(l => l.Imagem)                
                .Include(l => l.Itens)
                .Include(l => l.Pagina)
                .ThenInclude(l => l.Story)
                .ThenInclude(l => l.Pagina)
                .OrderBy(p => p.Pagina.Story.PaginaPadraoLink)
                .Skip((numeroPagina - 1) * tamanho)
                .Take(tamanho).ToListAsync();
            else
             applicationDbContext = await _context.Produto               
                .Include(l => l.Imagem)                
                .Include(l => l.Itens)  
                .Include(l => l.Pagina)
                .ThenInclude(l => l.Story)
                .ThenInclude(l => l.Pagina)
                .OrderBy(p => p.Nome)
                .Skip((numeroPagina - 1) * tamanho)
                .Take(tamanho).ToListAsync();

               

                return applicationDbContext;
        }
    }
}
