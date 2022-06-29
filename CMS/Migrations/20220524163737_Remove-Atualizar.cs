using Microsoft.EntityFrameworkCore.Migrations;

namespace CMS.Migrations
{
    public partial class RemoveAtualizar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Atualizar",
                table: "AspNetUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Atualizar",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);
        }
    }
}
