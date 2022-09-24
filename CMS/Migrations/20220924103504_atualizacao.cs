using Microsoft.EntityFrameworkCore.Migrations;

namespace CMS.Migrations
{
    public partial class atualizacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CorElemento",
                table: "BackgroundElemento",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "backgroundTransparenteElemento",
                table: "BackgroundElemento",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "BackgroundElemento",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "GrauElemento",
                table: "BackgroundElemento",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Background_PositionElemento",
                table: "BackgroundElemento",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Background_RepeatElemento",
                table: "BackgroundElemento",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CorElemento",
                table: "BackgroundElemento");

            migrationBuilder.DropColumn(
                name: "backgroundTransparenteElemento",
                table: "BackgroundElemento");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "BackgroundElemento");

            migrationBuilder.DropColumn(
                name: "GrauElemento",
                table: "BackgroundElemento");

            migrationBuilder.DropColumn(
                name: "Background_PositionElemento",
                table: "BackgroundElemento");

            migrationBuilder.DropColumn(
                name: "Background_RepeatElemento",
                table: "BackgroundElemento");
        }
    }
}
