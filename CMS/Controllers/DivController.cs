using business.Back;
using business.business;
using business.div;
using business.Join;
using CMS.Data;
using CMS.Models;
using CMS.Models.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Controllers
{
    public class DivController : Controller
    {
        private readonly ApplicationDbContext _context;

        public IRepositoryElemento RepositoryElemento { get; }
        public IRepositoryDiv RepositoryDiv { get; }
        public UserManager<UserModel> UserManager { get; }
        public IHttpHelper HttpHelper { get; }
        public IUserHelper UserHelper { get; }
        public IRepositoryPagina RepositoryPagina { get; }

        public DivController(ApplicationDbContext context, IRepositoryElemento repositoryElemento,
            IRepositoryDiv repositoryDiv, UserManager<UserModel> userManager, IHttpHelper httpHelper,
            IUserHelper userHelper, IRepositoryPagina repositoryPagina)
        {
            _context = context;
            RepositoryElemento = repositoryElemento;
            RepositoryDiv = repositoryDiv;
            UserManager = userManager;
            HttpHelper = httpHelper;
            UserHelper = userHelper;
            RepositoryPagina = repositoryPagina;
        }

        [Route("Div/ListaFixo/{id?}")]
        public async Task<IActionResult> ListaFixo(int? id)
        {
            List<Div> lista = new List<Div>();

            var pagina = await _context.Pagina
            .FirstAsync(p => p.Id == HttpHelper.GetPedidoId());

            var paginas = await _context.Pagina.Where(p => p.UserId == pagina.UserId).ToListAsync();
            
            pagina.Margem = false;
            pagina.Div = new List<DivPagina>();

            pagina.Div.AddRange(new List<DivPagina> {
                new DivPagina{ Div = new DivComum() }, new DivPagina{ Div = new DivComum() },
                new DivPagina{ Div = new DivComum() }, new DivPagina{ Div = new DivComum() },
                new DivPagina{ Div = new DivComum() }, new DivPagina{ Div = new DivComum() }
            });


            foreach (var page in paginas)
                if (id == null && _context.Div.FirstOrDefault(d => d.Pagina_ == page.Id && d is DivFixo) != null)
                {
                    var d1 = _context.Div.First(d => d.Pagina_ == page.Id && d is DivFixo);
                    foreach (var item in paginas)
                        foreach (var item2 in item.Div)
                            if (item2.Div.Id == d1.Id)
                                d1 = item2.Div;
                    pagina.Div.Add(new DivPagina { Div = d1, DivId = d1.Id, Pagina = page, PaginaId = page.Id });
                    break;
                }

            if (id != null)
            {
                var d1 = RepositoryDiv.includesBloco().ToList().First(d => d.Id == id);
                pagina.Div.Add(new DivPagina { Div = d1, DivId = d1.Id });
                        
            }

                List<Div> divs = new List<Div>();
            
            foreach (var page in paginas)
            {
                 divs.AddRange( _context.Div.ToList().Where(d => d.Pagina_ == page.Id && d is DivFixo).ToList());
            }

            for (int i = 0; i <= 5; i++)
            {
                if (i <= 6)
                    pagina.Div[i].Div = new DivComum
                    {
                        Background = new BackgroundCor
                        {
                            backgroundTransparente = true,
                            Cor = "transparent"
                        }
                    };
            }

            ViewBag.divs = divs;
            string html = await RepositoryPagina.renderizarPaginaComCarousel(pagina);
            ViewBag.Html = html;

            return PartialView(pagina);
        }

        [Route("Div/Lista")]
        public async Task<IActionResult> Lista()
        {
            List<Div> lista = new List<Div>();

            var pagina = await _context.Pagina
            .FirstAsync(p => p.Id == HttpHelper.GetPedidoId());

            var paginas = await _context.Pagina.Where(p => p.UserId == pagina.UserId).ToListAsync();
            
            pagina.Margem = false;
            pagina.Div = new List<DivPagina>();

            pagina.Div.AddRange(new List<DivPagina> {
                new DivPagina{ Div = new DivComum() }, new DivPagina{ Div = new DivComum() },
                new DivPagina{ Div = new DivComum() }, new DivPagina{ Div = new DivComum() },
                new DivPagina{ Div = new DivComum() }, new DivPagina{ Div = new DivComum() }
            });

            foreach (var page in paginas)
                if (page.Div.Skip(6).Where(d => d.Div is DivComum).ToList().Count > 0)
                    pagina.Div.AddRange(page.Div.Skip(6).Where(d => d.Div is DivComum).ToList());

            for (int i = 0; i <= 5; i++)
            {
                if (i <= 6)
                    pagina.Div[i].Div = new DivComum
                    {
                        Background = new BackgroundCor
                        {
                            backgroundTransparente = true,
                            Cor = "transparent"
                        }
                    };
            }

            string html = await RepositoryPagina.renderizarPaginaComCarousel(pagina);
            ViewBag.Html = html;

            return PartialView(pagina);
        }

        [Authorize(Roles = "Div")]
        [Route("Div/Create/{div}")]
        public IActionResult Create(string div)
        {
            Div bloco = null;
            if (div == "DivComum") bloco = new DivComum();
            if (div == "DivFixo") bloco = new DivFixo();

            bloco.Background = new BackgroundCor();

            var backgrounds = new List<Background>();
            var site = HttpHelper.GetPedidoId();


            return PartialView(bloco);
        }

        [Authorize(Roles = "Div")]
        public async Task<IActionResult> Edit(int? id)
        {
            var div = await _context.Div
                .Include(d => d.Elemento)
                .ThenInclude(d => d.Elemento)
                .FirstAsync(d => d.Id == id);
            if (div == null)
            {
                return NotFound();
            }
            

            foreach (var el in div.Elemento)
            {
                div.Elementos += el.Elemento.Id + ", ";
            }

            var site = HttpHelper.GetPedidoId();


            return PartialView(div);
        }

        #region Create-Edit-Div
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Div")]
        public async Task<string> _DivComum([FromBody]DivComum div)
        {
            try
            {
                if (div.Id == 0)
                    return await RepositoryDiv.SalvarBloco(div);
                else
                    return await RepositoryDiv.EditarBloco(div);
            }
            catch (Exception ex) { return ex.Message; }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Div")]
        public async Task<string> _DivFixo([FromBody] DivFixo div)
        {
            try
            {
                if (div.Id == 0)
                    return await RepositoryDiv.SalvarBloco(div);
                else
                    return await RepositoryDiv.EditarBloco(div);
            }
            catch (Exception ex) { return ex.Message; }
        }
        #endregion
    }
}
