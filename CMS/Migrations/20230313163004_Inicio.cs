using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CMS.Migrations
{
    public partial class Inicio : Migration
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
                    Name = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Livro = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comentario",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdPagina = table.Column<long>(nullable: false),
                    Capitulo = table.Column<int>(nullable: false),
                    Verso = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comentario", x => x.Id);
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
                    Width = table.Column<int>(nullable: false),
                    FlexWrap = table.Column<string>(nullable: true),
                    JustifyContent = table.Column<string>(nullable: true),
                    FlexDirection = table.Column<string>(nullable: true),
                    AlignItems = table.Column<string>(nullable: true),
                    AlignSelf = table.Column<string>(nullable: true),
                    ClassesModificadoras = table.Column<string>(nullable: true),
                    Padding = table.Column<int>(nullable: false),
                    Content = table.Column<bool>(nullable: false)
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
                    Width = table.Column<int>(nullable: false),
                    Content = table.Column<bool>(nullable: false),
                    BorderRadius = table.Column<int>(nullable: false),
                    Pagina_ = table.Column<long>(nullable: false),
                    FlexWrap = table.Column<string>(nullable: true),
                    JustifyContent = table.Column<string>(nullable: true),
                    FlexDirection = table.Column<string>(nullable: true),
                    AlignItems = table.Column<string>(nullable: true),
                    AlignSelf = table.Column<string>(nullable: true),
                    ClassesModificadoras = table.Column<string>(nullable: true),
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
                name: "Livro",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livro", x => x.Id);
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
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PastaImagem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pedido",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClienteId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedido", x => x.Id);
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
                name: "Seguidor",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserIdSeguidor = table.Column<string>(nullable: true),
                    User = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seguidor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Seguindo",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserIdSeguindo = table.Column<string>(nullable: true),
                    User = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seguindo", x => x.Id);
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
                    Comentario = table.Column<bool>(nullable: false),
                    Inportado = table.Column<bool>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
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
                name: "VideoIncorporado",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Tamanho = table.Column<int>(nullable: true),
                    ArquivoVideoIncorporado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoIncorporado", x => x.Id);
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
                    AlignSelf = table.Column<string>(nullable: true),
                    Pagina_ = table.Column<long>(nullable: false),
                    TextoId = table.Column<long>(nullable: true),
                    ImagemId = table.Column<long>(nullable: true),
                    FormularioId = table.Column<long>(nullable: true),
                    ClassesModificadoras = table.Column<string>(nullable: true),
                    Width = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    Placeholder = table.Column<string>(nullable: true),
                    TipoCampo = table.Column<string>(nullable: true),
                    ArquivoVideo = table.Column<string>(nullable: true),
                    PalavrasTexto = table.Column<string>(nullable: true),
                    ArquivoImagem = table.Column<string>(nullable: true),
                    WidthImagem = table.Column<int>(nullable: true),
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
                name: "BackgroundContainer",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false),
                    ImagemId = table.Column<long>(nullable: true),
                    VideoId = table.Column<long>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    CorContainer = table.Column<string>(nullable: true),
                    backgroundTransparenteContainer = table.Column<bool>(nullable: true),
                    GrauContainer = table.Column<int>(nullable: true),
                    Background_RepeatContainer = table.Column<string>(nullable: true),
                    Background_PositionContainer = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BackgroundContainer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BackgroundContainer_Container_Id",
                        column: x => x.Id,
                        principalTable: "Container",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BackgroundContainer_Elemento_ImagemId",
                        column: x => x.ImagemId,
                        principalTable: "Elemento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BackgroundContainer_Elemento_VideoId",
                        column: x => x.VideoId,
                        principalTable: "Elemento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BackgroundDiv",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false),
                    ImagemId = table.Column<long>(nullable: true),
                    VideoId = table.Column<long>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    Cor = table.Column<string>(nullable: true),
                    backgroundTransparente = table.Column<bool>(nullable: true),
                    Grau = table.Column<int>(nullable: true),
                    Background_Repeat = table.Column<string>(nullable: true),
                    Background_Position = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BackgroundDiv", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BackgroundDiv_Div_Id",
                        column: x => x.Id,
                        principalTable: "Div",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BackgroundDiv_Elemento_ImagemId",
                        column: x => x.ImagemId,
                        principalTable: "Elemento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BackgroundDiv_Elemento_VideoId",
                        column: x => x.VideoId,
                        principalTable: "Elemento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BackgroundElemento",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false),
                    ImagemId = table.Column<long>(nullable: true),
                    VideoId = table.Column<long>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    CorElemento = table.Column<string>(nullable: true),
                    backgroundTransparenteElemento = table.Column<bool>(nullable: true),
                    GrauElemento = table.Column<int>(nullable: true),
                    Background_RepeatElemento = table.Column<string>(nullable: true),
                    Background_PositionElemento = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BackgroundElemento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BackgroundElemento_Elemento_Id",
                        column: x => x.Id,
                        principalTable: "Elemento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BackgroundElemento_Elemento_ImagemId",
                        column: x => x.ImagemId,
                        principalTable: "Elemento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BackgroundElemento_Elemento_VideoId",
                        column: x => x.VideoId,
                        principalTable: "Elemento",
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
                    BackgroundContainerId = table.Column<long>(nullable: true),
                    BackgroundDivId = table.Column<long>(nullable: true),
                    BackgroundElementoId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cor_BackgroundContainer_BackgroundContainerId",
                        column: x => x.BackgroundContainerId,
                        principalTable: "BackgroundContainer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cor_BackgroundDiv_BackgroundDivId",
                        column: x => x.BackgroundDivId,
                        principalTable: "BackgroundDiv",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cor_BackgroundElemento_BackgroundElementoId",
                        column: x => x.BackgroundElementoId,
                        principalTable: "BackgroundElemento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                name: "CamadaSeis",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    SubSubGrupoId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CamadaSeis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CamadaSeis_SubSubGrupo_SubSubGrupoId",
                        column: x => x.SubSubGrupoId,
                        principalTable: "SubSubGrupo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CamadaSete",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    CamadaSeisId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CamadaSete", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CamadaSete_CamadaSeis_CamadaSeisId",
                        column: x => x.CamadaSeisId,
                        principalTable: "CamadaSeis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CamadaOito",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    CamadaSeteId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CamadaOito", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CamadaOito_CamadaSete_CamadaSeteId",
                        column: x => x.CamadaSeteId,
                        principalTable: "CamadaSete",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CamadaNove",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    CamadaOitoId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CamadaNove", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CamadaNove_CamadaOito_CamadaOitoId",
                        column: x => x.CamadaOitoId,
                        principalTable: "CamadaOito",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CamadaDez",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    CamadaNoveId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CamadaDez", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CamadaDez_CamadaNove_CamadaNoveId",
                        column: x => x.CamadaNoveId,
                        principalTable: "CamadaNove",
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
                    CamadaSeisId = table.Column<long>(nullable: true),
                    CamadaSeteId = table.Column<long>(nullable: true),
                    CamadaOitoId = table.Column<long>(nullable: true),
                    CamadaNoveId = table.Column<long>(nullable: true),
                    CamadaDezId = table.Column<long>(nullable: true),
                    Titulo = table.Column<string>(nullable: false),
                    Sobreescrita = table.Column<string>(nullable: true),
                    ArquivoMusic = table.Column<string>(nullable: true),
                    Music = table.Column<bool>(nullable: false),
                    Comentario = table.Column<long>(nullable: true),
                    Layout = table.Column<bool>(nullable: false),
                    FlexDirection = table.Column<string>(nullable: true),
                    AlignItems = table.Column<string>(nullable: true),
                    Tempo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagina", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pagina_CamadaDez_CamadaDezId",
                        column: x => x.CamadaDezId,
                        principalTable: "CamadaDez",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pagina_CamadaNove_CamadaNoveId",
                        column: x => x.CamadaNoveId,
                        principalTable: "CamadaNove",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pagina_CamadaOito_CamadaOitoId",
                        column: x => x.CamadaOitoId,
                        principalTable: "CamadaOito",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pagina_CamadaSeis_CamadaSeisId",
                        column: x => x.CamadaSeisId,
                        principalTable: "CamadaSeis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pagina_CamadaSete_CamadaSeteId",
                        column: x => x.CamadaSeteId,
                        principalTable: "CamadaSete",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    PaginaId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaginaContainer", x => new { x.ContainerId, x.PaginaId });
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

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false),
                    Descricao = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Preco = table.Column<decimal>(nullable: false),
                    QuantEstoque = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produto_Pagina_Id",
                        column: x => x.Id,
                        principalTable: "Pagina",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ImagemProduto",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProdutoId = table.Column<long>(nullable: false),
                    ArquivoImagem = table.Column<string>(nullable: true),
                    WidthImagem = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagemProduto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImagemProduto_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemPedido",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Quantidade = table.Column<int>(nullable: false),
                    ProdutoId = table.Column<long>(nullable: false),
                    PedidoId = table.Column<long>(nullable: false),
                    PrecoUnitario = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemPedido", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemPedido_Pedido_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedido",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemPedido_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
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
                name: "IX_BackgroundContainer_ImagemId",
                table: "BackgroundContainer",
                column: "ImagemId");

            migrationBuilder.CreateIndex(
                name: "IX_BackgroundContainer_VideoId",
                table: "BackgroundContainer",
                column: "VideoId");

            migrationBuilder.CreateIndex(
                name: "IX_BackgroundDiv_ImagemId",
                table: "BackgroundDiv",
                column: "ImagemId");

            migrationBuilder.CreateIndex(
                name: "IX_BackgroundDiv_VideoId",
                table: "BackgroundDiv",
                column: "VideoId");

            migrationBuilder.CreateIndex(
                name: "IX_BackgroundElemento_ImagemId",
                table: "BackgroundElemento",
                column: "ImagemId");

            migrationBuilder.CreateIndex(
                name: "IX_BackgroundElemento_VideoId",
                table: "BackgroundElemento",
                column: "VideoId");

            migrationBuilder.CreateIndex(
                name: "IX_CamadaDez_CamadaNoveId",
                table: "CamadaDez",
                column: "CamadaNoveId");

            migrationBuilder.CreateIndex(
                name: "IX_CamadaNove_CamadaOitoId",
                table: "CamadaNove",
                column: "CamadaOitoId");

            migrationBuilder.CreateIndex(
                name: "IX_CamadaOito_CamadaSeteId",
                table: "CamadaOito",
                column: "CamadaSeteId");

            migrationBuilder.CreateIndex(
                name: "IX_CamadaSeis_SubSubGrupoId",
                table: "CamadaSeis",
                column: "SubSubGrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_CamadaSete_CamadaSeisId",
                table: "CamadaSete",
                column: "CamadaSeisId");

            migrationBuilder.CreateIndex(
                name: "IX_Cor_BackgroundContainerId",
                table: "Cor",
                column: "BackgroundContainerId");

            migrationBuilder.CreateIndex(
                name: "IX_Cor_BackgroundDivId",
                table: "Cor",
                column: "BackgroundDivId");

            migrationBuilder.CreateIndex(
                name: "IX_Cor_BackgroundElementoId",
                table: "Cor",
                column: "BackgroundElementoId");

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
                name: "IX_ImagemProduto_ProdutoId",
                table: "ImagemProduto",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemPedido_PedidoId",
                table: "ItemPedido",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemPedido_ProdutoId",
                table: "ItemPedido",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagina_CamadaDezId",
                table: "Pagina",
                column: "CamadaDezId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagina_CamadaNoveId",
                table: "Pagina",
                column: "CamadaNoveId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagina_CamadaOitoId",
                table: "Pagina",
                column: "CamadaOitoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagina_CamadaSeisId",
                table: "Pagina",
                column: "CamadaSeisId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagina_CamadaSeteId",
                table: "Pagina",
                column: "CamadaSeteId");

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
                name: "Comentario");

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
                name: "ImagemProduto");

            migrationBuilder.DropTable(
                name: "ItemPedido");

            migrationBuilder.DropTable(
                name: "Livro");

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
                name: "VideoIncorporado");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "BackgroundContainer");

            migrationBuilder.DropTable(
                name: "BackgroundDiv");

            migrationBuilder.DropTable(
                name: "BackgroundElemento");

            migrationBuilder.DropTable(
                name: "Pedido");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Container");

            migrationBuilder.DropTable(
                name: "Div");

            migrationBuilder.DropTable(
                name: "Elemento");

            migrationBuilder.DropTable(
                name: "Pagina");

            migrationBuilder.DropTable(
                name: "PastaImagem");

            migrationBuilder.DropTable(
                name: "CamadaDez");

            migrationBuilder.DropTable(
                name: "CamadaNove");

            migrationBuilder.DropTable(
                name: "CamadaOito");

            migrationBuilder.DropTable(
                name: "CamadaSete");

            migrationBuilder.DropTable(
                name: "CamadaSeis");

            migrationBuilder.DropTable(
                name: "SubSubGrupo");

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
