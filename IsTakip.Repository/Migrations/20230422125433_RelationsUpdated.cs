using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IsTakip.Repository.Migrations
{
    public partial class RelationsUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Musteriler_MusteriKisitlamalar_MusteriKisitlamaId",
                table: "Musteriler");

            migrationBuilder.DropIndex(
                name: "IX_Musteriler_MusteriKisitlamaId",
                table: "Musteriler");

            migrationBuilder.DropColumn(
                name: "MusteriId",
                table: "MusteriTemsilciler");

            migrationBuilder.CreateIndex(
                name: "IX_MusteriKisitlamalar_MusteriId",
                table: "MusteriKisitlamalar",
                column: "MusteriId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MusteriKisitlamalar_Musteriler_MusteriId",
                table: "MusteriKisitlamalar",
                column: "MusteriId",
                principalTable: "Musteriler",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MusteriKisitlamalar_Musteriler_MusteriId",
                table: "MusteriKisitlamalar");

            migrationBuilder.DropIndex(
                name: "IX_MusteriKisitlamalar_MusteriId",
                table: "MusteriKisitlamalar");

            migrationBuilder.AddColumn<int>(
                name: "MusteriId",
                table: "MusteriTemsilciler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Musteriler_MusteriKisitlamaId",
                table: "Musteriler",
                column: "MusteriKisitlamaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Musteriler_MusteriKisitlamalar_MusteriKisitlamaId",
                table: "Musteriler",
                column: "MusteriKisitlamaId",
                principalTable: "MusteriKisitlamalar",
                principalColumn: "Id");
        }
    }
}
