using business.Back;
using business.business;
using CMS.Data;
using CMS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Controllers
{
    public class FerramentaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserManager<UserModel> UserManager { get; }

        public FerramentaController(ApplicationDbContext context, UserManager<UserModel> userManager)
        {
            _context = context;
            UserManager = userManager;
        }

        [Authorize(Roles = "Background")]
        public async Task<IActionResult> ListaCores(Int64? id)
        {
            List<Cor> lista = new List<Cor>();

            var pagina = await _context.Pagina
                .Include(p => p.Div)
                .ThenInclude(p => p.Container)
                .ThenInclude(p => p.Div)
                .ThenInclude(p => p.Div)
                .FirstAsync(p => p.Id == id);

                foreach(var item in pagina.Div)
                {
                    if(item.Container.Background is BackgroundGradienteContainer)
                        {
                            var backcolor = await _context.BackgroundGradienteContainer
                            .Include(b => b.Cores)
                            .FirstAsync(b => b.Id == item.Container.Id);
                            lista.AddRange(backcolor.Cores);
                        }
                    foreach(var item2 in item.Container.Div)
                    {
                        if(item2.Div.Background is BackgroundGradiente)
                        {
                            var backcolor = await _context.BackgroundGradiente.Include(b => b.Cores)
                            .FirstAsync(b => b.Id == item2.Div.Background.Id);
                            lista.AddRange(backcolor.Cores);
                        }

                        foreach(var item3 in item2.Div.Elemento)
                        {
                            if(item3.Elemento.Background is BackgroundGradienteElemento)
                            {
                                var backcolor = await _context.BackgroundGradienteElemento.Include(b => b.Cores)
                                .FirstAsync(b => b.Id == item3.Elemento.Background.Id);
                                lista.AddRange(backcolor.Cores);
                            }
                        } 
                    }                
                }
            

            return PartialView(lista);
        }        

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreatePasta()
        {
            var usuario = await UserManager.GetUserAsync(this.User);
            PastaImagem pasta = new PastaImagem();
            pasta.UserId = usuario.Id;
            return PartialView(pasta);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles ="Admin")]
        public async Task<string> CreatePasta([FromBody]PastaImagem pasta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pasta);
                await _context.SaveChangesAsync();
                return $"Chave da pasta: {pasta.Id}";
            }

            return "";
        }

        #region create
	        [Authorize(Roles = "Background")]
	        public async Task<IActionResult> CreateCor(Int64? id)
	        {
	            List<BackgroundDiv> lista = new List<BackgroundDiv>();
	
	            var pagina = await _context.Pagina
	                .Include(p => p.Div)
	                .ThenInclude(p => p.Container)
	                .ThenInclude(p => p.Div)
	                .ThenInclude(p => p.Div)
	                .ThenInclude(p => p.Background)
	                .ThenInclude(p => p.Cores)
	                .FirstAsync(p => p.Id == id);
	
	            foreach (var item in pagina.Div)
	            foreach (var item2 in item.Container.Div)
	            {
	                if (item2.Div.Background is BackgroundGradiente)
	                {
	                    lista.Add(item2.Div.Background);
	                }
	            }
	            ViewBag.BackgroundDivId = new SelectList(lista, "Id", "Id");
	            return PartialView();
	        }        
	
	        [Authorize(Roles = "Background")]
	        public async Task<IActionResult> CreateCorContainer(Int64? id)
	        {
	            List<BackgroundContainer> lista = new List<BackgroundContainer>();
	
	            var pagina = await _context.Pagina
	                .Include(p => p.Div)
	                .ThenInclude(p => p.Container)
	                .ThenInclude(p => p.Background)
	                .ThenInclude(p => p.Cores)
	                .FirstAsync(p => p.Id == id);
	
	            foreach (var item in pagina.Div)
	            {
	                if (item.Container.Background is BackgroundGradienteContainer)
	                {
	                    lista.Add(item.Container.Background);
	                }
	            }
	            ViewBag.BackgroundContainerId = new SelectList(lista, "Id", "Id");
	            return PartialView();
	        }
	       
	        [Authorize(Roles = "Background")]
	        public async Task<IActionResult> CreateCorElemento(Int64? id)
	        {
	            List<BackgroundElemento> lista = new List<BackgroundElemento>();
	
	            var pagina = await _context.Pagina
	                .Include(p => p.Div)
	                .ThenInclude(p => p.Container)
	                .ThenInclude(p => p.Div)
	                .ThenInclude(p => p.Div)
	                .ThenInclude(p => p.Elemento)
	                .ThenInclude(p => p.Elemento)
	                .ThenInclude(p => p.Background)
	                .ThenInclude(p => p.Cores)
	                .FirstAsync(p => p.Id == id);
	
	            foreach (var item in pagina.Div)
	            foreach (var item2 in item.Container.Div)
	            foreach (var item3 in item2.Div.Elemento)
	            {
	                if (item3.Elemento.Background is BackgroundGradienteElemento)
	                {
	                    lista.Add(item3.Elemento.Background);
	                }
	            }
	            ViewBag.BackgroundElementoId = new SelectList(lista, "Id", "Id");
	            return PartialView();
	        }
	
	        [HttpPost]
	        [ValidateAntiForgeryToken]
	        [Authorize(Roles = "Background")]
	        public async Task<string> CreateCor([FromBody]Cor cor)
	        {
	            if (ModelState.IsValid)
	            {
	                _context.Add(cor);
	                await _context.SaveChangesAsync();
	                return $"Chave da cor: {cor.Id}";
	            }
	            
	            return "";
	        }
       #endregion

      #region edit
	  [Authorize(Roles = "Background")]
	        public async Task<IActionResult> EditCor(Int64? id)
	        {
	            var cor = await _context.Cor.FindAsync(id);
	            if (cor == null)
	            {
	                return NotFound();
	            }
	            List<BackgroundDiv> lista = new List<BackgroundDiv>();
	            var black = _context.BackgroundDiv
	            .Include(b => b.Div).First(b => b.Id == cor.BackgroundDivId);
	            var pagina = await _context.Pagina
	                .Include(p => p.Div)
	                .ThenInclude(p => p.Container)
	                .ThenInclude(p => p.Div)
	                .ThenInclude(p => p.Div)
	                .ThenInclude(p => p.Background)
	                .FirstAsync(p => p.Id == black.Div.Pagina_);
	
	            foreach (var item in pagina.Div)
	            foreach (var item2 in item.Container.Div)
	            {
	                if (item2.Div.Background is BackgroundGradiente)
	                {
	                    lista.Add(item2.Div.Background);
	                }
	            }
	
	            ViewBag.BackgroundDivId = new SelectList(lista, "Id", "Id", cor.BackgroundDivId);
	            return PartialView(cor);
	        }
	
	        [Authorize(Roles = "Background")]
	        public async Task<IActionResult> EditCorContainer(Int64? id)
	        {
	            var cor = await _context.Cor.FindAsync(id);
	            if (cor == null)
	            {
	                return NotFound();
	            }
	            List<BackgroundContainer> lista = new List<BackgroundContainer>();
	            var black = _context.BackgroundDiv
	            .Include(b => b.Div).First(b => b.Id == cor.BackgroundDivId);
	            var pagina = await _context.Pagina
	                .Include(p => p.Div)
	                .ThenInclude(p => p.Container)                
	                .ThenInclude(p => p.Background)
	                .FirstAsync(p => p.Id == black.Div.Pagina_);
	
	            foreach (var item in pagina.Div)
	            {
	                if (item.Container.Background is BackgroundGradienteContainer)
	                {
	                    lista.Add(item.Container.Background);
	                }
	            }
	            ViewBag.BackgroundContainerId = new SelectList(lista, "Id", "Id", cor.BackgroundContainerId);
	            return PartialView(cor);
	        }
	
	        [Authorize(Roles = "Background")]
	        public async Task<IActionResult> EditCorElemento(Int64? id)
	        {
	            var cor = await _context.Cor.FindAsync(id);
	            if (cor == null)
	            {
	                return NotFound();
	            }
	            List<BackgroundElemento> lista = new List<BackgroundElemento>();
	            var black = _context.BackgroundDiv
	            .Include(b => b.Div).First(b => b.Id == cor.BackgroundDivId);
	            var pagina = await _context.Pagina
	                .Include(p => p.Div)
	                .ThenInclude(p => p.Container) 
	                .ThenInclude(p => p.Div)
	                .ThenInclude(p => p.Div)               
	                .ThenInclude(p => p.Elemento)               
	                .ThenInclude(p => p.Elemento)               
	                .ThenInclude(p => p.Background)
	                .FirstAsync(p => p.Id == black.Div.Pagina_);
	
	            foreach (var item in pagina.Div)
	            foreach (var item2 in item.Container.Div)
	            foreach (var item3 in item2.Div.Elemento)
	            {
	                if (item3.Elemento.Background is BackgroundGradienteElemento)
	                {
	                    lista.Add(item3.Elemento.Background);
	                }
	            }
	            ViewBag.BackgroundElementoId = new SelectList(lista, "Id", "Id", cor.BackgroundElementoId);
	            return PartialView(cor);
	        }
	
	        [HttpPost]
	        [ValidateAntiForgeryToken]
	        [Authorize(Roles = "Background")]
	        public async Task<string> EditCor([FromBody]Cor cor)
	        {
	            if (ModelState.IsValid)
	            {
	                try
	                {
	                    _context.Update(cor);
	                    await _context.SaveChangesAsync();
	                }
	                catch (DbUpdateConcurrencyException)
	                {
	                    return "";
	                }
	                return "";
	            }
	            return "";
	        }
      #endregion
                
        public async Task<IActionResult> DeleteCor(Int64? id)
        {
            var cor = await _context.Cor
                .Include(b => b.BackgroundDiv)
                .Include(b => b.BackgroundContainer)
                .Include(b => b.BackgroundElemento)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cor == null)
            {
                return NotFound();
            }

            return PartialView(cor);
        }

        [HttpPost, ActionName("DeleteCor")]
        [ValidateAntiForgeryToken]
        public async Task<string> DeleteCorConfirmed(Int64 id)
        {
            var cor = await _context.Cor.FindAsync(id);
            _context.Cor.Remove(cor);
            await _context.SaveChangesAsync();
            return "";
        }

        private bool BackgroundExists(Int64 id)
        {
            return _context.BackgroundDiv.Any(e => e.Id == id);
        }
    }
}
