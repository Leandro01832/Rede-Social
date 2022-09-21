using business.business;
using business.Join;
using CMS.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace CMS.Models.Repository
{
    public interface IRepositoryPedido
    {
        void SalvarDominioExistente(string v);
        Task PermissoesDoSite(IdentityUser usuario);
        IIncludableQueryable<Pagina, List<DivElemento>> includes();
    }

    public class RepositoryPedido : BaseRepository<Pagina>, IRepositoryPedido
    {
        public RepositoryPedido(IConfiguration configuration, ApplicationDbContext contexto,
            IRepositoryDiv repositoryDiv,
            IHttpHelper httpHelper, IHostingEnvironment hostingEnvironment,
            IUserHelper userHelper) : base(configuration, contexto)
        {
            RepositoryDiv = repositoryDiv;
            HttpHelper = httpHelper;
            HostingEnvironment = hostingEnvironment;
            UserHelper = userHelper;
        }
        
        public IRepositoryDiv RepositoryDiv { get; }
        public IHttpHelper HttpHelper { get; }
        public IHostingEnvironment HostingEnvironment { get; }
        public IUserHelper UserHelper { get; }

        string path = Directory.GetCurrentDirectory();
        public string Caminho { get { return Path.Combine(path + "/wwwroot/Caminho/"); } }

       

        public void SalvarDominioExistente(string v)
        {
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(
                Caminho + "dominios.txt", true))
            {
                sw.WriteLine(v);
                sw.Close();
            }
        }

        public async Task PermissoesDoSite( IdentityUser usuario)
        {
            await UserHelper.CreateUserASPAsync(usuario.UserName, "Video");
            await UserHelper.CreateUserASPAsync(usuario.UserName, "Texto");
            await UserHelper.CreateUserASPAsync(usuario.UserName, "Imagem");
            await UserHelper.CreateUserASPAsync(usuario.UserName, "Carousel");
            await UserHelper.CreateUserASPAsync(usuario.UserName, "Background");
            await UserHelper.CreateUserASPAsync(usuario.UserName, "Music");
            await UserHelper.CreateUserASPAsync(usuario.UserName, "Link");
            await UserHelper.CreateUserASPAsync(usuario.UserName, "Div");
            await UserHelper.CreateUserASPAsync(usuario.UserName, "Elemento");
            await UserHelper.CreateUserASPAsync(usuario.UserName, "Pagina");
            await UserHelper.CreateUserASPAsync(usuario.UserName, "Ecommerce");
            await UserHelper.CreateUserASPAsync(usuario.UserName, "Formulario");
            await UserHelper.CreateUserASPAsync(usuario.UserName, "Admin");
            await contexto.Permissao.AddAsync(new Permissao
            { NomePermissao = "Video", UserId = usuario.Id, UserName = usuario.UserName });
            await contexto.Permissao.AddAsync(new Permissao
            { NomePermissao = "Texto", UserId = usuario.Id, UserName = usuario.UserName });
            await contexto.Permissao.AddAsync(new Permissao
            { NomePermissao = "Imagem", UserId = usuario.Id, UserName = usuario.UserName });
            await contexto.Permissao.AddAsync(new Permissao
            { NomePermissao = "Carousel", UserId = usuario.Id, UserName = usuario.UserName });
            await contexto.Permissao.AddAsync(new Permissao
            { NomePermissao = "Background", UserId = usuario.Id, UserName = usuario.UserName });
            await contexto.Permissao.AddAsync(new Permissao
            { NomePermissao = "Music", UserId = usuario.Id, UserName = usuario.UserName });
            await contexto.Permissao.AddAsync(new Permissao
            { NomePermissao = "Link", UserId = usuario.Id, UserName = usuario.UserName });
            await contexto.Permissao.AddAsync(new Permissao
            { NomePermissao = "Div", UserId = usuario.Id, UserName = usuario.UserName });
            await contexto.Permissao.AddAsync(new Permissao
            { NomePermissao = "Elemento", UserId = usuario.Id, UserName = usuario.UserName });
            await contexto.Permissao.AddAsync(new Permissao
            { NomePermissao = "Pagina", UserId = usuario.Id, UserName = usuario.UserName });
            await contexto.Permissao.AddAsync(new Permissao
            { NomePermissao = "Ecommerce", UserId = usuario.Id, UserName = usuario.UserName });
            await contexto.Permissao.AddAsync(new Permissao
            { NomePermissao = "Formulario", UserId = usuario.Id, UserName = usuario.UserName });
            await contexto.Permissao.AddAsync(new Permissao
            { NomePermissao = "Admin", UserId = usuario.Id, UserName = usuario.UserName });

            await contexto.SaveChangesAsync();
        }

        public IIncludableQueryable<Pagina, List<DivElemento>> includes()
        {
            var include = contexto.Pagina
                .Include(p => p.Div)
                .ThenInclude(p => p.Container)
                .ThenInclude(p => p.Div)
                .ThenInclude(p => p.Div)
                .ThenInclude(p => p.Elemento)
                .Include(p => p.Div)
                .ThenInclude(p => p.Pagina)
                .ThenInclude(p => p.Div)
                .ThenInclude(p => p.Container)
                .ThenInclude(p => p.Div)
                .ThenInclude(p => p.Div)
                .ThenInclude(p => p.Elemento);

            return include;
        }
    }
}
