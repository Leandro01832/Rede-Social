using business.business;
using business.business.carousel;
using business.business.Elementos;
using business.business.Group;
using business.div;
using business.Join;
using CMS.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.Extensions.Configuration;
using NVelocity;
using NVelocity.App;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Models.Repository
{
    public interface IRepositoryPagina
    {
        Task<List<Pagina>> MostrarPageModels();
         string renderizarPagina(Pagina pagina);
        IIncludableQueryable<Pagina, Div> includes();

        Task<string> retornarVideos(long lista);

        
    }

    public class RepositoryPagina : BaseRepository<Pagina>, IRepositoryPagina
    {
        public RepositoryPagina(IConfiguration configuration, ApplicationDbContext contexto,
            IHostingEnvironment hostingEnvironment,
             SignInManager<UserModel> signInManager, UserManager<UserModel> userManager,
              IHttpContextAccessor contextAccessor, IRepositoryDiv repositoryDiv) : base(configuration, contexto)
        {
            HostingEnvironment = hostingEnvironment;
            SignInManager = signInManager;
            UserManager = userManager;
            ContextAccessor = contextAccessor;
            RepositoryDiv = repositoryDiv;
        }

       static string path = Directory.GetCurrentDirectory();       
      public static string outroLivro = "https://localhost:5001";       
     public  static int outroCapitulo = 1;       

        //140 linhas
        public string CodCss { get { return File.ReadAllText(Path.Combine(path + "/wwwroot/Arquivotxt/DocCss.cshtml")); } }  
        //93 linhas
        public string CodCss2 { get { return File.ReadAllText(Path.Combine(path + "/wwwroot/Arquivotxt/DocCssDiv.cshtml")); } }  

        //350 linhas
        public string CodigoBloco { get { return File.ReadAllText(Path.Combine(path + "/wwwroot/Arquivotxt/DocBloco.cshtml")); } }
        
        //515 linhas
        public string CodigoProducao { get { return File.ReadAllText(Path.Combine(path + "/wwwroot/Arquivotxt/DocProducao.cshtml")); } }
        
        //7 linhas
        public string CodigoMusic { get { return File.ReadAllText(Path.Combine(path + "/wwwroot/Arquivotxt/music.cshtml")); } }

        // 30 linhas
        public string CodigoCarousel { get { return File.ReadAllText(Path.Combine(path + "/wwwroot/Arquivotxt/Carousel.cshtml")); } }

        public string CodigoVideos { get { return File.ReadAllText(Path.Combine(path + "/wwwroot/Arquivotxt/videos.txt")); } }
        
        
        
        public IHostingEnvironment HostingEnvironment { get; }
        public SignInManager<UserModel> SignInManager { get; }
        public UserManager<UserModel> UserManager { get; }
        public IHttpContextAccessor ContextAccessor { get; }
        public IRepositoryDiv RepositoryDiv { get; }

      //  public static List<Pagina>[] paginas = new List<Pagina>[99999999];
        public static List<Pagina> paginas = new List<Pagina>();

        public static string Capa = "<br /> <br /> <br />  <center> <h1> "+ 
                 "Instagleo</h1> <br /> <img src='" + "/" +
                 "' width='300' class='img-circle img-responsive' /> </center> <br />  <br /> <br /> ";
        
     

        public async Task<List<Pagina>> MostrarPageModels()
        {         

            var lista = await  includes().ToListAsync();            

            foreach (var pag in lista)
            {
                foreach (var div in pag.Div)
                foreach (var div2 in div.Container.Div)
                {
                    foreach (var item in div2.Div.Elemento)
                    {
                        if(item.Elemento is CarouselPagina)
                        {
                            foreach (var item2 in item.Elemento.Paginas)
                                item2.Pagina = lista.First(p => p.Id == item2.PaginaId);
                        }
                    }
                }
            }

            return  lista;
        }         

        public string renderizarPagina(Pagina pagina)
        {
            var resultado =  renderizar(pagina, CodigoBloco + CodCss + CodCss2 +
                CodigoProducao + CodigoMusic
                + CodigoCarousel);
            return resultado;
        }       
       

        public string renderizar(Pagina pagina, string TextoHtml)
        {
            var condicaoLogin = SignInManager.IsSignedIn(ContextAccessor.HttpContext.User);
            var username = UserManager.GetUserName(ContextAccessor.HttpContext.User);             

            Velocity.Init();
            var Modelo = new
            {
                Usuario = username,
                Login = condicaoLogin,
                Musicbool = pagina.Music,
                arquivoMusic = pagina.ArquivoMusic,
                Pagina = pagina,
                titulo = pagina.Titulo,
                Div1 = pagina.Div.OrderBy(d => d.Container.Id).ToList().First(),
                divs = pagina.Div.OrderBy(d => d.Container.Id).Skip(1).ToList(),
                espacamento = 0,
                indice = 1

            };

            var velocitycontext = new VelocityContext();
            velocitycontext.Put("model", Modelo);
            velocitycontext.Put("divs", pagina.Div.OrderBy(d => d.Container.Id).Skip(1).ToList());
            var html = new StringBuilder();
            bool result = Velocity.Evaluate(velocitycontext, new StringWriter(html), "NomeParaCapturarLogError",
            new StringReader(TextoHtml));

           

            return html.ToString();
        }       

        public IIncludableQueryable<Pagina, Div> includes()
        {
            var include = dbSet
            .Include(p => p.Produto)
            .ThenInclude(p => p.Imagem)
            .Include(p => p.Produto)
            .ThenInclude(p => p.Itens)
            .Include(p => p.Story)
             .ThenInclude(b => b.Pagina)

             .Include(p => p.Story)
             .ThenInclude(b => b.SubStory)
              .ThenInclude(b => b.Pagina)

                .Include(p => p.Story)
                .ThenInclude(b => b.SubStory)
                .ThenInclude(b => b.Grupo)
                .ThenInclude(b => b.Pagina)

                .Include(p => p.Story)
                .ThenInclude(b => b.SubStory)
                .ThenInclude(b => b.Grupo)
                .ThenInclude(b => b.SubGrupo)
                .ThenInclude(b => b.Pagina)

                .Include(p => p.Story)
                .ThenInclude(b => b.SubStory)
                .ThenInclude(b => b.Grupo)
                .ThenInclude(b => b.SubGrupo)
                .ThenInclude(b => b.SubSubGrupo)
                .ThenInclude(b => b.Pagina)

                .Include(p => p.Div).ThenInclude(b => b.Container).ThenInclude(b => b.Background).ThenInclude(b => b.Imagem)
                .Include(p => p.Div).ThenInclude(b => b.Container).ThenInclude(b => b.Background).ThenInclude(b => b.Cores)
                .Include(p => p.Div).ThenInclude(b => b.Container).ThenInclude(b => b.Background).ThenInclude(b => b.Video)

                 .Include(p => p.Div).ThenInclude(b => b.Container).ThenInclude(b => b.Div).ThenInclude(b => b.Div).ThenInclude(b => b.Background).ThenInclude(b => b.Imagem)
                .Include(p => p.Div).ThenInclude(b => b.Container).ThenInclude(b => b.Div).ThenInclude(b => b.Div).ThenInclude(b => b.Background).ThenInclude(b => b.Cores)
                .Include(p => p.Div).ThenInclude(b => b.Container).ThenInclude(b => b.Div).ThenInclude(b => b.Div).ThenInclude(b => b.Background).ThenInclude(b => b.Video)

                 .Include(p => p.Div).ThenInclude(b => b.Container).ThenInclude(b => b.Div).ThenInclude(b => b.Div)
                 .ThenInclude(b => b.Elemento).ThenInclude(b => b.Elemento).ThenInclude(b => b.Background).ThenInclude(b => b.Imagem)
                .Include(p => p.Div).ThenInclude(b => b.Container).ThenInclude(b => b.Div).ThenInclude(b => b.Div)
                .ThenInclude(b => b.Elemento).ThenInclude(b => b.Elemento).ThenInclude(b => b.Background).ThenInclude(b => b.Cores)
                .Include(p => p.Div).ThenInclude(b => b.Container).ThenInclude(b => b.Div).ThenInclude(b => b.Div)
                 .ThenInclude(b => b.Elemento).ThenInclude(b => b.Elemento).ThenInclude(b => b.Background).ThenInclude(b => b.Video)


            .Include(p => p.Div)

            .Include(p => p.Div).ThenInclude(b => b.Container).ThenInclude(b => b.Div).ThenInclude(b => b.Div).ThenInclude(b => b.Elemento).ThenInclude(b => b.Elemento)
            .ThenInclude(b => b.Imagem)

            .Include(p => p.Div).ThenInclude(b => b.Container).ThenInclude(b => b.Div).ThenInclude(b => b.Div).ThenInclude(b => b.Elemento).ThenInclude(b => b.Elemento)
            .ThenInclude(b => b.Texto)

            .Include(p => p.Div).ThenInclude(b => b.Container).ThenInclude(b => b.Div).ThenInclude(b => b.Div).ThenInclude(b => b.Elemento).ThenInclude(b => b.Elemento)
            .ThenInclude(b => b.Formulario)

            .Include(p => p.Div).ThenInclude(b => b.Container).ThenInclude(b => b.Div).ThenInclude(b => b.Div).ThenInclude(b => b.Elemento).ThenInclude(b => b.Elemento)
            .ThenInclude(b => b.Dependentes).ThenInclude(b => b.Elemento)

            .Include(p => p.Div).ThenInclude(b => b.Container).ThenInclude(b => b.Div).ThenInclude(b => b.Div).ThenInclude(b => b.Elemento).ThenInclude(b => b.Elemento)
            .ThenInclude(b => b.Dependentes).ThenInclude(b => b.ElementoDependente)
            
            .Include(p => p.Div).ThenInclude(b => b.Container).ThenInclude(b => b.Div).ThenInclude(b => b.Div).ThenInclude(b => b.Elemento).ThenInclude(b => b.Elemento)
            .ThenInclude(b => b.Paginas).ThenInclude(b => b.Elemento)

            .Include(p => p.Div).ThenInclude(b => b.Container).ThenInclude(b => b.Div).ThenInclude(b => b.Div).ThenInclude(b => b.Elemento).ThenInclude(b => b.Elemento)
            .ThenInclude(b => b.Paginas).ThenInclude(b => b.Pagina)

            .Include(p => p.Div).ThenInclude(b => b.Container).ThenInclude(b => b.Div).ThenInclude(b => b.Div).ThenInclude(b => b.Elemento).ThenInclude(b => b.Div);

            return include;
        }

        public async Task<string> retornarVideos(long lista)
        {
            var end = await contexto.VideoIncorporado.FirstAsync(vi => vi.Id == lista);
            return File.ReadAllText(Path.Combine(path + $"/wwwroot/Arquivotxt{end.ArquivoVideoIncorporado}.txt"));
        }
    }
}
