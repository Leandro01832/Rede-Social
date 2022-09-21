using business.Back;
using business.business.Elementos.imagem;
using business.div;
using CMS.Data;
using CMS.Models;
using CMS.Models.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Globalization;
using System.Linq;
using System.Text;
using Microsoft.Extensions.Configuration;
using business.business.div;

namespace CMS
{
    public class DataService : IDataService
    {
        public IRepositoryPagina epositoryPagina { get; }
        public UserManager<UserModel> UserManager { get; }
        public IConfiguration Configuration { get; }

        public DataService(IRepositoryPagina repositoryPagina, UserManager<UserModel> userManager, IConfiguration configuration)
        {
            epositoryPagina = repositoryPagina;
            UserManager = userManager;
            Configuration = configuration;
        }


        public async Task InicializaDBAsync(IServiceProvider provider)
        {
            var contexto = provider.GetService<ApplicationDbContext>();   

            if (RepositoryPagina.paginas[0] == null)     
              RepositoryPagina.paginas[0] = new List<business.business.Pagina>();
             

            if (RepositoryPagina.paginas[0].FirstOrDefault() == null)
            {
                 var user = await UserManager.Users.FirstOrDefaultAsync(u => u.UserName.ToLower() == Configuration.GetConnectionString("Email"));
                var lst = await epositoryPagina.MostrarPageModels(user.Id);
                RepositoryPagina.paginas[0].AddRange(lst);
            }             

            if (await contexto.Set<Imagem>().AnyAsync())
            {
                return;
            }

            var lista = await ListaImagens(provider);         

        }

        private async Task<List<Imagem>> ListaImagens(IServiceProvider provider)
        {
            var contexto = provider.GetService<ApplicationDbContext>();

            var listaImagens = new List<Imagem>()
            {
                new Imagem
                {
                     ArquivoImagem = "/ImagensGaleria/1.jpg",
                       Nome = "Default",
                        Width = 100
                },
                new Imagem
                {
                     ArquivoImagem = "/ImagensGaleria/2.jpg",
                       Nome = "Default",
                        Width = 100
                },
                new Imagem
                {
                     ArquivoImagem = "/ImagensGaleria/3.jpg",
                       Nome = "Default",
                        Width = 100
                }
            };            

                      

            await contexto.Imagem.AddAsync(listaImagens[0]);
            await contexto.Imagem.AddAsync(listaImagens[1]);
            await contexto.Imagem.AddAsync(listaImagens[2]);
            await contexto.SaveChangesAsync();
            return listaImagens;
        }
    }
}
