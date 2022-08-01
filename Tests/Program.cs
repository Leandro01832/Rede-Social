using business.Back;
using business.business;
using business.business.carousel;
using business.business.element;
using business.business.Elementos;
using business.business.Elementos.element;
using business.business.Elementos.imagem;
using business.business.Elementos.produto;
using business.business.Elementos.texto;
using business.business.link;
using business.div;
using business.ecommerce;
using business.Join;
using CMS.Models.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    class Program
    {

        static void Main(string[] args)
        {
            CMSContext banco = new CMSContext();
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            var serviceProvider = serviceCollection.BuildServiceProvider();

            var paginas = RepositoryPagina.paginas;

            for(Int64 i = 0; i <= 1000000; i++)
            {
                Console.WriteLine(i);
                RepositoryPagina.paginas.Add(new Pagina
                {
                    Id = i,
                    ArquivoMusic = "",
                    Margem = false,
                    Music = false,
                    Titulo = "Default",
                    Layout = false,
                    UserId = "",
                    StoryId = 0
                });

                RepositoryPagina.paginas.Add(new Pagina
                {
                    Id = i + 1000000,
                    ArquivoMusic = "",
                    Margem = false,
                    Music = false,
                    Titulo = "Default",
                    Layout = false,
                    UserId = "",
                    StoryId = 0
                });

                RepositoryPagina.paginas.Add(new Pagina
                {
                    Id = i + 2000000,
                    ArquivoMusic = "",
                    Margem = false,
                    Music = false,
                    Titulo = "Default",
                    Layout = false,
                    UserId = "",
                    StoryId = 0
                });

                RepositoryPagina.paginas.Add(new Pagina
                {
                    Id = i + 3000000,
                    ArquivoMusic = "",
                    Margem = false,
                    Music = false,
                    Titulo = "Default",
                    Layout = false,
                    UserId = "",
                    StoryId = 0
                });

                RepositoryPagina.paginas.Add(new Pagina
                {
                    Id = i + 4000000,
                    ArquivoMusic = "",
                    Margem = false,
                    Music = false,
                    Titulo = "Default",
                    Layout = false,
                    UserId = "",
                    StoryId = 0
                });

                RepositoryPagina.paginas.Add(new Pagina
                {
                    Id = i + 5000000,
                    ArquivoMusic = "",
                    Margem = false,
                    Music = false,
                    Titulo = "Default",
                    Layout = false,
                    UserId = "",
                    StoryId = 0
                });

                RepositoryPagina.paginas.Add(new Pagina
                {
                    Id = i + 6000000,
                    ArquivoMusic = "",
                    Margem = false,
                    Music = false,
                    Titulo = "Default",
                    Layout = false,
                    UserId = "",
                    StoryId = 0
                });

                RepositoryPagina.paginas.Add(new Pagina
                {
                    Id = i + 7000000,
                    ArquivoMusic = "",
                    Margem = false,
                    Music = false,
                    Titulo = "Default",
                    Layout = false,
                    UserId = "",
                    StoryId = 0
                });

                RepositoryPagina.paginas.Add(new Pagina
                {
                    Id = i + 8000000,
                    ArquivoMusic = "",
                    Margem = false,
                    Music = false,
                    Titulo = "Default",
                    Layout = false,
                    UserId = "",
                    StoryId = 0
                });

                RepositoryPagina.paginas.Add(new Pagina
                {
                    Id = i + 9000000,
                    ArquivoMusic = "",
                    Margem = false,
                    Music = false,
                    Titulo = "Default",
                    Layout = false,
                    UserId = "",
                    StoryId = 0
                });

                RepositoryPagina.paginas.Add(new Pagina
                {
                    Id = i + 10000000,
                    ArquivoMusic = "",
                    Margem = false,
                    Music = false,
                    Titulo = "Default",
                    Layout = false,
                    UserId = "",
                    StoryId = 0
                });

                 RepositoryPagina.paginas.Add(new Pagina
                {
                    Id = i + 11000000,
                    ArquivoMusic = "",
                    Margem = false,
                    Music = false,
                    Titulo = "Default",
                    Layout = false,
                    UserId = "",
                    StoryId = 0
                });

                 RepositoryPagina.paginas.Add(new Pagina
                {
                    Id = i + 12000000,
                    ArquivoMusic = "",
                    Margem = false,
                    Music = false,
                    Titulo = "Default",
                    Layout = false,
                    UserId = "",
                    StoryId = 0
                });

                
            }

     
            Console.WriteLine(RepositoryPagina.paginas.Count);            

            var lista1 = RepositoryPagina.paginas.Where(p => p.Id < 10000).ToList();
            var lista2 = RepositoryPagina.paginas.Where(p => p.Id < 20000).ToList();
            var lista3 = RepositoryPagina.paginas.Where(p => p.Id < 30000).ToList();
            var lista4 = RepositoryPagina.paginas.Where(p => p.Id < 40000).ToList();
            var lista5 = RepositoryPagina.paginas.Where(p => p.Id < 50000).ToList();
            var lista6 = RepositoryPagina.paginas.Where(p => p.Id < 60000).ToList();
            var lista7 = RepositoryPagina.paginas.Where(p => p.Id < 70000).ToList();
            var lista8 = RepositoryPagina.paginas.Where(p => p.Id < 80000).ToList();
            var lista9 = RepositoryPagina.paginas.Where(p => p.Id < 90000).ToList();
            var lista10 = RepositoryPagina.paginas.Where(p => p.Id < 100000).ToList();

            Console.WriteLine("Executado!!!");  
            Console.Read();
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddIdentityCore<IdentityUser>();


        }

        public static IIncludableQueryable<Pagina, Div> includes()
        {
            CMSContext banco = new CMSContext();
            var include = banco.Pagina
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

   public class CMSContext : DbContext
    {
        
        public DbSet<Story> Story { get; set; }
        public DbSet<BackgroundGradiente> BackgroundGradiente { get; set; }
        public DbSet<Cadastro> Cadastro { get; set; }
        public DbSet<DadoFormulario> DadoFormulario { get; set; }
        public DbSet<Dropdown> Dropdown { get; set; }
        public DbSet<PaginaCarouselPagina> PaginaCarouselPagina { get; set; }
        public DbSet<CarouselPagina> CarouselPagina { get; set; }
        public DbSet<DivElemento> DivElemento { get; set; }
        public DbSet<DivPagina> DivPagina { get; set; }
        public DbSet<ElementoDependenteElemento> ElementoDependenteElemento { get; set; }
        public DbSet<Cor> Cor { get; set; }
        public DbSet<ContaBancaria> ContaBancaria { get; set; }
        public DbSet<InfoEntrega> InfoEntrega { get; set; }
        public DbSet<InfoVenda> InfoVenda { get; set; }
        public DbSet<Telefone> Telefone { get; set; }
        public DbSet<Imagem> Imagem { get; set; }
        public DbSet<Pagina> Pagina { get; set; }
        public DbSet<Div> Div { get; set; }
        public DbSet<Texto> Texto { get; set; }
        public DbSet<Background> Background { get; set; }
        public DbSet<Video> Video { get; set; }
        public DbSet<Elemento> Elemento { get; set; }
        public DbSet<ElementoDependente> ElementoDependente { get; set; }
        public DbSet<Campo> Campo { get; set; }
        public DbSet<Formulario> Form { get; set; }
        public DbSet<ItemRequisicao> ItemRequisicao { get; set; }
        public DbSet<Requisicao> Requisicao { get; set; }
        public DbSet<Table> Table { get; set; }
        public DbSet<Permissao> Permissao { get; set; }
        public DbSet<MensagemChat> MensagemChat { get; set; }
        public DbSet<PastaImagem> PastaImagem { get; set; }

        public DbSet<Acessorio> Acessorio { get; set; }

        public DbSet<Alimenticio> Alimenticio { get; set; }

        public DbSet<Calcado> Calcado { get; set; }

        public DbSet<Roupa> Roupa { get; set; }

        public DbSet<LinkBody> LinkBody { get; set; }

        public DbSet<CarouselImg> CarouselImg { get; set; }

        public DbSet<Show> Show { get; set; }

        public DbSet<DivComum> DivComum { get; set; }

        public DbSet<DivFixo> DivFixo { get; set; }

        public DbSet<BackgroundImagem> BackgroundImagem { get; set; }

        public DbSet<BackgroundCor> BackgroundCor { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ElementoDependenteElemento>()
            .HasKey(p => new { p.ElementoDependenteId, p.ElementoId });
            
            builder.Entity<PaginaCarouselPagina>()
            .HasKey(p => new { p.ElementoId, p.PaginaId });
            
            builder.Entity<DivPagina>()
            .HasKey(p => new { p.DivId, p.PaginaId });
            
            builder.Entity<DivElemento>()
            .HasKey(p => new { p.DivId, p.ElementoId });

            builder.Entity<Elemento>().ToTable("Elemento");
            builder.Entity<ElementoDependente>().ToTable("ElementoDependente");
            builder.Entity<Div>().ToTable("Div");

            builder.Entity<Produto>().ToTable("Produto");

            builder.Entity<Background>().ToTable("Background");
            builder.Entity<BackgroundCor>().ToTable("BackgroundCor");
            builder.Entity<BackgroundImagem>().ToTable("BackgroundImagem");
            builder.Entity<BackgroundGradiente>().ToTable("BackgroundGradiente");

            builder.Entity<CarouselPagina>().ToTable("CarouselPagina");
            builder.Entity<CarouselImg>().ToTable("CarouselImg");

            builder.Entity<Calcado>().ToTable("Calcado");
            builder.Entity<Roupa>().ToTable("Roupa");
            builder.Entity<Acessorio>().ToTable("Acessorio");
            builder.Entity<Alimenticio>().ToTable("Alimenticio");
            builder.Entity<Show>().ToTable("Show");

            builder.Entity<LinkBody>().ToTable("LinkBody");

            builder.Entity<DivFixo>().ToTable("DivFixo");
            builder.Entity<DivComum>().ToTable("DivComum");


            builder.Entity<Imagem>().ToTable("Imagem");

            builder.Entity<Texto>().ToTable("Texto");
            builder.Entity<Formulario>().ToTable("Formulario");
            builder.Entity<Table>().ToTable("Table");
            builder.Entity<Campo>().ToTable("Campo");
            builder.Entity<Video>().ToTable("Video");
            builder.Entity<Dropdown>().ToTable("Dropdown");
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Instagleo;");
        }
    }
}
