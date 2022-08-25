using Microsoft.EntityFrameworkCore.Migrations;

namespace CMS.Migrations
{
    public partial class capa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Capa",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Capa",
                table: "AspNetUsers");
        }
    }
}
