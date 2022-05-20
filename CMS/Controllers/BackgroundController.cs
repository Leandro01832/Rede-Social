﻿using business.Back;
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
                    .ThenInclude(p => p.Div).ThenInclude(p => p.Background).FirstAsync(p => p.Id == item.Id);

                foreach (var item2 in pag.Div)
                    lista.Add(item2.Div.Background);
            }
            return PartialView(lista);
        }

        [Authorize(Roles = "Background")]
        [Route("Background/Create/{back}/{Id}")]
        public IActionResult Create(string back, Int64? Id)
        {
            Background background = null;

            if (back == "BackgroundCor") background = new BackgroundCor();
            if (back == "BackgroundGradiente") background = new BackgroundGradiente();
            if (back == "BackgroundImagem") background = new BackgroundImagem();

            ViewBag.id = Id;
            return PartialView(background);
        }

        [Authorize(Roles = "Background")]
        [Route("Background/Edit/{back}/{Id}")]
        public async Task<IActionResult> Edit(string back, Int64? Id)
        {
            Background background = null;

            if (back == "BackgroundCor") background = new BackgroundCor();
            if (back == "BackgroundGradiente") background = new BackgroundGradiente();
            if (back == "BackgroundImagem") background = new BackgroundImagem();
            if (back == "Padrao")
            {
                background = await _context.Background.FirstOrDefaultAsync(b => b.Id == Id);                
                ViewBag.condicao = true;
            }
            else ViewBag.condicao = false;

            ViewBag.back = back;
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

            var teste = await _context.Background.FirstOrDefaultAsync(b => b.Id == background.Id);

            if (teste == null)
            {
                _context.Add(background); await _context.SaveChangesAsync();
                return $"Chave do plano de fundo {background.Id}";
            }
            else
            {
                _context.Remove(teste); await _context.SaveChangesAsync();
                _context.Add(background); await _context.SaveChangesAsync();
                return "";
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Background")]
        public async Task<string> _BackgroundGradiente([FromBody]BackgroundGradiente background)
        {
            var teste = await _context.Background.FirstOrDefaultAsync(b => b.Id == background.Id);

            if (teste == null)
            {
                _context.Add(background); await _context.SaveChangesAsync();
                return $"Chave do plano de fundo {background.Id}";
            }
            else
            {
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
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Background")]
        public async Task<string> _BackgroundImagem([FromBody]BackgroundImagem background)
        {
            var teste = await _context.Background.FirstOrDefaultAsync(b => b.Id == background.Id);

            if (teste == null)
            {
                _context.Add(background); await _context.SaveChangesAsync();
                return $"Chave do plano de fundo {background.Id}";
            }
            else
            {
                _context.Remove(teste); await _context.SaveChangesAsync();
                _context.Add(background); await _context.SaveChangesAsync();
                return "";
            }
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