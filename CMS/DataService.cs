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
using business.Join;
using business.business.link;
using business.business.Elementos.texto;

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

        //     string[] stories =
        //         {
        //         "brinquedos", "moveis", "roupas", "calçados", "relogios", "eletrônicos", "eletrodomesticos",
        //          "celular", "instrumentos", "cosmeticos", "notbooks"
        //          };
        //     string[] storiesEn =
        //         {
        //         "toy", "furniture", "clothes", "shoe", "clock", "electronics", "appliance",
        //          "iphone", "instrument", "cosmetic", "notbooks"
        //          };
            
        //     Random randNum = new Random();
        //     for(var t = 0; t < stories.Length; t++)
        //     {

        //     var name = stories[t];
        //     var client = new HttpClient();
        //     var request = new HttpRequestMessage
        //     {
        //        Method = HttpMethod.Get,
        //        RequestUri =
        //        new Uri($"https://serpapi.com/search.json?q={storiesEn[t]}" +
        //        "&tbm=shop&location=Dallas&hl=pt&gl=us&key=d0ebdc40d5e725ce2764208d4153772f10f531519c3952b626ce2f3a73191dd3"),
        //        Headers =
        //        {
        //            { "accept", "application/json" },
        //        },
        //     };

        //     using (var response = await client.SendAsync(request))
        //     {
        //        response.EnsureSuccessStatusCode();
        //        var body = await response.Content.ReadAsStringAsync();
        //        // Console.WriteLine(body);
        //        Welcome livro = JsonConvert.DeserializeObject<Welcome>(body);

        //        var indice = 0;
        //       var lst = await contexto.Story.Where(st => st.Nome != "Padrao").ToListAsync();

        //        var str = new Story();

        //          str.PaginaPadraoLink = lst.Count + 1;
        //          str.Nome = name;


        //           contexto.Add(str);
        //     await contexto.SaveChangesAsync();

        //     var Story = await contexto.Story.FirstAsync(st => st.Nome == "Padrao");

        //     var pag = new Pagina()
        //     {
        //             Data = DateTime.Now,
        //             ArquivoMusic = "",
        //             Titulo = "Story - " + str.Nome,
        //             CarouselPagina = new List<PaginaCarouselPagina>(),
        //             StoryId = Story.Id,
        //             Sobreescrita = null,
        //             SubStoryId = null,
        //             GrupoId = null,
        //             SubGrupoId = null,
        //             SubSubGrupoId = null,
        //             Layout = false,
        //             Music = false,
        //             Tempo = 11000
        //     };  
        //     pag.Div = null;              

        //      contexto.Add(pag);
        //      contexto.SaveChanges(); 
            
        //    var  pagin = new Pagina(1);  
        //     pagin.Div.First(d => d.Container.Content).Container.Div
        //     .First(d => d.Div.Content).Div.Elemento = new List<DivElemento>();
        //     pagin.Div.First(d => d.Container.Content).Container.Div
        //     .First(d => d.Div.Content).Div.Elemento.Add(new DivElemento
        //     {
        //         Div = pagin.Div.First(d => d.Container.Content).Container.Div
        //         .First(d => d.Div.Content).Div,
        //         Elemento = new LinkBody
        //         {
        //             Pagina_ = pag.Id,
        //             TextoLink = "#LinkPadrao",
        //             Texto = new Texto
        //             {
        //                 Pagina_ = pag.Id,
        //                 PalavrasTexto = "<h1> Story " + str.Nome + "</h1>"
        //             },
        //         }
        //     });

        //         pag.Div = new List<PaginaContainer>();                
        //     foreach (var item in pagin.Div)
            
        //         pag.IncluiDiv(item.Container);
                
        //         contexto.SaveChanges();   



        //        for(var i = 0; i < livro.ShoppingResults.Length; i++)
        //        {
        //            Pagina pagina = new Pagina();
        //            pagina.Div = null;
        //            pagina.Produto = new Produto
        //            {
        //                Descricao = livro.ShoppingResults[i].Title,
        //                Nome = name,
        //                Imagem = new List<ImagemProduto>
        //                { new ImagemProduto { ArquivoImagem = livro.ShoppingResults[i].Thumbnail.ToString() } },
        //                Preco = decimal.Parse(randNum.Next(50, 3000).ToString()),
        //                QuantEstoque = 10                              
        //            };
        //            pagina.Story = str;
        //            pagina.Tempo = 11000;
        //            pagina.Titulo = name;
        //            contexto.Pagina.Add(pagina);
        //            contexto.SaveChanges();

        //            indice++;

        //            if (indice == 2)
        //            {
        //                  for(var j = 0; j <= 2; j++)
        //                    {
        //                        Pagina pagi = new Pagina();
        //                        pagi.Story = str;
        //                        pagi.Div = null;
        //                        pagi.Tempo = 11000;
        //                        pagi.Titulo = name;
        //                        contexto.Pagina.Add(pagi);
        //                        contexto.SaveChanges();
        //                    }
        //                        indice = 0;
        //            }


        //        }
        //     }
        //     }

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
