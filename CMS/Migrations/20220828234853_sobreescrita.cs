using Microsoft.EntityFrameworkCore.Migrations;

namespace CMS.Migrations
{
    public partial class sobreescrita : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Sobreescrita",
                table: "Pagina",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sobreescrita",
                table: "Pagina");
        }
    }
}
