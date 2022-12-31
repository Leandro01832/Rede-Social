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
using System.Net.Http.Headers;
using System.Net.Http;
using Newtonsoft.Json;
using business.business;
using business.business.Group;

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
            var user = await UserManager.Users.
            FirstOrDefaultAsync(u => u.UserName.ToLower() == Configuration.GetConnectionString("Email"));
            var contexto = provider.GetService<ApplicationDbContext>();

            // Random randNum = new Random();

            // var client = new HttpClient();
            // var request = new HttpRequestMessage
            // {
            //    Method = HttpMethod.Get,
            //    RequestUri =
            //    new Uri("https://serpapi.com/search.json?q=notbook" +
            //    "&tbm=shop&location=Dallas&hl=pt&gl=us&key=d0ebdc40d5e725ce2764208d4153772f10f531519c3952b626ce2f3a73191dd3"),
            //    Headers =
            //    {
            //        { "accept", "application/json" },
            //    },
            // };

            // using (var response = await client.SendAsync(request))
            // {
            //    response.EnsureSuccessStatusCode();
            //    var body = await response.Content.ReadAsStringAsync();
            //    // Console.WriteLine(body);
            //    Welcome livro = JsonConvert.DeserializeObject<Welcome>(body);

            //    var indice = 0;
            //   var lst = await contexto.Story.Where(st => st.Nome != "Padrao" && st.UserId == user.Id).ToListAsync();

            //    var str = new Story();
               
            //      str.PaginaPadraoLink = lst.Count + 1;
            //      str.Nome = "notbooks";
            //      str.UserId = user.Id;

               

            //    for(var i = 0; i < livro.ShoppingResults.Length; i++)
            //    {
            //        Pagina pagina = new Pagina();
            //        pagina.Div = null;
            //        pagina.Produto = new Produto
            //        {
            //            Descricao = livro.ShoppingResults[i].Title,
            //            Nome = "notbooks",
            //            Imagem = new List<ImagemProduto>
            //            { new ImagemProduto { ArquivoImagem = livro.ShoppingResults[i].Thumbnail.ToString() } },
            //            Preco = decimal.Parse(randNum.Next(550, 3000).ToString()),
            //            QuantEstoque = 10                              
            //        };
            //        pagina.Story = str;
            //        pagina.UserId = user.Id;
            //        pagina.Tempo = 15000;
            //        pagina.Titulo = "notbooks";
            //        contexto.Pagina.Add(pagina);
            //        contexto.SaveChanges();

            //        indice++;

            //        if (indice == 5)
            //        {
            //            Pagina pag = new Pagina();
            //            pag.Story = str;
            //            pag.Div = null;
            //            pag.UserId = user.Id;
            //            pag.Tempo = 15000;
            //            pag.Titulo = "notbooks";
            //            contexto.Pagina.Add(pag);
            //            contexto.SaveChanges();
            //            indice = 0;
            //        }

                    
            //    }
            // }

            // if (RepositoryPagina.paginas[0] == null)     
            //   RepositoryPagina.paginas[0] = new List<business.business.Pagina>();
             

            // if (RepositoryPagina.paginas[0].FirstOrDefault() == null)
            // {
            //     var lst = await epositoryPagina.MostrarPageModels(user.Id);
            //     RepositoryPagina.paginas[0].AddRange(lst);
            // }             

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
                        WidthImagem = 100
                },
                new Imagem
                {
                     ArquivoImagem = "/ImagensGaleria/2.jpg",
                       Nome = "Default",
                        WidthImagem = 100
                },
                new Imagem
                {
                     ArquivoImagem = "/ImagensGaleria/3.jpg",
                       Nome = "Default",
                        WidthImagem = 100
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
