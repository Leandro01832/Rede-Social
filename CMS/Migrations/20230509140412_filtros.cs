using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CMS.Migrations
{
    public partial class filtros : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Filtro",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StoryId = table.Column<int>(nullable: false),
                    StoryId1 = table.Column<long>(nullable: true),
                    SubStory = table.Column<long>(nullable: true),
                    Grupo = table.Column<long>(nullable: true),
                    SubGrupo = table.Column<long>(nullable: true),
                    SubSubGrupo = table.Column<long>(nullable: true),
                    CamadaSeis = table.Column<long>(nullable: true),
                    CamadaSete = table.Column<long>(nullable: true),
                    CamadaOito = table.Column<long>(nullable: true),
                    CamadaNove = table.Column<long>(nullable: true),
                    CamadaDez = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filtro", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Filtro_Story_StoryId1",
                        column: x => x.StoryId1,
                        principalTable: "Story",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Filtro_StoryId1",
                table: "Filtro",
                column: "StoryId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Filtro");
        }
    }
}
