using Microsoft.EntityFrameworkCore.Migrations;

namespace CMS.Migrations
{
    public partial class dados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImagemProduto_Produto_ProdutoId1",
                table: "ImagemProduto");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemPedido_Pedido_PedidoId1",
                table: "ItemPedido");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemPedido_Produto_ProdutoId1",
                table: "ItemPedido");

            migrationBuilder.DropIndex(
                name: "IX_ItemPedido_PedidoId1",
                table: "ItemPedido");

            migrationBuilder.DropIndex(
                name: "IX_ItemPedido_ProdutoId1",
                table: "ItemPedido");

            migrationBuilder.DropIndex(
                name: "IX_ImagemProduto_ProdutoId1",
                table: "ImagemProduto");

            migrationBuilder.DropColumn(
                name: "PedidoId1",
                table: "ItemPedido");

            migrationBuilder.DropColumn(
                name: "ProdutoId1",
                table: "ItemPedido");

            migrationBuilder.DropColumn(
                name: "ProdutoId1",
                table: "ImagemProduto");

            migrationBuilder.AlterColumn<long>(
                name: "ProdutoId",
                table: "ItemPedido",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<long>(
                name: "PedidoId",
                table: "ItemPedido",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<long>(
                name: "ProdutoId",
                table: "ImagemProduto",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_ItemPedido_PedidoId",
                table: "ItemPedido",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemPedido_ProdutoId",
                table: "ItemPedido",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_ImagemProduto_ProdutoId",
                table: "ImagemProduto",
                column: "ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_ImagemProduto_Produto_ProdutoId",
                table: "ImagemProduto",
                column: "ProdutoId",
                principalTable: "Produto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemPedido_Pedido_PedidoId",
                table: "ItemPedido",
                column: "PedidoId",
                principalTable: "Pedido",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemPedido_Produto_ProdutoId",
                table: "ItemPedido",
                column: "ProdutoId",
                principalTable: "Produto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImagemProduto_Produto_ProdutoId",
                table: "ImagemProduto");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemPedido_Pedido_PedidoId",
                table: "ItemPedido");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemPedido_Produto_ProdutoId",
                table: "ItemPedido");

            migrationBuilder.DropIndex(
                name: "IX_ItemPedido_PedidoId",
                table: "ItemPedido");

            migrationBuilder.DropIndex(
                name: "IX_ItemPedido_ProdutoId",
                table: "ItemPedido");

            migrationBuilder.DropIndex(
                name: "IX_ImagemProduto_ProdutoId",
                table: "ImagemProduto");

            migrationBuilder.AlterColumn<int>(
                name: "ProdutoId",
                table: "ItemPedido",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<int>(
                name: "PedidoId",
                table: "ItemPedido",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AddColumn<long>(
                name: "PedidoId1",
                table: "ItemPedido",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ProdutoId1",
                table: "ItemPedido",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProdutoId",
                table: "ImagemProduto",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AddColumn<long>(
                name: "ProdutoId1",
                table: "ImagemProduto",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemPedido_PedidoId1",
                table: "ItemPedido",
                column: "PedidoId1");

            migrationBuilder.CreateIndex(
                name: "IX_ItemPedido_ProdutoId1",
                table: "ItemPedido",
                column: "ProdutoId1");

            migrationBuilder.CreateIndex(
                name: "IX_ImagemProduto_ProdutoId1",
                table: "ImagemProduto",
                column: "ProdutoId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ImagemProduto_Produto_ProdutoId1",
                table: "ImagemProduto",
                column: "ProdutoId1",
                principalTable: "Produto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemPedido_Pedido_PedidoId1",
                table: "ItemPedido",
                column: "PedidoId1",
                principalTable: "Pedido",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemPedido_Produto_ProdutoId1",
                table: "ItemPedido",
                column: "ProdutoId1",
                principalTable: "Produto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
