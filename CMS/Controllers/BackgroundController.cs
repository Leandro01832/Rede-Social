using business.Back;
using business.business;
using CMS.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Controllers
{
    public class BackgroundController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BackgroundController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Authorize(Roles = "Background")]
      
        public async Task<IActionResult> ListaBackground(Int64? id)
        {
            List<BackgroundDiv> lista = new List<BackgroundDiv>();
            Pagina pagina = await _context.Pagina.FirstAsync(p => p.Id == id);
            var paginas = await _context.Pagina.Where(p => p.Id == id).ToListAsync();
            

            foreach (var item in paginas)
            {
                Pagina pag = await _context.Pagina.Include(p => p.Div)
                    .ThenInclude(p => p.Container)
                    .ThenInclude(p => p.Div)
                    .ThenInclude(p => p.Div)
                    .ThenInclude(p => p.Background)
                    .FirstAsync(p => p.Id == item.Id);

                foreach (var item2 in pag.Div)
                foreach (var item3 in item2.Container.Div)
                    lista.Add(item3.Div.Background);
            }
            return PartialView(lista);
        }

        

        [Authorize(Roles = "Background")]
        [Route("Background/Edit/{back}/{Id}")]
        public IActionResult Edit(string back, Int64? Id)
        {
            ViewBag.id = Id;   
           
             if (back == "BackgroundCor") 
            return PartialView("_BackgroundCor", new BackgroundCor());
            if (back == "BackgroundGradiente")
            return PartialView("_BackgroundGradiente", new BackgroundGradiente());
            if (back == "BackgroundImagem") 
            return PartialView("_BackgroundImagem", new BackgroundImagem());

             if (back == "BackgroundCorContainer") 
             return PartialView("_BackgroundCorContainer", new BackgroundCorContainer());
             if (back == "BackgroundGradienteContainer")
             return PartialView("_BackgroundGradienteContainer", new BackgroundGradienteContainer());
             if (back == "BackgroundImagemContainer") 
             return PartialView("_BackgroundImagemContainer", new BackgroundImagemContainer());

             if (back == "BackgroundCorElemento") 
             return PartialView("_BackgroundCorElemento", new BackgroundCorElemento());
             if (back == "BackgroundGradienteElemento")
             return PartialView("_BackgroundGradienteElemento", new BackgroundGradienteElemento());
             if (back == "BackgroundImagemElemento") 
             return PartialView("_BackgroundImagemElemento", new BackgroundImagemElemento());
            
            return PartialView();
        }

        #region Create-Edit-Background
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Background")]
        public async Task<string> _BackgroundCor([FromBody]BackgroundCor background)
        {
            if (background.backgroundTransparente)
                background.Cor = "transparent";

            var teste = await _context.BackgroundDiv.Include(b => b.Div)
                .FirstAsync(b => b.Div.Id == background.Id);
            background.Div = teste.Div;
            _context.Remove(teste); await _context.SaveChangesAsync();          
                _context.Add(background); await _context.SaveChangesAsync();

            
            return "";
            
        }      

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Background")]
        public async Task<string> _BackgroundGradiente([FromBody]BackgroundGradiente background)
        {
            var teste = await _context.BackgroundDiv.Include(b => b.Div)
                .FirstAsync(b => b.Div.Id == background.Id);
            background.Div = teste.Div;
            if (teste is BackgroundGradiente)
            {
                var t = (BackgroundGradiente)teste; t.Grau = background.Grau;
                _context.Update(t); await _context.SaveChangesAsync();
            }
            else
            {
                _context.Remove(teste); await _context.SaveChangesAsync();
                _context.Add(background); await _context.SaveChangesAsync();
            }
            return "";
        }

       [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Background")]
        public async Task<string> _BackgroundImagem([FromBody]BackgroundImagem background)
        {
            var teste = await _context.BackgroundDiv.Include(b => b.Div)
                .FirstAsync(b => b.Div.Id == background.Id);
            background.Div = teste.Div;
            _context.Remove(teste); await _context.SaveChangesAsync();
                _context.Add(background); await _context.SaveChangesAsync();
                return "";
            
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Background")]
        public async Task<string> _BackgroundImagemContainer([FromBody]BackgroundImagemContainer background)
        {
            var teste = await _context.BackgroundContainer.Include(b => b.Container)
               .FirstOrDefaultAsync(b => b.Container.Id == background.Id);
            background.Container = teste.Container;
            _context.Remove(teste); await _context.SaveChangesAsync();
                _context.Add(background); await _context.SaveChangesAsync();
                return "";            
        }

         [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Background")]
        public async Task<string> _BackgroundGradienteContainer([FromBody]BackgroundGradienteContainer background)
        {
            var teste = await _context.BackgroundContainer.Include(b => b.Container)
                .FirstAsync(b => b.Container.Id == background.Id);
            background.Container = teste.Container;
            if (teste is BackgroundGradienteContainer)
            {
                var t = (BackgroundGradienteContainer)teste; t.GrauContainer = background.GrauContainer;
                _context.Update(t); await _context.SaveChangesAsync();
            }
            else
            {
                _context.Remove(teste); await _context.SaveChangesAsync();
                _context.Add(background); await _context.SaveChangesAsync();
            }
            return "";
        }
        

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Background")]
        public async Task<string> _BackgroundCorContainer([FromBody]BackgroundCorContainer background)
        {
            if (background.backgroundTransparenteContainer)
                background.CorContainer = "transparent";

            var teste = await  _context.BackgroundContainer.Include(b => b.Container)
            .FirstAsync(b => b.Container.Id == background.Id);
            background.Container = teste.Container;
            _context.Remove(teste); await _context.SaveChangesAsync();
            _context.Add(background); await _context.SaveChangesAsync();
            return "";
            
        }

         [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Background")]
        public async Task<string> _BackgroundImagemElemento([FromBody]BackgroundImagemElemento background)
        {
            var teste = await _context.BackgroundElemento.Include(b => b.Elemento)
               .FirstOrDefaultAsync(b => b.Elemento.Id == background.Id);
            background.Elemento = teste.Elemento;
            _context.Remove(teste); await _context.SaveChangesAsync();
                _context.Add(background); await _context.SaveChangesAsync();
                return "";
            
        }

         [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Background")]
        public async Task<string> _BackgroundGradienteElemento([FromBody]BackgroundGradienteElemento background)
        {
            var teste = await _context.BackgroundElemento.Include(b => b.Elemento)
                .FirstAsync(b => b.Elemento.Id == background.Id);
            background.Elemento = teste.Elemento;
            if (teste is BackgroundGradienteElemento)
            {
                var t = (BackgroundGradienteElemento)teste; t.GrauElemento = background.GrauElemento;
                _context.Update(t); await _context.SaveChangesAsync();
            }
            else
            {
                _context.Remove(teste); await _context.SaveChangesAsync();
                _context.Add(background); await _context.SaveChangesAsync();
            }
            return "";
        }
        #endregion

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Background")]
        public async Task<string> _BackgroundCorElemento([FromBody]BackgroundCorElemento background)
        {
            if (background.backgroundTransparenteElemento)
                background.CorElemento = "transparent";

            var teste = await  _context.BackgroundElemento.Include(b => b.Elemento)
            .FirstAsync(b => b.Elemento.Id == background.Id);
            background.Elemento = teste.Elemento;
            _context.Remove(teste); await _context.SaveChangesAsync();
            _context.Add(background); await _context.SaveChangesAsync();
            return "";
            
        }
        
        public async Task<IActionResult> DeleteBackground(Int64? id)
        {
            if (id == null)
            {
                return NotFound();
            }

             var background = await _context.BackgroundDiv
                .FirstOrDefaultAsync(m => m.Id == id);
            if (background == null)
            {
                return NotFound();
            }

            return PartialView(background);
        }

        [HttpPost, ActionName("DeleteBackground")]
        [ValidateAntiForgeryToken]
        public async Task<string> DeleteBackgroundConfirmed(Int64 id)
        {
            var background = await _context.BackgroundDiv
                .FirstOrDefaultAsync(m => m.Id == id);
            if (background == null)
            {
                return "";
            }
            _context.BackgroundDiv.Remove(background);
            await _context.SaveChangesAsync();
            return "";
        }

    }
}