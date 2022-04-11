using business.business;
using CMS.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Models.Repository
{
    public interface IUserHelper
    {
        Task<bool> DeleteUserAsync(string username);
        Task<bool> UpdateUserAsync(string currentusername, string newUserName);
        Task CheckRoleAsync(string roleName);
         Task CheckSuperUserAsync();
        Task CreateUserASPAsync(string email, string roleName);
        Task CreateUserASPAsync(string email, string roleName, string password);
    }

    public class UserHelper : IUserHelper
    {
        public ApplicationDbContext userContext { get; }
        public UserManager<UserModel> UserManager { get; }
        public RoleManager<IdentityRole> RoleManager { get; }
        public IConfiguration Configuration { get; }

        public UserHelper(ApplicationDbContext contexto, UserManager<UserModel> userManager,
            RoleManager<IdentityRole> roleManager, IConfiguration configuration)
        {
            userContext = contexto;
            UserManager = userManager;
            RoleManager = roleManager;
            Configuration = configuration;
        }

        public async Task<bool> DeleteUserAsync(string username)
        {            
            var userASP = await UserManager.FindByEmailAsync(username);
            if (userASP != null)
            {
                var response = await UserManager.DeleteAsync(userASP);
                return response.Succeeded;
            }

            return false;
        }

        public async Task<bool> UpdateUserAsync(string currentusername, string newUserName)
        {
            var userASP = await UserManager.FindByEmailAsync(currentusername);
            if (userASP != null)
            {
                userASP.UserName = newUserName;
                userASP.Email = newUserName;
                var response = await UserManager.UpdateAsync(userASP);
                return response.Succeeded;
            }
            return false;
        }


        public async Task CheckRoleAsync(string roleName)
        {
            if (! await RoleManager.RoleExistsAsync(roleName))
            {
               await RoleManager.CreateAsync(new IdentityRole(roleName));
            }
        }

        public async Task CheckSuperUserAsync()
        {            
            var email = Configuration.GetConnectionString("Email");
            var password = Configuration.GetConnectionString("Senha");
            var userASP = await UserManager.FindByNameAsync(email);
            if (userASP == null)
            {
                var user = new UserModel { UserName = email, Name = "Leandro", Image = "/ImagensGaleria/Padrao.jpg" };
               await UserManager.CreateAsync(user, password);

                await CreateUserASPAsync(user.UserName, "Video");
                await CreateUserASPAsync(user.UserName, "Texto");
                await CreateUserASPAsync(user.UserName, "Imagem");
                await CreateUserASPAsync(user.UserName, "Carousel");
                await CreateUserASPAsync(user.UserName, "Background");
                await CreateUserASPAsync(user.UserName, "Music");
                await CreateUserASPAsync(user.UserName, "Link");
                await CreateUserASPAsync(user.UserName, "Div");
                await CreateUserASPAsync(user.UserName, "Elemento");
                await CreateUserASPAsync(user.UserName, "Pagina");
                await CreateUserASPAsync(user.UserName, "Ecommerce");
                await CreateUserASPAsync(user.UserName, "Formulario");
                await CreateUserASPAsync(user.UserName, "Admin");

                await userContext.Permissao.AddAsync(new Permissao
                { NomePermissao = "Video", UserId = user.Id, UserName = user.UserName });
                await userContext.Permissao.AddAsync(new Permissao
                { NomePermissao = "Texto", UserId = user.Id, UserName = user.UserName });
                await userContext.Permissao.AddAsync(new Permissao
                { NomePermissao = "Imagem", UserId = user.Id, UserName = user.UserName });
                await userContext.Permissao.AddAsync(new Permissao
                { NomePermissao = "Carousel", UserId = user.Id, UserName = user.UserName });
                await userContext.Permissao.AddAsync(new Permissao
                { NomePermissao = "Background", UserId = user.Id, UserName = user.UserName });
                await userContext.Permissao.AddAsync(new Permissao
                { NomePermissao = "Music", UserId = user.Id, UserName = user.UserName });
                await userContext.Permissao.AddAsync(new Permissao
                { NomePermissao = "Link", UserId = user.Id, UserName = user.UserName });
                await userContext.Permissao.AddAsync(new Permissao
                { NomePermissao = "Div", UserId = user.Id, UserName = user.UserName });
                await userContext.Permissao.AddAsync(new Permissao
                { NomePermissao = "Elemento", UserId = user.Id, UserName = user.UserName });
                await userContext.Permissao.AddAsync(new Permissao
                { NomePermissao = "Pagina", UserId = user.Id, UserName = user.UserName });
                await userContext.Permissao.AddAsync(new Permissao
                { NomePermissao = "Ecommerce", UserId = user.Id, UserName = user.UserName });
                await userContext.Permissao.AddAsync(new Permissao
                { NomePermissao = "Formulario", UserId = user.Id, UserName = user.UserName });
                await userContext.Permissao.AddAsync(new Permissao
                { NomePermissao = "Admin", UserId = user.Id, UserName = user.UserName });

                var str = new Story
                {
                    Nome = "Padrao",
                    UserId = user.Id,
                     PaginaPadraoLink = 0
                };
                await userContext.AddAsync(str);
                await userContext.SaveChangesAsync();

                await userContext.SaveChangesAsync();
                return;
            }

         await UserManager.AddToRoleAsync(userASP, "SuperAdmin");
        }

        public async Task CreateUserASPAsync(string email, string roleName)
        {            
            var users = UserManager.Users.ToList();
            var user = users.Find(u => u.UserName == email);            
          await  UserManager.AddToRoleAsync(user, roleName);
        }

        public async Task CreateUserASPAsync(string email, string roleName, string password)
        {
            var userASP = new UserModel
            {
                Email = email,
                UserName = email,
            };

           await UserManager.CreateAsync(userASP);
          await  UserManager.AddToRoleAsync(userASP, roleName);
        }
        

        public async Task<bool> VerificarPermissao2(string site, string email, string condicao, string elemento)
        {
            if (elemento == "Table" || elemento == "Produto")            
                condicao = "Ecommerce";            
            else if (elemento == "Campo")
                condicao = "Formulario";            
            else if (elemento == "CarouselPagina" || elemento == "CarouselImg")            
                condicao = "Carousel";            
            else if (elemento == "Dropdown" || elemento == "LinkBody" || elemento == "LinkMenu")            
                condicao = "Link";            
            else            
                condicao = elemento;            

            if (await userContext.Permissao.FirstOrDefaultAsync(p => p.UserId == site
            && p.UserName == email && p.NomePermissao == condicao) == null)
            return false;
            return true;
        }       
        
    }

}
