using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CMS.Migrations
{
    public partial class removeecommerce : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Elemento_Elemento_TableId",
                table: "Elemento");

            migrationBuilder.DropTable(
                name: "ContaBancaria");

            migrationBuilder.DropTable(
                name: "InfoEntrega");

            migrationBuilder.DropTable(
                name: "InfoVenda");

            migrationBuilder.DropTable(
                name: "ItemRequisicao");

            migrationBuilder.DropTable(
                name: "Requisicao");

            migrationBuilder.DropTable(
                name: "Cadastro");

            migrationBuilder.DropIndex(
                name: "IX_Elemento_TableId",
                table: "Elemento");

            migrationBuilder.DropColumn(
                name: "EstiloTabela",
                table: "Elemento");

            migrationBuilder.DropColumn(
                name: "TableId",
                table: "Elemento");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Elemento");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Elemento");

            migrationBuilder.DropColumn(
                name: "Preco",
                table: "Elemento");

            migrationBuilder.DropColumn(
                name: "Segmento",
                table: "Elemento");

            migrationBuilder.DropColumn(
                name: "estoque",
                table: "Elemento");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EstiloTabela",
                table: "Elemento",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "TableId",
                table: "Elemento",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Codigo",
                table: "Elemento",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Elemento",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Preco",
                table: "Elemento",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Segmento",
                table: "Elemento",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "estoque",
                table: "Elemento",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Cadastro",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Bairro = table.Column<string>(nullable: false),
                    CEP = table.Column<string>(nullable: false),
                    Complemento = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Endereco = table.Column<string>(nullable: false),
                    Municipio = table.Column<string>(nullable: false),
                    Nome = table.Column<string>(maxLength: 50, nullable: false),
                    Telefone = table.Column<string>(nullable: false),
                    UF = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cadastro", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContaBancaria",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Agencia = table.Column<string>(nullable: true),
                    ClienteId = table.Column<string>(nullable: false),
                    CodigoBanco = table.Column<string>(nullable: false),
                    Conta = table.Column<string>(nullable: true),
                    DVAgencia = table.Column<string>(nullable: true),
                    DVConta = table.Column<string>(nullable: true),
                    TipoConta = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContaBancaria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InfoEntrega",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AlturaCaixa = table.Column<int>(nullable: true),
                    ClienteId = table.Column<string>(nullable: false),
                    ComprimentoCaixa = table.Column<int>(nullable: true),
                    LarguraCaixa = table.Column<int>(nullable: true),
                    PesoCaixa = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfoEntrega", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InfoVenda",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Bairro = table.Column<string>(nullable: false),
                    Cep = table.Column<string>(nullable: false),
                    Cidade = table.Column<string>(nullable: false),
                    ClienteId = table.Column<string>(nullable: false),
                    Cpf = table.Column<string>(nullable: false),
                    Estado = table.Column<string>(nullable: false),
                    Numero = table.Column<long>(nullable: false),
                    Rua = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfoVenda", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Requisicao",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false),
                    ClienteId = table.Column<string>(nullable: false),
                    DataPedidoCompra = table.Column<DateTime>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    ValorPedido = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requisicao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Requisicao_Cadastro_Id",
                        column: x => x.Id,
                        principalTable: "Cadastro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemRequisicao",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ElementoId = table.Column<long>(nullable: false),
                    PrecoUnitario = table.Column<long>(nullable: false),
                    ProdutoId = table.Column<long>(nullable: true),
                    Quantidade = table.Column<int>(nullable: false),
                    RequisicaoId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemRequisicao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemRequisicao_Elemento_ElementoId",
                        column: x => x.ElementoId,
                        principalTable: "Elemento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemRequisicao_Elemento_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Elemento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemRequisicao_Requisicao_RequisicaoId",
                        column: x => x.RequisicaoId,
                        principalTable: "Requisicao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Elemento_TableId",
                table: "Elemento",
                column: "TableId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemRequisicao_ElementoId",
                table: "ItemRequisicao",
                column: "ElementoId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemRequisicao_ProdutoId",
                table: "ItemRequisicao",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemRequisicao_RequisicaoId",
                table: "ItemRequisicao",
                column: "RequisicaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Elemento_Elemento_TableId",
                table: "Elemento",
                column: "TableId",
                principalTable: "Elemento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
