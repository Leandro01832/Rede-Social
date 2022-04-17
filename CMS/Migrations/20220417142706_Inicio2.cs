using Microsoft.EntityFrameworkCore.Migrations;

namespace CMS.Migrations
{
    public partial class Inicio2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "VideoId",
                table: "Background",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Background_VideoId",
                table: "Background",
                column: "VideoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Background_Elemento_VideoId",
                table: "Background",
                column: "VideoId",
                principalTable: "Elemento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Background_Elemento_VideoId",
                table: "Background");

            migrationBuilder.DropIndex(
                name: "IX_Background_VideoId",
                table: "Background");

            migrationBuilder.DropColumn(
                name: "VideoId",
                table: "Background");
        }
    }
}
