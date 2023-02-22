using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CMS.Migrations
{
    public partial class camadas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CamadaDezId",
                table: "Pagina",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CamadaNoveId",
                table: "Pagina",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CamadaOitoId",
                table: "Pagina",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CamadaSeisId",
                table: "Pagina",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CamadaSeteId",
                table: "Pagina",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CamadaSeis",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    SubSubGrupoId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CamadaSeis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CamadaSeis_SubSubGrupo_SubSubGrupoId",
                        column: x => x.SubSubGrupoId,
                        principalTable: "SubSubGrupo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CamadaSete",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    CamadaSeisId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CamadaSete", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CamadaSete_CamadaSeis_CamadaSeisId",
                        column: x => x.CamadaSeisId,
                        principalTable: "CamadaSeis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CamadaOito",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    CamadaSeteId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CamadaOito", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CamadaOito_CamadaSete_CamadaSeteId",
                        column: x => x.CamadaSeteId,
                        principalTable: "CamadaSete",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CamadaNove",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    CamadaOitoId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CamadaNove", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CamadaNove_CamadaOito_CamadaOitoId",
                        column: x => x.CamadaOitoId,
                        principalTable: "CamadaOito",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CamadaDez",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    CamadaNoveId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CamadaDez", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CamadaDez_CamadaNove_CamadaNoveId",
                        column: x => x.CamadaNoveId,
                        principalTable: "CamadaNove",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pagina_CamadaDezId",
                table: "Pagina",
                column: "CamadaDezId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagina_CamadaNoveId",
                table: "Pagina",
                column: "CamadaNoveId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagina_CamadaOitoId",
                table: "Pagina",
                column: "CamadaOitoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagina_CamadaSeisId",
                table: "Pagina",
                column: "CamadaSeisId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagina_CamadaSeteId",
                table: "Pagina",
                column: "CamadaSeteId");

            migrationBuilder.CreateIndex(
                name: "IX_CamadaDez_CamadaNoveId",
                table: "CamadaDez",
                column: "CamadaNoveId");

            migrationBuilder.CreateIndex(
                name: "IX_CamadaNove_CamadaOitoId",
                table: "CamadaNove",
                column: "CamadaOitoId");

            migrationBuilder.CreateIndex(
                name: "IX_CamadaOito_CamadaSeteId",
                table: "CamadaOito",
                column: "CamadaSeteId");

            migrationBuilder.CreateIndex(
                name: "IX_CamadaSeis_SubSubGrupoId",
                table: "CamadaSeis",
                column: "SubSubGrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_CamadaSete_CamadaSeisId",
                table: "CamadaSete",
                column: "CamadaSeisId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagina_CamadaDez_CamadaDezId",
                table: "Pagina",
                column: "CamadaDezId",
                principalTable: "CamadaDez",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagina_CamadaNove_CamadaNoveId",
                table: "Pagina",
                column: "CamadaNoveId",
                principalTable: "CamadaNove",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagina_CamadaOito_CamadaOitoId",
                table: "Pagina",
                column: "CamadaOitoId",
                principalTable: "CamadaOito",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagina_CamadaSeis_CamadaSeisId",
                table: "Pagina",
                column: "CamadaSeisId",
                principalTable: "CamadaSeis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagina_CamadaSete_CamadaSeteId",
                table: "Pagina",
                column: "CamadaSeteId",
                principalTable: "CamadaSete",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagina_CamadaDez_CamadaDezId",
                table: "Pagina");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagina_CamadaNove_CamadaNoveId",
                table: "Pagina");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagina_CamadaOito_CamadaOitoId",
                table: "Pagina");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagina_CamadaSeis_CamadaSeisId",
                table: "Pagina");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagina_CamadaSete_CamadaSeteId",
                table: "Pagina");

            migrationBuilder.DropTable(
                name: "CamadaDez");

            migrationBuilder.DropTable(
                name: "CamadaNove");

            migrationBuilder.DropTable(
                name: "CamadaOito");

            migrationBuilder.DropTable(
                name: "CamadaSete");

            migrationBuilder.DropTable(
                name: "CamadaSeis");

            migrationBuilder.DropIndex(
                name: "IX_Pagina_CamadaDezId",
                table: "Pagina");

            migrationBuilder.DropIndex(
                name: "IX_Pagina_CamadaNoveId",
                table: "Pagina");

            migrationBuilder.DropIndex(
                name: "IX_Pagina_CamadaOitoId",
                table: "Pagina");

            migrationBuilder.DropIndex(
                name: "IX_Pagina_CamadaSeisId",
                table: "Pagina");

            migrationBuilder.DropIndex(
                name: "IX_Pagina_CamadaSeteId",
                table: "Pagina");

            migrationBuilder.DropColumn(
                name: "CamadaDezId",
                table: "Pagina");

            migrationBuilder.DropColumn(
                name: "CamadaNoveId",
                table: "Pagina");

            migrationBuilder.DropColumn(
                name: "CamadaOitoId",
                table: "Pagina");

            migrationBuilder.DropColumn(
                name: "CamadaSeisId",
                table: "Pagina");

            migrationBuilder.DropColumn(
                name: "CamadaSeteId",
                table: "Pagina");
        }
    }
}
