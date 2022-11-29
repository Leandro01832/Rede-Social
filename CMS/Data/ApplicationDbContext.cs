using business.Back;
using business.business;
using business.business.Group;
using business.business.carousel;
using business.business.element;
using business.business.Elementos;
using business.business.Elementos.element;
using business.business.Elementos.imagem;
using business.business.Elementos.texto;
using business.business.link;
using business.div;
using business.Join;
using CMS.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using business.business.div;

namespace CMS.Data
{
    public class ApplicationDbContext : IdentityDbContext<UserModel>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Produto> Produto { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<PaginaProduto> PaginaProduto { get; set; }
        public DbSet<ItemPedido> ItemPedido { get; set; }
        public DbSet<SubSubGrupo> SubSubGrupo { get; set; }
        public DbSet<SubGrupo> SubGrupo { get; set; }
        public DbSet<Grupo> Grupo { get; set; }
        public DbSet<SubStory> SubStory { get; set; }
        public DbSet<Solicitacao> Solicitacao { get; set; }
        public DbSet<Seguindo> Seguindo { get; set; }
        public DbSet<Seguidor> Seguidor { get; set; }
        public DbSet<Story> Story { get; set; }
        public DbSet<BackgroundGradiente> BackgroundGradiente { get; set; }
        public DbSet<BackgroundDiv> BackgroundDiv { get; set; }
        public DbSet<BackgroundElemento> BackgroundElemento { get; set; }
        public DbSet<BackgroundContainer> BackgroundContainer { get; set; }
        public DbSet<DadoFormulario> DadoFormulario { get; set; }
        public DbSet<PaginaCarouselPagina> PaginaCarouselPagina { get; set; }
        public DbSet<CarouselPagina> CarouselPagina { get; set; }
        public DbSet<DivElemento> DivElemento { get; set; }
        public DbSet<PaginaContainer> PaginaContainer { get; set; }
        public DbSet<ElementoDependenteElemento> ElementoDependenteElemento { get; set; }
        public DbSet<Cor> Cor { get; set; }
        public DbSet<Telefone> Telefone { get; set; }
        public DbSet<Imagem> Imagem { get; set; }
        public DbSet<Pagina> Pagina { get; set; }
        public DbSet<Div> Div { get; set; }
        public DbSet<Container> Container { get; set; }
        public DbSet<Texto> Texto { get; set; }
        public DbSet<Video> Video { get; set; }
        public DbSet<Elemento> Elemento { get; set; }
        public DbSet<ElementoDependente> ElementoDependente { get; set; }
        public DbSet<Campo> Campo { get; set; }
        public DbSet<Formulario> Form { get; set; }
        public DbSet<Permissao> Permissao { get; set; }
        public DbSet<MensagemChat> MensagemChat { get; set; }
        public DbSet<PastaImagem> PastaImagem { get; set; }


        public object Configuration { get; internal set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ElementoDependenteElemento>()
            .HasKey(p => new { p.ElementoDependenteId, p.ElementoId });
            
            builder.Entity<PaginaCarouselPagina>()
            .HasKey(p => new { p.ElementoId, p.PaginaId });
            
            builder.Entity<PaginaContainer>()
            .HasKey(p => new { p.ContainerId, p.PaginaId });
            
            builder.Entity<DivElemento>()
            .HasKey(p => new { p.DivId, p.ElementoId });
            
            builder.Entity<DivContainer>()
            .HasKey(p => new { p.DivId, p.ContainerId });

            builder.Entity<PaginaProduto>()
            .HasKey(p => new { p.PaginaId, p.ProdutoId });
            
            builder.Entity<Elemento>().ToTable("Elemento");
            builder.Entity<ElementoDependente>().ToTable("ElementoDependente");
            builder.Entity<Div>().ToTable("Div");

            builder.Entity<BackgroundCor>().ToTable("BackgroundCor");
            builder.Entity<BackgroundImagem>().ToTable("BackgroundImagem");
            builder.Entity<BackgroundGradiente>().ToTable("BackgroundGradiente");

            builder.Entity<CarouselPagina>().ToTable("CarouselPagina");
            builder.Entity<CarouselImg>().ToTable("CarouselImg");

            builder.Entity<LinkBody>().ToTable("LinkBody");

            builder.Entity<DivFixo>().ToTable("DivFixo");
            builder.Entity<DivComum>().ToTable("DivComum");
            

            builder.Entity<Imagem>().ToTable("Imagem");

            builder.Entity<Texto>().ToTable("Texto");
            builder.Entity<Formulario>().ToTable("Formulario");
            builder.Entity<Campo>().ToTable("Campo");
            builder.Entity<Video>().ToTable("Video");

           // var converter = new ValueConverter<Int64, Int64>(
           //v => v,
           //v => (Int64)v,
           //new ConverterMappingHints(valueGeneratorFactory: (p, t) => new TemporaryIntValueGenerator()));

           // builder.Entity<BaseModel>()
           //     .Property("Id")
           //     .ValueGeneratedOnAdd()
           //     .UseSqlServerIdentityColumn()
           //     .HasConversion(converter);

        }

                     
        public DbSet<LinkBody> LinkBody { get; set; }
                     
        public DbSet<CarouselImg> CarouselImg { get; set; }                     
                     
        public DbSet<DivComum> DivComum { get; set; }
                     
        public DbSet<DivFixo> DivFixo { get; set; }

        public DbSet<DivContainer> DivContainer { get; set; }

        public DbSet<BackgroundImagem> BackgroundImagem { get; set; }
                     
        public DbSet<BackgroundCor> BackgroundCor { get; set; }
                     
        public DbSet<business.Back.BackgroundCorContainer> BackgroundCorContainer { get; set; }
                     
        public DbSet<business.Back.BackgroundImagemContainer> BackgroundImagemContainer { get; set; }
                     
        public DbSet<business.Back.BackgroundGradienteContainer> BackgroundGradienteContainer { get; set; }

        public DbSet<business.Back.BackgroundCorElemento> BackgroundCorElemento { get; set; }
                     
        public DbSet<business.Back.BackgroundImagemElemento> BackgroundImagemElemento { get; set; }
                     
        public DbSet<business.Back.BackgroundGradienteElemento> BackgroundGradienteElemento { get; set; }
    }
}
