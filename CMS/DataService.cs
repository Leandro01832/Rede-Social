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
using System.Data.SqlClient;
using System.IO;

namespace CMS
{
    public class DataService : IDataService
    {
        public  IRepositoryPagina epositoryPagina { get; }
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
            // if(RepositoryPagina.paginas.Count == 0)
            // await Task.Run(() => buscar(contexto));
          
           // var user = await UserManager.Users.
           // FirstOrDefaultAsync(u => u.UserName.ToLower() == Configuration.GetConnectionString("Email"));

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
        
            if (await contexto.Set<Imagem>().AnyAsync())
            {
                return;
            }

            var lista2 = await ListaImagens(provider);         

        }

        // private static void buscar(ApplicationDbContext contexto)
        // {           
        //         RepositoryPagina.paginas.AddRange( contexto.Pagina
        //         .Include(p => p.Produto)
        //     .ThenInclude(p => p.Imagem)
        //     .Include(p => p.Produto)
        //     .ThenInclude(p => p.Itens)
        //     .Include(p => p.Story)
        //      .ThenInclude(b => b.Pagina)

        //      .Include(b => b.SubStory) .ThenInclude(b => b.Pagina)
        //      .Include(b => b.SubStory) .ThenInclude(b => b.Grupo)
        //         .Include(b => b.Grupo) .ThenInclude(b => b.Pagina)
        //         .Include(b => b.Grupo) .ThenInclude(b => b.SubGrupo)
        //         .Include(b => b.SubGrupo).ThenInclude(b => b.Pagina)
        //         .Include(b => b.SubGrupo).ThenInclude(b => b.SubSubGrupo)
        //         .Include(b => b.SubSubGrupo).ThenInclude(b => b.Pagina)
        //         .Include(b => b.SubSubGrupo).ThenInclude(b => b.CamadaSeis)
        //         .Include(b => b.CamadaSeis).ThenInclude(b => b.Pagina)
        //         .Include(b => b.CamadaSeis).ThenInclude(b => b.CamadaSete)
        //         .Include(b => b.CamadaSete).ThenInclude(b => b.Pagina)
        //         .Include(b => b.CamadaSete).ThenInclude(b => b.CamadaOito)
        //         .Include(b => b.CamadaOito).ThenInclude(b => b.Pagina)
        //         .Include(b => b.CamadaOito).ThenInclude(b => b.CamadaNove)
        //         .Include(b => b.CamadaNove).ThenInclude(b => b.Pagina)
        //         .Include(b => b.CamadaNove).ThenInclude(b => b.CamadaDez)
        //         .Include(b => b.CamadaDez).ThenInclude(b => b.Pagina)   

        //     .Include(p => p.Div)
        //     .Include(p => p.Div).ThenInclude(b => b.Container).ThenInclude(b => b.Div)
        //     .ThenInclude(b => b.Div).ThenInclude(b => b.Elemento).ThenInclude(b => b.Elemento)
        //     .ThenInclude(b => b.Texto)  
        //         .Where(p => !p.Layout).OrderBy(p => p.Id).ToList());
        // }

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
