using business.business;
using CMS.Data;
using CMS.Models;
using CMS.Models.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http;
using System.Collections;
using SerpApi;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using CMS.Controllers;

namespace CMS
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        static string path = Directory.GetCurrentDirectory();
        

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
             string conecta1 = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={path}\wwwroot\rede-social2.mdf;Integrated Security=True";

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddResponseCompression(options =>
            {
                options.Providers.Add<BrotliCompressionProvider>();
                options.EnableForHttps = true;
            });

            services.AddDbContext<ApplicationDbContext>(options =>
              //  options.UseMySql( Configuration.GetConnectionString("DefaultConnection")));
              //  options.UseSqlServer( Configuration.GetConnectionString("DefaultConnection")));
                options.UseSqlServer(conecta1));
            services.AddDefaultIdentity<UserModel>()
                .AddRoles<IdentityRole>()
                .AddDefaultUI(UIFramework.Bootstrap3)
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddSignalR();

            services.Configure<IdentityOptions>(options =>
            {
                // Default Password settings.
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 8;
                options.Password.RequiredUniqueChars = 1;
            });

            services.Configure<IdentityOptions>(options =>
            {
                // Default SignIn settings.
                options.SignIn.RequireConfirmedEmail = false;
                options.SignIn.RequireConfirmedPhoneNumber = false;
            });
            
            services.AddMvc().AddSessionStateTempDataProvider();
            services.AddSession();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddJsonOptions(opcoes => // Remove valores nulos das respostas
                {
                    opcoes.SerializerSettings.NullValueHandling =
                        Newtonsoft.Json.NullValueHandling.Ignore;
                });

            services.Configure<EmailSettings>(Configuration.GetSection("EmailSettings"));
            services.AddTransient<IServiceEmailSender, EmailSender>();
            services.AddTransient<IDataService, DataService>();
            services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<IHttpHelper, HttpHelper>();
            services.AddTransient<IRepositoryPagina, RepositoryPagina>();
            services.AddTransient<IRepositoryDiv, RepositoryDiv>();
            services.AddTransient<IRepositoryElemento, RepositoryElemento>();
            services.AddTransient<IUserHelper, UserHelper>();
          //  services.AddHttpClient<ChatGptController>();

            services.AddAuthentication()
                .AddGoogle(options =>
                {
                    options.ClientId = Configuration["ExternalLogin:Google:ClientId"];
                    options.ClientSecret = Configuration["ExternalLogin:Google:ClientSecret"];
                });
          
            services.Configure<ForwardedHeadersOptions>(options =>
            {
                options.ForwardedHeaders = ForwardedHeaders.XForwardedFor |
                              ForwardedHeaders.XForwardedProto;
          
                options.KnownNetworks.Clear();
                options.KnownProxies.Clear();
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env,
            IServiceProvider serviceProvider, IUserHelper userHelper)
        {
            if (env.IsDevelopment())
            {
                
                app.UseStatusCodePagesWithReExecute("/Error/{0}");
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseStatusCodePagesWithReExecute("/Error/{0}");

                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseCookiePolicy();
            app.UseSession();
            app.UseAuthentication();
            app.UseForwardedHeaders();

            app.UseResponseCompression();
            

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            app.UseSignalR(Endpoint => Endpoint.MapHub<StreamingHub>("/streamingHub"));

            var dataService = serviceProvider.GetRequiredService<IDataService>();
            CreateRoles(serviceProvider, userHelper).Wait();
            dataService.InicializaDBAsync(serviceProvider).Wait();
        }

        private async Task CreateRoles(IServiceProvider serviceProvider, IUserHelper userHelper)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<UserModel>>();
            string[] rolesNames =
                {
                "Admin", "SuperAdmin", "Index", "Create", "Edit", "Delete", "User", "Carousel",
                "Background", "Imagem", "Video", "Music", "Ecommerce", "Texto", "AlteraPagina",
                "Consultor", "Transacao", "Link", "Div", "Elemento", "Pagina", "Formulario"
            };
            IdentityResult result;
            foreach (var namesRole in rolesNames)
            {
                var roleExist = await roleManager.RoleExistsAsync(namesRole);
                if (!roleExist)
                {
                    result = await roleManager.CreateAsync(new IdentityRole(namesRole));
                }
            }

           
            await userHelper.CheckSuperUserAsync();
        }
    }
}
