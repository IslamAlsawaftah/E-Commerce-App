using Microsoft.EntityFrameworkCore.Migrations;

namespace Cosmetic_Store.Migrations
{
    public partial class AddDataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Products",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Categories",
                newName: "CategoryId");

            migrationBuilder.AlterColumn<float>(
                name: "Price",
                table: "Products",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Description", "Logo", "Name" },
                values: new object[,]
                {
                    { 1, "Mascara is a makeup product that aims to lengthen, enhance, and define eyelashes.", null, "Mascara" },
                    { 2, "Lipstick is makeup that makes your lips look darker, redder, or shinier.", null, "Lipstick" },
                    { 3, "Face powder is a cosmetic product applied to the face to serve different functions, typically to beautify the face.", null, "Powder" },
                    { 4, "Foundation is a liquid, cream, or powder makeup applied to the face and neck to create an even, uniform color to the complexion, cover flaws and, sometimes, to change the natural skin tone.", null, "Foundation" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "ImageURL", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Waterproof mascara is a form of mascara that doesn't get washed off with water easily.", null, "Waterproof Mascara", 7.5f },
                    { 2, "A tubular, volumizing mascara that forms a water-resistant, 360-degree coating around lashes, dries instantly and cannot smudge or smear.", null, "Volumizing Mascara", 8.5f },
                    { 3, " A kind of paint that dries to a shiny finish.", null, "Glossy", 3.5f },
                    { 4, "Lip liner, also known as a lip pencil, is a cosmetic product. It is intended to fill in uneven areas on the outer edges of the lips before applying lipstick to give a smoother shape.", null, "Lip Liner", 5f }
                });

            migrationBuilder.InsertData(
                table: "ProductCatedories",
                columns: new[] { "Id", "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 2, 3 },
                    { 4, 2, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductCatedories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductCatedories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductCatedories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductCatedories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Products",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Categories",
                newName: "Id");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }
    }
}
