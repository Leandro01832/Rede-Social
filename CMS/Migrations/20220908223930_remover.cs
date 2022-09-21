using Microsoft.EntityFrameworkCore.Migrations;

namespace CMS.Migrations
{
    public partial class remover : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_PaginaContainer_Id",
                table: "PaginaContainer");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PaginaContainer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "Id",
                table: "PaginaContainer",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_PaginaContainer_Id",
                table: "PaginaContainer",
                column: "Id");
        }
    }
}
