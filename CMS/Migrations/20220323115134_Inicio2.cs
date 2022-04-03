using Microsoft.EntityFrameworkCore.Migrations;

namespace CMS.Migrations
{
    public partial class Inicio2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagina_AspNetUsers_UserId",
                table: "Pagina");

            migrationBuilder.DropIndex(
                name: "IX_Pagina_UserId",
                table: "Pagina");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Story",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Pagina",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModelId",
                table: "Pagina",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pagina_UserModelId",
                table: "Pagina",
                column: "UserModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagina_AspNetUsers_UserModelId",
                table: "Pagina",
                column: "UserModelId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagina_AspNetUsers_UserModelId",
                table: "Pagina");

            migrationBuilder.DropIndex(
                name: "IX_Pagina_UserModelId",
                table: "Pagina");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Story");

            migrationBuilder.DropColumn(
                name: "UserModelId",
                table: "Pagina");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Pagina",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pagina_UserId",
                table: "Pagina",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagina_AspNetUsers_UserId",
                table: "Pagina",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
