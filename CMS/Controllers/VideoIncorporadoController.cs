using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CMS.Data;
using business.business;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace CMS.Controllers
{
    public class VideoIncorporadoController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment HostingEnvironment;

        public VideoIncorporadoController(ApplicationDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            this.HostingEnvironment = hostingEnvironment;
        }

        // GET: VideoIncorporado
        public async Task<IActionResult> Index()
        {
            return View(await _context.VideoIncorporado.ToListAsync());
        }

        // GET: VideoIncorporado/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var videoIncorporado = await _context.VideoIncorporado
                .FirstOrDefaultAsync(m => m.Id == id);
            if (videoIncorporado == null)
            {
                return NotFound();
            }

            return View(videoIncorporado);
        }

        // GET: VideoIncorporado/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VideoIncorporado/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IFormFile file, int Tamanho)
        {
            var video = new VideoIncorporado()
            {
                ArquivoVideoIncorporado = "",
                Tamanho = Tamanho
            };
                _context.Add(video);
                await _context.SaveChangesAsync();

               var filename = "videos" + video.Id;

            video.ArquivoVideoIncorporado = "/VideosIncorporar/" + filename;
            _context.Entry(video).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            
            if ( Request.Form.Files.Count > 0)
            {
                using (FileStream output = 
                new FileStream(this.HostingEnvironment.WebRootPath + "\\VideosIncorporar\\" +
                    filename + ".txt", FileMode.Create))
                {
                    await file.CopyToAsync(output);
                }
            }
             return RedirectToAction(nameof(Index));
        }

        // GET: VideoIncorporado/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var videoIncorporado = await _context.VideoIncorporado.FindAsync(id);
            if (videoIncorporado == null)
            {
                return NotFound();
            }
            return View(videoIncorporado);
        }

        // POST: VideoIncorporado/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Tamanho,ArquivoVideoIncorporado,Id")] VideoIncorporado videoIncorporado)
        {
            if (id != videoIncorporado.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(videoIncorporado);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VideoIncorporadoExists(videoIncorporado.Id))
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
            return View(videoIncorporado);
        }

        // GET: VideoIncorporado/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var videoIncorporado = await _context.VideoIncorporado
                .FirstOrDefaultAsync(m => m.Id == id);
            if (videoIncorporado == null)
            {
                return NotFound();
            }

            return View(videoIncorporado);
        }

        // POST: VideoIncorporado/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var videoIncorporado = await _context.VideoIncorporado.FindAsync(id);
            _context.VideoIncorporado.Remove(videoIncorporado);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VideoIncorporadoExists(long id)
        {
            return _context.VideoIncorporado.Any(e => e.Id == id);
        }

        

        private string GetPathAndFilenameArquivoVideo(string filename)
        {
            string path = this.HostingEnvironment.WebRootPath + "\\VideosIncorporar\\";

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            return path + filename + ".txt";
        }
    }
}
