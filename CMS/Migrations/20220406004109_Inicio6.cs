using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CMS.Migrations
{
    public partial class Inicio6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Seguindo",
                newName: "UserIdSeguindo");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Seguidor",
                newName: "UserIdSeguidor");

            migrationBuilder.CreateTable(
                name: "Solicitacao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserIdSolicitando = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Solicitacao", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Solicitacao");

            migrationBuilder.RenameColumn(
                name: "UserIdSeguindo",
                table: "Seguindo",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "UserIdSeguidor",
                table: "Seguidor",
                newName: "UserId");
        }
    }
}
