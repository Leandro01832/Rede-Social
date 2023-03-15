using Microsoft.EntityFrameworkCore.Migrations;

namespace CMS.Migrations
{
    public partial class ImagemContent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagemContent",
                table: "Pagina",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagemContent",
                table: "Pagina");
        }
    }
}
