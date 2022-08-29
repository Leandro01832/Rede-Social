﻿// <auto-generated />
using System;
using CMS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CMS.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220828234853_sobreescrita")]
    partial class sobreescrita
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CMS.Models.UserModel", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Capa");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("Facebook");

                    b.Property<string>("Image");

                    b.Property<string>("Instagram");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("Name");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("Twitter");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("business.Back.Background", b =>
                {
                    b.Property<long>("Id");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<long?>("ImagemId");

                    b.Property<long?>("VideoId");

                    b.HasKey("Id");

                    b.HasIndex("ImagemId");

                    b.HasIndex("VideoId");

                    b.ToTable("Background");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Background");
                });

            modelBuilder.Entity("business.Back.Cor", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("BackgroundId");

                    b.Property<string>("CorBackground");

                    b.Property<int>("Position");

                    b.Property<double>("Transparencia");

                    b.HasKey("Id");

                    b.HasIndex("BackgroundId");

                    b.ToTable("Cor");
                });

            modelBuilder.Entity("business.Join.DivElemento", b =>
                {
                    b.Property<long?>("DivId");

                    b.Property<long?>("ElementoId");

                    b.HasKey("DivId", "ElementoId");

                    b.HasIndex("ElementoId");

                    b.ToTable("DivElemento");
                });

            modelBuilder.Entity("business.Join.DivPagina", b =>
                {
                    b.Property<long?>("DivId");

                    b.Property<long?>("PaginaId");

                    b.HasKey("DivId", "PaginaId");

                    b.HasIndex("PaginaId");

                    b.ToTable("DivPagina");
                });

            modelBuilder.Entity("business.Join.PaginaCarouselPagina", b =>
                {
                    b.Property<long?>("ElementoId");

                    b.Property<long?>("PaginaId");

                    b.HasKey("ElementoId", "PaginaId");

                    b.HasIndex("PaginaId");

                    b.ToTable("PaginaCarouselPagina");
                });

            modelBuilder.Entity("business.business.DadoFormulario", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Campo");

                    b.Property<int>("Formulario");

                    b.Property<string>("Valor");

                    b.HasKey("Id");

                    b.ToTable("DadoFormulario");
                });

            modelBuilder.Entity("business.business.Elementos.element.Elemento", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<long?>("FormularioId");

                    b.Property<long?>("ImagemId");

                    b.Property<string>("Nome");

                    b.Property<int>("Ordem");

                    b.Property<long?>("PaginaEscolhida");

                    b.Property<long>("Pagina_");

                    b.Property<long?>("TextoId");

                    b.HasKey("Id");

                    b.HasIndex("FormularioId");

                    b.HasIndex("ImagemId");

                    b.HasIndex("TextoId");

                    b.ToTable("Elemento");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Elemento");
                });

            modelBuilder.Entity("business.business.Elementos.element.ElementoDependenteElemento", b =>
                {
                    b.Property<long?>("ElementoDependenteId");

                    b.Property<long?>("ElementoId");

                    b.HasKey("ElementoDependenteId", "ElementoId");

                    b.HasIndex("ElementoId");

                    b.ToTable("ElementoDependenteElemento");
                });

            modelBuilder.Entity("business.business.Group.Grupo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.Property<long>("SubStoryId");

                    b.HasKey("Id");

                    b.HasIndex("SubStoryId");

                    b.ToTable("Grupo");
                });

            modelBuilder.Entity("business.business.Group.Story", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.Property<int>("PaginaPadraoLink");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Story");
                });

            modelBuilder.Entity("business.business.Group.SubGrupo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("GrupoId");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.HasIndex("GrupoId");

                    b.ToTable("SubGrupo");
                });

            modelBuilder.Entity("business.business.Group.SubStory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.Property<long>("StoryId");

                    b.HasKey("Id");

                    b.HasIndex("StoryId");

                    b.ToTable("SubStory");
                });

            modelBuilder.Entity("business.business.Group.SubSubGrupo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.Property<long>("SubGrupoId");

                    b.HasKey("Id");

                    b.HasIndex("SubGrupoId");

                    b.ToTable("SubSubGrupo");
                });

            modelBuilder.Entity("business.business.MensagemChat", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Mensagem");

                    b.Property<string>("NomeUsuario");

                    b.Property<long>("Pagina");

                    b.HasKey("Id");

                    b.ToTable("MensagemChat");
                });

            modelBuilder.Entity("business.business.Pagina", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArquivoMusic");

                    b.Property<DateTime>("Data");

                    b.Property<long?>("GrupoId");

                    b.Property<bool>("Layout");

                    b.Property<bool>("Margem");

                    b.Property<bool>("Menu");

                    b.Property<bool>("Music");

                    b.Property<bool>("Pular");

                    b.Property<string>("Sobreescrita");

                    b.Property<long>("StoryId");

                    b.Property<long?>("SubGrupoId");

                    b.Property<long?>("SubStoryId");

                    b.Property<long?>("SubSubGrupoId");

                    b.Property<string>("Titulo")
                        .IsRequired();

                    b.Property<bool>("Topo");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("GrupoId");

                    b.HasIndex("StoryId");

                    b.HasIndex("SubGrupoId");

                    b.HasIndex("SubStoryId");

                    b.HasIndex("SubSubGrupoId");

                    b.ToTable("Pagina");
                });

            modelBuilder.Entity("business.business.PastaImagem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("PastaImagem");
                });

            modelBuilder.Entity("business.business.Permissao", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomePermissao");

                    b.Property<string>("UserId");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Permissao");
                });

            modelBuilder.Entity("business.business.Seguidor", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("User");

                    b.Property<string>("UserIdSeguidor");

                    b.Property<string>("UserModelId");

                    b.HasKey("Id");

                    b.HasIndex("UserModelId");

                    b.ToTable("Seguidor");
                });

            modelBuilder.Entity("business.business.Seguindo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("User");

                    b.Property<string>("UserIdSeguindo");

                    b.Property<string>("UserModelId");

                    b.HasKey("Id");

                    b.HasIndex("UserModelId");

                    b.ToTable("Seguindo");
                });

            modelBuilder.Entity("business.business.Solicitacao", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserId");

                    b.Property<string>("UserIdSolicitando");

                    b.HasKey("Id");

                    b.ToTable("Solicitacao");
                });

            modelBuilder.Entity("business.business.Telefone", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Celular")
                        .IsRequired();

                    b.Property<string>("ClienteId")
                        .IsRequired();

                    b.Property<string>("DDD_Celular")
                        .IsRequired();

                    b.Property<string>("DDD_Telefone");

                    b.Property<string>("Fone");

                    b.HasKey("Id");

                    b.ToTable("Telefone");
                });

            modelBuilder.Entity("business.div.Div", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BorderRadius");

                    b.Property<string>("Colunas");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Divisao");

                    b.Property<int>("Height");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<int>("Ordem");

                    b.Property<int>("Padding");

                    b.Property<long>("Pagina_");

                    b.HasKey("Id");

                    b.ToTable("Div");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Div");
                });

            modelBuilder.Entity("business.Back.BackgroundCor", b =>
                {
                    b.HasBaseType("business.Back.Background");

                    b.Property<string>("Cor");

                    b.Property<bool>("backgroundTransparente");

                    b.ToTable("BackgroundCor");

                    b.HasDiscriminator().HasValue("BackgroundCor");
                });

            modelBuilder.Entity("business.Back.BackgroundGradiente", b =>
                {
                    b.HasBaseType("business.Back.Background");

                    b.Property<int>("Grau");

                    b.ToTable("BackgroundGradiente");

                    b.HasDiscriminator().HasValue("BackgroundGradiente");
                });

            modelBuilder.Entity("business.Back.BackgroundImagem", b =>
                {
                    b.HasBaseType("business.Back.Background");

                    b.Property<string>("Background_Position");

                    b.Property<string>("Background_Repeat");

                    b.ToTable("BackgroundImagem");

                    b.HasDiscriminator().HasValue("BackgroundImagem");
                });

            modelBuilder.Entity("business.business.Elementos.Campo", b =>
                {
                    b.HasBaseType("business.business.Elementos.element.Elemento");

                    b.Property<string>("Placeholder");

                    b.Property<string>("TipoCampo");

                    b.ToTable("Campo");

                    b.HasDiscriminator().HasValue("Campo");
                });

            modelBuilder.Entity("business.business.Elementos.Dropdown", b =>
                {
                    b.HasBaseType("business.business.Elementos.element.Elemento");

                    b.ToTable("Dropdown");

                    b.HasDiscriminator().HasValue("Dropdown");
                });

            modelBuilder.Entity("business.business.Elementos.Formulario", b =>
                {
                    b.HasBaseType("business.business.Elementos.element.Elemento");

                    b.ToTable("Formulario");

                    b.HasDiscriminator().HasValue("Formulario");
                });

            modelBuilder.Entity("business.business.Elementos.Video", b =>
                {
                    b.HasBaseType("business.business.Elementos.element.Elemento");

                    b.Property<string>("ArquivoVideo");

                    b.ToTable("Video");

                    b.HasDiscriminator().HasValue("Video");
                });

            modelBuilder.Entity("business.business.Elementos.texto.Texto", b =>
                {
                    b.HasBaseType("business.business.Elementos.element.Elemento");

                    b.Property<string>("PalavrasTexto");

                    b.ToTable("Texto");

                    b.HasDiscriminator().HasValue("Texto");
                });

            modelBuilder.Entity("business.business.carousel.CarouselImg", b =>
                {
                    b.HasBaseType("business.business.Elementos.element.Elemento");

                    b.ToTable("CarouselImg");

                    b.HasDiscriminator().HasValue("CarouselImg");
                });

            modelBuilder.Entity("business.business.carousel.CarouselPagina", b =>
                {
                    b.HasBaseType("business.business.Elementos.element.Elemento");

                    b.ToTable("CarouselPagina");

                    b.HasDiscriminator().HasValue("CarouselPagina");
                });

            modelBuilder.Entity("business.business.element.ElementoDependente", b =>
                {
                    b.HasBaseType("business.business.Elementos.element.Elemento");

                    b.ToTable("ElementoDependente");

                    b.HasDiscriminator().HasValue("ElementoDependente");
                });

            modelBuilder.Entity("business.business.link.LinkBody", b =>
                {
                    b.HasBaseType("business.business.Elementos.element.Elemento");

                    b.Property<string>("TextoLink");

                    b.ToTable("LinkBody");

                    b.HasDiscriminator().HasValue("LinkBody");
                });

            modelBuilder.Entity("business.div.DivComum", b =>
                {
                    b.HasBaseType("business.div.Div");

                    b.ToTable("DivComum");

                    b.HasDiscriminator().HasValue("DivComum");
                });

            modelBuilder.Entity("business.div.DivFixo", b =>
                {
                    b.HasBaseType("business.div.Div");

                    b.Property<int>("EixoXBlocoFixado");

                    b.Property<int>("EixoYBlocoFixado");

                    b.Property<bool>("EscolherPosicao");

                    b.Property<int>("InicioFixacao");

                    b.Property<int>("PosicaoFixacao");

                    b.ToTable("DivFixo");

                    b.HasDiscriminator().HasValue("DivFixo");
                });

            modelBuilder.Entity("business.business.Elementos.imagem.Imagem", b =>
                {
                    b.HasBaseType("business.business.element.ElementoDependente");

                    b.Property<string>("ArquivoImagem");

                    b.Property<long?>("PastaImagemId");

                    b.Property<int>("Width");

                    b.HasIndex("PastaImagemId");

                    b.ToTable("Imagem");

                    b.HasDiscriminator().HasValue("Imagem");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("CMS.Models.UserModel")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CMS.Models.UserModel")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CMS.Models.UserModel")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("CMS.Models.UserModel")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("business.Back.Background", b =>
                {
                    b.HasOne("business.div.Div", "Div")
                        .WithOne("Background")
                        .HasForeignKey("business.Back.Background", "Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("business.business.Elementos.imagem.Imagem", "Imagem")
                        .WithMany("Background")
                        .HasForeignKey("ImagemId");

                    b.HasOne("business.business.Elementos.Video", "Video")
                        .WithMany("Background")
                        .HasForeignKey("VideoId");
                });

            modelBuilder.Entity("business.Back.Cor", b =>
                {
                    b.HasOne("business.Back.Background", "Background")
                        .WithMany("Cores")
                        .HasForeignKey("BackgroundId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("business.Join.DivElemento", b =>
                {
                    b.HasOne("business.div.Div", "Div")
                        .WithMany("Elemento")
                        .HasForeignKey("DivId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("business.business.Elementos.element.Elemento", "Elemento")
                        .WithMany("div")
                        .HasForeignKey("ElementoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("business.Join.DivPagina", b =>
                {
                    b.HasOne("business.div.Div", "Div")
                        .WithMany("Pagina")
                        .HasForeignKey("DivId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("business.business.Pagina", "Pagina")
                        .WithMany("Div")
                        .HasForeignKey("PaginaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("business.Join.PaginaCarouselPagina", b =>
                {
                    b.HasOne("business.business.Elementos.element.Elemento", "Elemento")
                        .WithMany("Paginas")
                        .HasForeignKey("ElementoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("business.business.Pagina", "Pagina")
                        .WithMany("CarouselPagina")
                        .HasForeignKey("PaginaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("business.business.Elementos.element.Elemento", b =>
                {
                    b.HasOne("business.business.Elementos.Formulario", "Formulario")
                        .WithMany("Elemento")
                        .HasForeignKey("FormularioId");

                    b.HasOne("business.business.Elementos.imagem.Imagem", "Imagem")
                        .WithMany("Elemento")
                        .HasForeignKey("ImagemId");

                    b.HasOne("business.business.Elementos.texto.Texto", "Texto")
                        .WithMany("Elemento")
                        .HasForeignKey("TextoId");
                });

            modelBuilder.Entity("business.business.Elementos.element.ElementoDependenteElemento", b =>
                {
                    b.HasOne("business.business.element.ElementoDependente", "ElementoDependente")
                        .WithMany()
                        .HasForeignKey("ElementoDependenteId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("business.business.Elementos.element.Elemento", "Elemento")
                        .WithMany("Dependentes")
                        .HasForeignKey("ElementoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("business.business.Group.Grupo", b =>
                {
                    b.HasOne("business.business.Group.SubStory", "SubStory")
                        .WithMany("Grupo")
                        .HasForeignKey("SubStoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("business.business.Group.SubGrupo", b =>
                {
                    b.HasOne("business.business.Group.Grupo", "Grupo")
                        .WithMany("SubGrupo")
                        .HasForeignKey("GrupoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("business.business.Group.SubStory", b =>
                {
                    b.HasOne("business.business.Group.Story", "Story")
                        .WithMany("SubStory")
                        .HasForeignKey("StoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("business.business.Group.SubSubGrupo", b =>
                {
                    b.HasOne("business.business.Group.SubGrupo", "SubGrupo")
                        .WithMany("SubSubGrupo")
                        .HasForeignKey("SubGrupoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("business.business.Pagina", b =>
                {
                    b.HasOne("business.business.Group.Grupo", "Grupo")
                        .WithMany("Pagina")
                        .HasForeignKey("GrupoId");

                    b.HasOne("business.business.Group.Story", "Story")
                        .WithMany("Pagina")
                        .HasForeignKey("StoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("business.business.Group.SubGrupo", "SubGrupo")
                        .WithMany("Pagina")
                        .HasForeignKey("SubGrupoId");

                    b.HasOne("business.business.Group.SubStory", "SubStory")
                        .WithMany("Pagina")
                        .HasForeignKey("SubStoryId");

                    b.HasOne("business.business.Group.SubSubGrupo", "SubSubGrupo")
                        .WithMany("Pagina")
                        .HasForeignKey("SubSubGrupoId");
                });

            modelBuilder.Entity("business.business.Seguidor", b =>
                {
                    b.HasOne("CMS.Models.UserModel")
                        .WithMany("Seguidores")
                        .HasForeignKey("UserModelId");
                });

            modelBuilder.Entity("business.business.Seguindo", b =>
                {
                    b.HasOne("CMS.Models.UserModel")
                        .WithMany("Seguindo")
                        .HasForeignKey("UserModelId");
                });

            modelBuilder.Entity("business.business.Elementos.imagem.Imagem", b =>
                {
                    b.HasOne("business.business.PastaImagem", "PastaImagem")
                        .WithMany("Imagens")
                        .HasForeignKey("PastaImagemId");
                });
#pragma warning restore 612, 618
        }
    }
}
