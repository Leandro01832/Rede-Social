using Microsoft.EntityFrameworkCore.Migrations;

namespace CMS.Migrations
{
    public partial class props : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Produto",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ListaGrupo",
                table: "Pagina",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "ListaGrupo",
                table: "Pagina");
        }
    }
}
