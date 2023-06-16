using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace spicker.Migrations
{
    /// <inheritdoc />
    public partial class DBErstellung : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Freund",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vorname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nachname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Jahrgang = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Freund", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mutters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vorname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nachname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Jahrgang = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mutters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vorname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nachname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Jahrgang = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Probanden",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Geschlecht = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MutterID = table.Column<int>(type: "int", nullable: false),
                    PateId = table.Column<int>(type: "int", nullable: false),
                    Vorname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nachname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Jahrgang = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Probanden", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Probanden_Mutters_MutterID",
                        column: x => x.MutterID,
                        principalTable: "Mutters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Probanden_Pate_PateId",
                        column: x => x.PateId,
                        principalTable: "Pate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Feundschaft",
                columns: table => new
                {
                    ProbandID = table.Column<int>(type: "int", nullable: false),
                    FreundID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feundschaft", x => new { x.ProbandID, x.FreundID });
                    table.ForeignKey(
                        name: "FK_Feundschaft_Freund_FreundID",
                        column: x => x.FreundID,
                        principalTable: "Freund",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Feundschaft_Probanden_ProbandID",
                        column: x => x.ProbandID,
                        principalTable: "Probanden",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Feundschaft_FreundID",
                table: "Feundschaft",
                column: "FreundID");

            migrationBuilder.CreateIndex(
                name: "IX_Probanden_MutterID",
                table: "Probanden",
                column: "MutterID");

            migrationBuilder.CreateIndex(
                name: "IX_Probanden_PateId",
                table: "Probanden",
                column: "PateId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Feundschaft");

            migrationBuilder.DropTable(
                name: "Freund");

            migrationBuilder.DropTable(
                name: "Probanden");

            migrationBuilder.DropTable(
                name: "Mutters");

            migrationBuilder.DropTable(
                name: "Pate");
        }
    }
}
