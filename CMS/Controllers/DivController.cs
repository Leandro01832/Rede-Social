using business.Back;
using business.div;
using business.Join;
using business.business;
using CMS.Data;
using CMS.Models.Repository;
using CMS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using business.business.div;

namespace CMS.Controllers
{
    public class DivController : Controller
    {
        private readonly ApplicationDbContext _context;

        public IRepositoryElemento RepositoryElemento { get; }
        public IRepositoryDiv RepositoryDiv { get; }
        public IHttpHelper HttpHelper { get; }
        public IUserHelper UserHelper { get; }
        public UserManager<UserModel> UserManager { get; }
        public IRepositoryPagina RepositoryPagina { get; }

        public DivController(ApplicationDbContext context, IRepositoryElemento repositoryElemento,
            IRepositoryDiv repositoryDiv, IHttpHelper httpHelper, IUserHelper userHelper,
            IRepositoryPagina repositoryPagina, UserManager<UserModel> userManager)
        {
            _context = context;
            RepositoryElemento = repositoryElemento;
            RepositoryDiv = repositoryDiv;
            HttpHelper = httpHelper;
            UserHelper = userHelper;
            RepositoryPagina = repositoryPagina;
            UserManager = userManager;
        }

        [Route("Div/ListaFixo/{id?}")]
        public async Task<IActionResult> ListaFixo(Int64? id)
        {
            List<Div> lista = new List<Div>();
            var user = await UserManager.GetUserAsync(this.User);

            var paginas = await RepositoryPagina.includes()
            .Where(p => p.UserId == user.Id).ToListAsync();     

            Pagina pagina = new Pagina(1);
            pagina.Div.First(d => d.Container.Content).Container.Div
                      .First(d => d.Div.Content).Div.Elemento = new List<DivElemento>();  


            foreach (var page in paginas)
            foreach (var item in page.Div)
            foreach (var item2 in item.Container.Div.Where(d => d.Div is DivFixo))
            lista.Add(item2.Div);

            if (id != null)
            {
                var d1 = RepositoryDiv.includesBloco().ToList().First(d => d.Id == id);
                pagina.Div.First(d => d.Container.Content).Container.Div
                .First(d => d.Div.Content).Div = d1;                        
            }                           

            ViewBag.divs = lista;
            string html = await RepositoryPagina.renderizarPagina(pagina);
            ViewBag.Html = html;

            return PartialView(pagina);
        }

        [Route("Div/Lista")]
        public async Task<IActionResult> Lista()
        {
            List<Div> lista = new List<Div>();
            var user = await UserManager.GetUserAsync(this.User);

            var pagina = new Pagina(1);
            pagina.Div.First(d => d.Container.Content).Container.Div = new List<DivContainer>();
            pagina.Div.First(d => d.Container.Content).Container.Div
                      .First(d => d.Div.Content).Div.Elemento = new List<DivElemento>(); 

            var paginas = await RepositoryPagina.includes()
            .Where(p => p.UserId == user.Id).ToListAsync();            
            

             foreach (var page in paginas)
             foreach (var div in page.Div)
             foreach(var div2 in div.Container.Div.Where(d => d.Div is DivComum))
                     lista.Add(div2.Div);

                foreach (var item in lista)
                pagina.Div.First(d => d.Container.Content).Container.Div.Add
                (
                    new DivContainer
                    {
                        Container = pagina.Div.First(d => d.Container.Content).Container,
                        Div = item
                    }
                ); 
            

            string html = await RepositoryPagina.renderizarPagina(pagina);
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
            return PartialView(bloco);
        }

        [Authorize(Roles = "Div")]
        [Route("Div/Edit/{id}")]
        public async Task<IActionResult> Edit(Int64? id)
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
                else{
                    
                    return await RepositoryDiv.EditarBloco(div);
                }
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
