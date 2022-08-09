using Microsoft.EntityFrameworkCore.Migrations;

namespace CMS.Migrations
{
    public partial class group_names : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "SubSubGrupo",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "SubStory",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "SubGrupo",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Grupo",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nome",
                table: "SubSubGrupo");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "SubStory");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "SubGrupo");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Grupo");
        }
    }
}
