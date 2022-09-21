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
            List<Background> lista = new List<Background>();
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
            Background background = null;       
             if (back == "BackgroundCor") background = new BackgroundCor();
            if (back == "BackgroundGradiente") background = new BackgroundGradiente();
            if (back == "BackgroundImagem") background = new BackgroundImagem();

             if (back == "BackgroundCorContainer") background = new BackgroundCorContainer();
            if (back == "BackgroundGradienteContainer") background = new BackgroundGradienteContainer();
            if (back == "BackgroundImagemContainer") background = new BackgroundImagemContainer();


            ViewBag.id = Id;
            return PartialView(background);
        }

        #region Create-Edit-Background
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Background")]
        public async Task<string> _BackgroundCor([FromBody]BackgroundCor background)
        {
            if (background.backgroundTransparente)
                background.Cor = "transparent";

            var teste = await _context.Background.FirstAsync(b => b.Id == background.Id);

             _context.Remove(teste); await _context.SaveChangesAsync();
             _context.Add(background); await _context.SaveChangesAsync();
                return "";
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Background")]
        public async Task<string> _BackgroundCorContainer([FromBody]BackgroundCorContainer background)
        {
            if (background.backgroundTransparenteContainer)
                background.CorContainer = "transparent";

            var teste = await _context.Background.FirstAsync(b => b.Id == background.Id);

             _context.Remove(teste); await _context.SaveChangesAsync();
             _context.Add(background); await _context.SaveChangesAsync();
                return "";
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Background")]
        public async Task<string> _BackgroundGradiente([FromBody]BackgroundGradiente background)
        {
            var teste = await _context.Background.FirstAsync(b => b.Id == background.Id);

            if (!(teste is BackgroundGradiente))
                {
                    _context.Remove(teste); await _context.SaveChangesAsync();
                    _context.Add(background); await _context.SaveChangesAsync();
                }
                else
                {
                    var back = (BackgroundGradiente)teste;
                    back.Grau = background.Grau;
                    _context.Update(back); await _context.SaveChangesAsync();
                }
                return "";
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Background")]
        public async Task<string> _BackgroundGradienteContainer([FromBody]BackgroundGradienteContainer background)
        {
            var teste = await _context.Background.FirstAsync(b => b.Id == background.Id);

             if (!(teste is BackgroundGradienteContainer))
                {
                    _context.Remove(teste); await _context.SaveChangesAsync();
                    _context.Add(background); await _context.SaveChangesAsync();
                }
                else
                {
                    var back = (BackgroundGradienteContainer)teste;
                    back.GrauContainer = background.GrauContainer;
                    _context.Update(back); await _context.SaveChangesAsync();
                }
                return "";
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Background")]
        public async Task<string> _BackgroundImagem([FromBody]BackgroundImagem background)
        {
            var teste = await _context.Background.FirstAsync(b => b.Id == background.Id);
                _context.Remove(teste); await _context.SaveChangesAsync();
                _context.Add(background); await _context.SaveChangesAsync();
                return "";
            
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Background")]
        public async Task<string> _BackgroundImagemContainer([FromBody]BackgroundImagemContainer background)
        {
            var teste = await _context.Background.FirstAsync(b => b.Id == background.Id);
                _context.Remove(teste); await _context.SaveChangesAsync();
                _context.Add(background); await _context.SaveChangesAsync();
                return "";
            
        }
        #endregion

        
        public async Task<IActionResult> DeleteBackground(Int64? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var background = await _context.Background
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
            var background = await _context.Background.FindAsync(id);
            _context.Background.Remove(background);
            await _context.SaveChangesAsync();
            return "";
        }

    }
}