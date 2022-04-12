using CMS.Data;
using CMS.Models.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CMS.Controllers
{
    public class ProdutoController : Controller
    {
        public ProdutoController(ApplicationDbContext contexto, IRepositoryElemento repositoryElemento)
        {
            Contexto = contexto;
            RepositoryElemento = repositoryElemento;
        }

        public ApplicationDbContext Contexto { get; }
        public IRepositoryElemento RepositoryElemento { get; }

        public async Task<IActionResult> Details(ulong id)
        {
            var produto = await RepositoryElemento.includes()
            .FirstAsync(p => p.Id == id);             

            return PartialView(produto);
        }
    }
}