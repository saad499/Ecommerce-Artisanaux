using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Artisanaux.Services.ProductAPI.Migrations
{
    public partial class remplissageBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "IdProduct", "CategoryName", "ImageURL", "Price", "ProductName" },
                values: new object[,]
                {
                    { 1, "category1", "https://artisanans.blob.core.windows.net/artisanans/1.jpg", 15.0, "ChaiseBoisMassive" },
                    { 2, "category1", "https://artisanans.blob.core.windows.net/artisanans/1.jpg", 15.0, "Chaise" },
                    { 3, "category1", "https://artisanans.blob.core.windows.net/artisanans/1.jpg", 15.0, "Bois" },
                    { 4, "category1", "https://artisanans.blob.core.windows.net/artisanans/1.jpg", 15.0, "Massive" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "IdProduct",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "IdProduct",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "IdProduct",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "IdProduct",
                keyValue: 4);
        }
    }
}
