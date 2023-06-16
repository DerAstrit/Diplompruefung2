using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace spicker.Migrations
{
    /// <inheritdoc />
    public partial class DBErstellung2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Feundschaft_Probanden_ProbandID",
                table: "Feundschaft");

            migrationBuilder.DropForeignKey(
                name: "FK_Probanden_Pate_PateId",
                table: "Probanden");

            migrationBuilder.DropIndex(
                name: "IX_Probanden_PateId",
                table: "Probanden");

            migrationBuilder.AlterColumn<int>(
                name: "PateId",
                table: "Probanden",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Probanden_PateId",
                table: "Probanden",
                column: "PateId",
                unique: true,
                filter: "[PateId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Feundschaft_Probanden_ProbandID",
                table: "Feundschaft",
                column: "ProbandID",
                principalTable: "Probanden",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Probanden_Pate_PateId",
                table: "Probanden",
                column: "PateId",
                principalTable: "Pate",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Feundschaft_Probanden_ProbandID",
                table: "Feundschaft");

            migrationBuilder.DropForeignKey(
                name: "FK_Probanden_Pate_PateId",
                table: "Probanden");

            migrationBuilder.DropIndex(
                name: "IX_Probanden_PateId",
                table: "Probanden");

            migrationBuilder.AlterColumn<int>(
                name: "PateId",
                table: "Probanden",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Probanden_PateId",
                table: "Probanden",
                column: "PateId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Feundschaft_Probanden_ProbandID",
                table: "Feundschaft",
                column: "ProbandID",
                principalTable: "Probanden",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Probanden_Pate_PateId",
                table: "Probanden",
                column: "PateId",
                principalTable: "Pate",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
