using Microsoft.EntityFrameworkCore.Migrations;

namespace CMS.Migrations
{
    public partial class renameproperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CorContainer",
                table: "Background",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "backgroundTransparenteContainer",
                table: "Background",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GrauContainer",
                table: "Background",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Background_PositionContainer",
                table: "Background",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Background_RepeatContainer",
                table: "Background",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CorContainer",
                table: "Background");

            migrationBuilder.DropColumn(
                name: "backgroundTransparenteContainer",
                table: "Background");

            migrationBuilder.DropColumn(
                name: "GrauContainer",
                table: "Background");

            migrationBuilder.DropColumn(
                name: "Background_PositionContainer",
                table: "Background");

            migrationBuilder.DropColumn(
                name: "Background_RepeatContainer",
                table: "Background");
        }
    }
}
