using Microsoft.EntityFrameworkCore.Migrations;

namespace SegundoParcial.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "llamadas",
                columns: table => new
                {
                    LlamadaId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_llamadas", x => x.LlamadaId);
                });

            migrationBuilder.CreateTable(
                name: "llamadasDetalle",
                columns: table => new
                {
                    DetalleId = table.Column<int>(nullable: false),
                    LlamadaId = table.Column<int>(nullable: false),
                    Problema = table.Column<string>(nullable: false),
                    Solucion = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_llamadasDetalle", x => x.DetalleId);
                    table.ForeignKey(
                        name: "FK_llamadasDetalle_llamadas_DetalleId",
                        column: x => x.DetalleId,
                        principalTable: "llamadas",
                        principalColumn: "LlamadaId",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "llamadasDetalle");

            migrationBuilder.DropTable(
                name: "llamadas");
        }
    }
}
