using Microsoft.EntityFrameworkCore.Migrations;

namespace BakeryTreat.Migrations
{
    public partial class InitialInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TreatFlavor_Categories_TreatId",
                table: "TreatFlavor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Treats");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Treats",
                table: "Treats",
                column: "TreatId");

            migrationBuilder.AddForeignKey(
                name: "FK_TreatFlavor_Treats_TreatId",
                table: "TreatFlavor",
                column: "TreatId",
                principalTable: "Treats",
                principalColumn: "TreatId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TreatFlavor_Treats_TreatId",
                table: "TreatFlavor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Treats",
                table: "Treats");

            migrationBuilder.RenameTable(
                name: "Treats",
                newName: "Categories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "TreatId");

            migrationBuilder.AddForeignKey(
                name: "FK_TreatFlavor_Categories_TreatId",
                table: "TreatFlavor",
                column: "TreatId",
                principalTable: "Categories",
                principalColumn: "TreatId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
