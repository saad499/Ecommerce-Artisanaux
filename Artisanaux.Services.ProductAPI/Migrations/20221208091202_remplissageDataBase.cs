using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Artisanaux.Services.ProductAPI.Migrations
{
    public partial class remplissageDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "IdProduct",
                keyValue: 2,
                column: "ImageURL",
                value: "https://artisanans.blob.core.windows.net/artisanans/2.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "IdProduct",
                keyValue: 3,
                column: "ImageURL",
                value: "https://artisanans.blob.core.windows.net/artisanans/3.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "IdProduct",
                keyValue: 4,
                column: "ImageURL",
                value: "https://artisanans.blob.core.windows.net/artisanans/4.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "IdProduct",
                keyValue: 2,
                column: "ImageURL",
                value: "https://artisanans.blob.core.windows.net/artisanans/1.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "IdProduct",
                keyValue: 3,
                column: "ImageURL",
                value: "https://artisanans.blob.core.windows.net/artisanans/1.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "IdProduct",
                keyValue: 4,
                column: "ImageURL",
                value: "https://artisanans.blob.core.windows.net/artisanans/1.jpg");
        }
    }
}
