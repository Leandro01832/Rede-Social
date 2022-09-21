﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CMS.Migrations
{
    public partial class inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Capa = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Facebook = table.Column<string>(nullable: true),
                    Twitter = table.Column<string>(nullable: true),
                    Instagram = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Container",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ordem = table.Column<int>(nullable: false),
                    BorderRadius = table.Column<int>(nullable: false),
                    Height = table.Column<int>(nullable: false),
                    Padding = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Container", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DadoFormulario",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Formulario = table.Column<int>(nullable: false),
                    Campo = table.Column<int>(nullable: false),
                    Valor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DadoFormulario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Div",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ordem = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: false),
                    Padding = table.Column<int>(nullable: false),
                    Height = table.Column<int>(nullable: false),
                    BorderRadius = table.Column<int>(nullable: false),
                    Pagina_ = table.Column<long>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    EscolherPosicao = table.Column<bool>(nullable: true),
                    PosicaoFixacao = table.Column<int>(nullable: true),
                    InicioFixacao = table.Column<int>(nullable: true),
                    EixoYBlocoFixado = table.Column<int>(nullable: true),
                    EixoXBlocoFixado = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Div", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MensagemChat",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Pagina = table.Column<long>(nullable: false),
                    NomeUsuario = table.Column<string>(nullable: true),
                    Mensagem = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MensagemChat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PastaImagem",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PastaImagem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permissao",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomePermissao = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Solicitacao",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserIdSolicitando = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Solicitacao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Story",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    PaginaPadraoLink = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Story", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Telefone",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DDD_Celular = table.Column<string>(nullable: false),
                    Celular = table.Column<string>(nullable: false),
                    DDD_Telefone = table.Column<string>(nullable: true),
                    Fone = table.Column<string>(nullable: true),
                    ClienteId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefone", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Seguidor",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserIdSeguidor = table.Column<string>(nullable: true),
                    User = table.Column<string>(nullable: true),
                    UserModelId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seguidor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Seguidor_AspNetUsers_UserModelId",
                        column: x => x.UserModelId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Seguindo",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserIdSeguindo = table.Column<string>(nullable: true),
                    User = table.Column<string>(nullable: true),
                    UserModelId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seguindo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Seguindo_AspNetUsers_UserModelId",
                        column: x => x.UserModelId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DivContainer",
                columns: table => new
                {
                    ContainerId = table.Column<long>(nullable: false),
                    DivId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DivContainer", x => new { x.DivId, x.ContainerId });
                    table.ForeignKey(
                        name: "FK_DivContainer_Container_ContainerId",
                        column: x => x.ContainerId,
                        principalTable: "Container",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DivContainer_Div_DivId",
                        column: x => x.DivId,
                        principalTable: "Div",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Elemento",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PaginaEscolhida = table.Column<long>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Ordem = table.Column<int>(nullable: false),
                    Pagina_ = table.Column<long>(nullable: false),
                    TextoId = table.Column<long>(nullable: true),
                    ImagemId = table.Column<long>(nullable: true),
                    FormularioId = table.Column<long>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    Placeholder = table.Column<string>(nullable: true),
                    TipoCampo = table.Column<string>(nullable: true),
                    ArquivoVideo = table.Column<string>(nullable: true),
                    PalavrasTexto = table.Column<string>(nullable: true),
                    ArquivoImagem = table.Column<string>(nullable: true),
                    Width = table.Column<int>(nullable: true),
                    PastaImagemId = table.Column<long>(nullable: true),
                    TextoLink = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Elemento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Elemento_Elemento_FormularioId",
                        column: x => x.FormularioId,
                        principalTable: "Elemento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Elemento_Elemento_ImagemId",
                        column: x => x.ImagemId,
                        principalTable: "Elemento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Elemento_Elemento_TextoId",
                        column: x => x.TextoId,
                        principalTable: "Elemento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Elemento_PastaImagem_PastaImagemId",
                        column: x => x.PastaImagemId,
                        principalTable: "PastaImagem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubStory",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    StoryId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubStory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubStory_Story_StoryId",
                        column: x => x.StoryId,
                        principalTable: "Story",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Background",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImagemId = table.Column<long>(nullable: true),
                    VideoId = table.Column<long>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    ContainerId = table.Column<long>(nullable: true),
                    DivId = table.Column<long>(nullable: true),
                    Cor = table.Column<string>(nullable: true),
                    backgroundTransparente = table.Column<bool>(nullable: true),
                    Grau = table.Column<int>(nullable: true),
                    Background_Repeat = table.Column<string>(nullable: true),
                    Background_Position = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Background", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Background_Elemento_ImagemId",
                        column: x => x.ImagemId,
                        principalTable: "Elemento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Background_Elemento_VideoId",
                        column: x => x.VideoId,
                        principalTable: "Elemento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Background_Container_ContainerId",
                        column: x => x.ContainerId,
                        principalTable: "Container",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Background_Div_DivId",
                        column: x => x.DivId,
                        principalTable: "Div",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DivElemento",
                columns: table => new
                {
                    ElementoId = table.Column<long>(nullable: false),
                    DivId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DivElemento", x => new { x.DivId, x.ElementoId });
                    table.ForeignKey(
                        name: "FK_DivElemento_Div_DivId",
                        column: x => x.DivId,
                        principalTable: "Div",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DivElemento_Elemento_ElementoId",
                        column: x => x.ElementoId,
                        principalTable: "Elemento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ElementoDependenteElemento",
                columns: table => new
                {
                    ElementoDependenteId = table.Column<long>(nullable: false),
                    ElementoId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElementoDependenteElemento", x => new { x.ElementoDependenteId, x.ElementoId });
                    table.ForeignKey(
                        name: "FK_ElementoDependenteElemento_Elemento_ElementoDependenteId",
                        column: x => x.ElementoDependenteId,
                        principalTable: "Elemento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ElementoDependenteElemento_Elemento_ElementoId",
                        column: x => x.ElementoId,
                        principalTable: "Elemento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Grupo",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    SubStoryId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grupo_SubStory_SubStoryId",
                        column: x => x.SubStoryId,
                        principalTable: "SubStory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cor",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CorBackground = table.Column<string>(nullable: true),
                    Position = table.Column<int>(nullable: false),
                    Transparencia = table.Column<double>(nullable: false),
                    BackgroundId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cor_Background_BackgroundId",
                        column: x => x.BackgroundId,
                        principalTable: "Background",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubGrupo",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    GrupoId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubGrupo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubGrupo_Grupo_GrupoId",
                        column: x => x.GrupoId,
                        principalTable: "Grupo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubSubGrupo",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    SubGrupoId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubSubGrupo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubSubGrupo_SubGrupo_SubGrupoId",
                        column: x => x.SubGrupoId,
                        principalTable: "SubGrupo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pagina",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Data = table.Column<DateTime>(nullable: false),
                    StoryId = table.Column<long>(nullable: false),
                    SubStoryId = table.Column<long>(nullable: true),
                    GrupoId = table.Column<long>(nullable: true),
                    SubGrupoId = table.Column<long>(nullable: true),
                    SubSubGrupoId = table.Column<long>(nullable: true),
                    Titulo = table.Column<string>(nullable: false),
                    Sobreescrita = table.Column<string>(nullable: true),
                    ArquivoMusic = table.Column<string>(nullable: true),
                    Music = table.Column<bool>(nullable: false),
                    Margem = table.Column<bool>(nullable: false),
                    Topo = table.Column<bool>(nullable: false),
                    Menu = table.Column<bool>(nullable: false),
                    Pular = table.Column<bool>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    Layout = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagina", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pagina_Grupo_GrupoId",
                        column: x => x.GrupoId,
                        principalTable: "Grupo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pagina_Story_StoryId",
                        column: x => x.StoryId,
                        principalTable: "Story",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pagina_SubGrupo_SubGrupoId",
                        column: x => x.SubGrupoId,
                        principalTable: "SubGrupo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pagina_SubStory_SubStoryId",
                        column: x => x.SubStoryId,
                        principalTable: "SubStory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pagina_SubSubGrupo_SubSubGrupoId",
                        column: x => x.SubSubGrupoId,
                        principalTable: "SubSubGrupo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PaginaCarouselPagina",
                columns: table => new
                {
                    ElementoId = table.Column<long>(nullable: false),
                    PaginaId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaginaCarouselPagina", x => new { x.ElementoId, x.PaginaId });
                    table.ForeignKey(
                        name: "FK_PaginaCarouselPagina_Elemento_ElementoId",
                        column: x => x.ElementoId,
                        principalTable: "Elemento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaginaCarouselPagina_Pagina_PaginaId",
                        column: x => x.PaginaId,
                        principalTable: "Pagina",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaginaContainer",
                columns: table => new
                {
                    ContainerId = table.Column<long>(nullable: false),
                    PaginaId = table.Column<long>(nullable: false),
                    Id = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaginaContainer", x => new { x.ContainerId, x.PaginaId });
                    table.UniqueConstraint("AK_PaginaContainer_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaginaContainer_Container_ContainerId",
                        column: x => x.ContainerId,
                        principalTable: "Container",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaginaContainer_Pagina_PaginaId",
                        column: x => x.PaginaId,
                        principalTable: "Pagina",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Background_ImagemId",
                table: "Background",
                column: "ImagemId");

            migrationBuilder.CreateIndex(
                name: "IX_Background_VideoId",
                table: "Background",
                column: "VideoId");

            migrationBuilder.CreateIndex(
                name: "IX_Background_ContainerId",
                table: "Background",
                column: "ContainerId",
                unique: true,
                filter: "[ContainerId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Background_DivId",
                table: "Background",
                column: "DivId",
                unique: true,
                filter: "[DivId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Cor_BackgroundId",
                table: "Cor",
                column: "BackgroundId");

            migrationBuilder.CreateIndex(
                name: "IX_DivContainer_ContainerId",
                table: "DivContainer",
                column: "ContainerId");

            migrationBuilder.CreateIndex(
                name: "IX_DivElemento_ElementoId",
                table: "DivElemento",
                column: "ElementoId");

            migrationBuilder.CreateIndex(
                name: "IX_Elemento_FormularioId",
                table: "Elemento",
                column: "FormularioId");

            migrationBuilder.CreateIndex(
                name: "IX_Elemento_ImagemId",
                table: "Elemento",
                column: "ImagemId");

            migrationBuilder.CreateIndex(
                name: "IX_Elemento_TextoId",
                table: "Elemento",
                column: "TextoId");

            migrationBuilder.CreateIndex(
                name: "IX_Elemento_PastaImagemId",
                table: "Elemento",
                column: "PastaImagemId");

            migrationBuilder.CreateIndex(
                name: "IX_ElementoDependenteElemento_ElementoId",
                table: "ElementoDependenteElemento",
                column: "ElementoId");

            migrationBuilder.CreateIndex(
                name: "IX_Grupo_SubStoryId",
                table: "Grupo",
                column: "SubStoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagina_GrupoId",
                table: "Pagina",
                column: "GrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagina_StoryId",
                table: "Pagina",
                column: "StoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagina_SubGrupoId",
                table: "Pagina",
                column: "SubGrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagina_SubStoryId",
                table: "Pagina",
                column: "SubStoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagina_SubSubGrupoId",
                table: "Pagina",
                column: "SubSubGrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_PaginaCarouselPagina_PaginaId",
                table: "PaginaCarouselPagina",
                column: "PaginaId");

            migrationBuilder.CreateIndex(
                name: "IX_PaginaContainer_PaginaId",
                table: "PaginaContainer",
                column: "PaginaId");

            migrationBuilder.CreateIndex(
                name: "IX_Seguidor_UserModelId",
                table: "Seguidor",
                column: "UserModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Seguindo_UserModelId",
                table: "Seguindo",
                column: "UserModelId");

            migrationBuilder.CreateIndex(
                name: "IX_SubGrupo_GrupoId",
                table: "SubGrupo",
                column: "GrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_SubStory_StoryId",
                table: "SubStory",
                column: "StoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SubSubGrupo_SubGrupoId",
                table: "SubSubGrupo",
                column: "SubGrupoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Cor");

            migrationBuilder.DropTable(
                name: "DadoFormulario");

            migrationBuilder.DropTable(
                name: "DivContainer");

            migrationBuilder.DropTable(
                name: "DivElemento");

            migrationBuilder.DropTable(
                name: "ElementoDependenteElemento");

            migrationBuilder.DropTable(
                name: "MensagemChat");

            migrationBuilder.DropTable(
                name: "PaginaCarouselPagina");

            migrationBuilder.DropTable(
                name: "PaginaContainer");

            migrationBuilder.DropTable(
                name: "Permissao");

            migrationBuilder.DropTable(
                name: "Seguidor");

            migrationBuilder.DropTable(
                name: "Seguindo");

            migrationBuilder.DropTable(
                name: "Solicitacao");

            migrationBuilder.DropTable(
                name: "Telefone");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Background");

            migrationBuilder.DropTable(
                name: "Pagina");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Elemento");

            migrationBuilder.DropTable(
                name: "Container");

            migrationBuilder.DropTable(
                name: "Div");

            migrationBuilder.DropTable(
                name: "SubSubGrupo");

            migrationBuilder.DropTable(
                name: "PastaImagem");

            migrationBuilder.DropTable(
                name: "SubGrupo");

            migrationBuilder.DropTable(
                name: "Grupo");

            migrationBuilder.DropTable(
                name: "SubStory");

            migrationBuilder.DropTable(
                name: "Story");
        }
    }
}
