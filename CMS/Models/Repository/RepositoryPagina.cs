using business.business;
using business.business.carousel;
using business.business.Elementos;
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
        Task<List<Pagina>> MostrarPageModels(string userId);
        Task<string> renderizarPagina(Pagina pagina);
        Task<string> renderizarPaginaComMenuDropDown(Pagina pagina);
        Task<bool> verificaTable(Pagina pagina);
        int[] criarRows(Pagina pagina);
        Task<string> renderizarPaginaComCarousel(Pagina pagina);
        Task BlocosdaPagina(Pagina pagina);
        Task<Pagina> TestarPagina(string id);
        IIncludableQueryable<Pagina, Div> includes();
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

        string path = Directory.GetCurrentDirectory();

        public string MenuDropDown { get { return File.ReadAllText(Path.Combine(path + "/wwwroot/Arquivotxt/MenuDropDown.cshtml")); } }

        //529
        public string CodigoCss2 { get { return File.ReadAllText(Path.Combine(path + "/wwwroot/Arquivotxt/DocCss.cshtml")); } }

        //142 linhas
        public string CodigoCss { get { return File.ReadAllText(Path.Combine(path + "/wwwroot/Arquivotxt/DocCss2.cshtml")); } }

        public string CodigoCssMenuDropDwn { get { return File.ReadAllText(Path.Combine(path + "/wwwroot/Arquivotxt/DocCss2MenuDropDown.cshtml")); } }

        //119 linhas
        public string CodigoBloco { get { return File.ReadAllText(Path.Combine(path + "/wwwroot/Arquivotxt/DocBloco.cshtml")); } }
        
        //711 linhas
        public string CodigoProducao { get { return File.ReadAllText(Path.Combine(path + "/wwwroot/Arquivotxt/DocProducao.cshtml")); } }
              
        public string CodigoModal { get { return File.ReadAllText(Path.Combine(path + "/wwwroot/Arquivotxt/modal.cshtml")); } }
        
        public string CodigoMusic { get { return File.ReadAllText(Path.Combine(path + "/wwwroot/Arquivotxt/music.cshtml")); } }

        public string CodigoCarousel { get { return File.ReadAllText(Path.Combine(path + "/wwwroot/Arquivotxt/Carousel.cshtml")); } }

        public string Html { get { return Path.Combine(path + "/wwwroot/Html/"); } }
        
        public IHostingEnvironment HostingEnvironment { get; }
        public SignInManager<UserModel> SignInManager { get; }
        public UserManager<UserModel> UserManager { get; }
        public IHttpContextAccessor ContextAccessor { get; }
        public IRepositoryDiv RepositoryDiv { get; }

        public static List<Pagina> paginas = new List<Pagina>();

        public async Task<List<Pagina>> MostrarPageModels(string userId)
        {         

            var lista = await  includes().Where(p => p.UserId == userId)
            .ToListAsync();           

            foreach (var pag in lista)
            {
                foreach (var div in pag.Div)
                {
                    div.Div.Elemento = div.Div.Elemento.OrderBy(e => e.Elemento.Ordem).ToList();
                }
            }

            foreach (var pag in lista)
            {
                foreach (var div in pag.Div)
                {
                    foreach (var item in div.Div.Elemento)
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

        public async Task<string> renderizarPagina(Pagina pagina)
        {
            //producao
            var resultado = await renderizar(pagina, CodigoCss + CodigoBloco
               + CodigoCss2 + CodigoProducao + CodigoMusic  + CodigoModal);
            return resultado;
        }        

        public async Task<bool> verificaTable(Pagina pagina)
        {            
            bool verifica = false;
            var paginas = await contexto.Pagina.Where(p => p.UserId == pagina.UserId).ToListAsync();
            foreach (var pag in paginas)
            {
                var ele = await contexto.Elemento.Include(e => e.div)
                    .ThenInclude(e => e.Div)
                    .OfType<Table>()
                .FirstOrDefaultAsync(e => e.Pagina_ == pag.Id);

                if (ele != null)
                {
                    verifica = true;
                }
            }
            return verifica;
        }

        public int[] criarRows(Pagina pagina)
        {
            int espaco = 0;
            int rows = 0;

            foreach (var bloco in pagina.Div.Skip(6).Select(d => d.Div))
            {
                if (bloco.Divisao == "col-md-12" || bloco.Divisao == "col-xs-12")
                    espaco += 12;

                if (bloco.Divisao == "col-md-6" || bloco.Divisao == "col-xs-6")
                    espaco += 6;

                if (bloco.Divisao == "col-md-4" || bloco.Divisao == "col-xs-4")
                    espaco += 4;

                if (bloco.Divisao == "col-md-3" || bloco.Divisao == "col-xs-3")
                    espaco += 3;

                if (bloco.Divisao == "col-md-2" || bloco.Divisao == "col-xs-2")
                    espaco += 2;


            }

            rows = espaco / 12;

            rows += 1;

            int[] numero = new int[rows];

            for (int i = 0; i < numero.Length; i++)
            {
                numero[i] += i + 1;

            }

            return numero;
        }      

        public async Task<string> renderizarPaginaComMenuDropDown(Pagina pagina)
        {
            var resultado = await renderizar(pagina, MenuDropDown + CodigoCssMenuDropDwn +
               CodigoBloco + CodigoCss2 + CodigoProducao  + CodigoMusic + CodigoModal);
            return resultado;
        }

        public async Task<string> renderizarPaginaComCarousel(Pagina pagina)
        {
            var resultado = await renderizar(pagina, CodigoCss + CodigoBloco + CodigoCss2 +
                CodigoProducao + CodigoMusic
                + CodigoCarousel + CodigoModal);
            return resultado;
        }
        
        
        public async Task BlocosdaPagina(Pagina pagina)
        {
            var site1 = await UserManager.Users.FirstAsync(p => p.Id == pagina.UserId);
            var cliente = site1.Id;

            string blocosGravados = "";
            var array = pagina.Blocos.Replace(" ", "").Split(',');

            if (pagina.Div != null)
            {

                foreach (var divPagina in pagina.Div.Skip(6))
                {
                    blocosGravados += divPagina.Div.Id + ", ";
                    if (!pagina.Blocos.Contains(divPagina.Div.Id.ToString()))
                    {
                        DivPagina dp;
                        try
                        {
                            dp = await contexto.DivPagina
                            .Include(de => de.Pagina)
                            .Include(de => de.Div)
                            .FirstOrDefaultAsync(e => e.Div.Id == divPagina.Div.Id &&
                            e.Pagina.Id == divPagina.Pagina.Id);
                        }
                        catch (Exception)
                        {
                            dp = null;
                        }
                        if (dp != null)
                        {
                            contexto.DivPagina.Remove(dp);
                        }
                    }
                }
                await contexto.SaveChangesAsync();
            }

            foreach (var id in array)
            {
                var page = await contexto.Pagina.Include(d => d.Div).FirstAsync(d => d.Id == pagina.Id);
                Div div;
                bool MesmoCliente = false;

                var Bloco = await contexto.Div.FirstOrDefaultAsync(d => d.Id == ulong.Parse(id));

                if (Bloco != null)
                {
                    var paginaBloco = contexto.Pagina.First(p => p.Id == Bloco.Pagina_);
                    var site = await contexto.Users.FirstAsync(p => p.Id == pagina.UserId);
                    if (site.Id == cliente)
                    {
                        MesmoCliente = true;
                    }
                }


                try
                {
                    div = await contexto.Div.FirstOrDefaultAsync(d => d.Id == ulong.Parse(id));
                }
                catch (Exception)
                {
                    div = null;
                }

                bool possuiTableProduto = await RepositoryDiv.VerificarExistenciaTable(id);

                if (div != null && MesmoCliente && !blocosGravados.Contains(id) && !possuiTableProduto)
                {
                    page.IncluiDiv(div);
                    await contexto.SaveChangesAsync();
                }

            }
        }

        public async Task<string> renderizar(Pagina pagina, string TextoHtml)
        {
            var site1 = await UserManager.Users.FirstAsync(p => p.Id == pagina.UserId);
            int[] numero = criarRows(pagina);           

            var condicao = await verificaTable(pagina);            

            var condicaoLogin = SignInManager.IsSignedIn(ContextAccessor.HttpContext.User);

            var username = UserManager.GetUserName(ContextAccessor.HttpContext.User);

            var redeFacebook = "";
            var redeTwiter = "";
            var redeInstagram = "";

            
                redeFacebook = site1.Facebook;
                redeTwiter = site1.Twitter;
                redeInstagram = site1.Instagram;
            

            Velocity.Init();
            var Modelo = new
            {
                Usuario = username,
                Login = condicaoLogin,
                Pedidos = condicao,
                Musicbool = pagina.Music,
                arquivoMusic = pagina.ArquivoMusic,
                Pagina = pagina,
                titulo = pagina.Titulo,
                facebook = redeFacebook,
                twiter = redeTwiter,
                instagram = redeInstagram,
                Div1 = pagina.Div.OrderBy(d => d.Div.Ordem).ToList().First(),
                Div2 = pagina.Div.Skip(1).OrderBy(d => d.Div.Id).ToList().First(),
                Div3 = pagina.Div.Skip(2).OrderBy(d => d.Div.Id).ToList().First(),
                Div4 = pagina.Div.Skip(3).OrderBy(d => d.Div.Id).ToList().First(),
                Div5 = pagina.Div.Skip(4).OrderBy(d => d.Div.Id).ToList().First(),
                Div6 = pagina.Div.Skip(5).OrderBy(d => d.Div.Id).ToList().First(),
                divs = pagina.Div.Skip(6).OrderBy(d => d.Div.Ordem).ToList(),
                Rows = numero,
                espacamento = 0,
                indice = 1

            };

            var velocitycontext = new VelocityContext();
            velocitycontext.Put("model", Modelo);
            velocitycontext.Put("divs", pagina.Div.Skip(6).OrderBy(d => d.Div.Ordem).ToList());
            var html = new StringBuilder();
            bool result = Velocity.Evaluate(velocitycontext, new StringWriter(html), "NomeParaCapturarLogError",
            new StringReader(TextoHtml));

            return html.ToString();
        }

        

        public async Task<Pagina> TestarPagina(string id)
        {
            Pagina pag;
            try
            {
                pag = await contexto.Pagina.FirstOrDefaultAsync(e => e.Id == ulong.Parse(id));
            }
            catch (Exception)
            {
                pag = null;
            }
            return pag;
        }

        public IIncludableQueryable<Pagina, Div> includes()
        {
            var include = dbSet
            .Include(p => p.Story)
            .Include(p => p.Div)

            .Include(p => p.Div).ThenInclude(b => b.Div).ThenInclude(b => b.Background).ThenInclude(b => b.Imagem)

            .Include(p => p.Div).ThenInclude(b => b.Div).ThenInclude(b => b.Background).ThenInclude(b => b.Cores)
            
            .Include(p => p.Div).ThenInclude(b => b.Div).ThenInclude(b => b.Elemento).ThenInclude(b => b.Elemento)

            .Include(p => p.Div).ThenInclude(b => b.Div).ThenInclude(b => b.Elemento).ThenInclude(b => b.Elemento)
            .ThenInclude(b => b.Imagem)

            .Include(p => p.Div).ThenInclude(b => b.Div).ThenInclude(b => b.Elemento).ThenInclude(b => b.Elemento)
            .ThenInclude(b => b.Texto)

            .Include(p => p.Div).ThenInclude(b => b.Div).ThenInclude(b => b.Elemento).ThenInclude(b => b.Elemento)
            .ThenInclude(b => b.Table)

            .Include(p => p.Div).ThenInclude(b => b.Div).ThenInclude(b => b.Elemento).ThenInclude(b => b.Elemento)
            .ThenInclude(b => b.Formulario)

            .Include(p => p.Div).ThenInclude(b => b.Div).ThenInclude(b => b.Elemento).ThenInclude(b => b.Elemento)
            .ThenInclude(b => b.Dependentes).ThenInclude(b => b.Elemento)

            .Include(p => p.Div).ThenInclude(b => b.Div).ThenInclude(b => b.Elemento).ThenInclude(b => b.Elemento)
            .ThenInclude(b => b.Dependentes).ThenInclude(b => b.ElementoDependente)
            
            .Include(p => p.Div).ThenInclude(b => b.Div).ThenInclude(b => b.Elemento).ThenInclude(b => b.Elemento)
            .ThenInclude(b => b.Paginas).ThenInclude(b => b.Elemento)

            .Include(p => p.Div).ThenInclude(b => b.Div).ThenInclude(b => b.Elemento).ThenInclude(b => b.Elemento)
            .ThenInclude(b => b.Paginas).ThenInclude(b => b.Pagina)

            .Include(p => p.Div).ThenInclude(b => b.Div).ThenInclude(b => b.Elemento).ThenInclude(b => b.Div);

            return include;
        }
    }
}
