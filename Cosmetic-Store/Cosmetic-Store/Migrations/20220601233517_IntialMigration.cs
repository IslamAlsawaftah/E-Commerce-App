using Microsoft.EntityFrameworkCore.Migrations;

namespace Cosmetic_Store.Migrations
{
    public partial class IntialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "ProductCatedories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCatedories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductCatedories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCatedories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Description", "Logo", "Name" },
                values: new object[,]
                {
                    { 1, "Mascara is a makeup product that aims to lengthen, enhance, and define eyelashes.", "/images/Mascara/Mascara.PNG", "Mascara" },
                    { 2, "Lipstick is makeup that makes your lips look darker, redder, or shinier.", "/images/Lipstick/Lipstick.PNG", "Lipstick" },
                    { 3, "Face powder is a cosmetic product applied to the face to serve different functions, typically to beautify the face.", "/images/Powder/Powder.PNG", "Powder" },
                    { 4, "Foundation is a liquid, cream, or powder makeup applied to the face and neck to create an even, uniform color to the complexion, cover flaws and, sometimes, to change the natural skin tone.", "/images/Foundation/Foundation.PNG", "Foundation" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "ImageURL", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Volumizing, defining | Washable | Conic nylon brush with full, soft bristles.", "/images/Mascara/Essence.PNG", "Essence Mascara", 5f },
                    { 2, "Defining, lengthening | Washable and waterproof versions | Skinny, low-profile brush with sparse, short bristles.", "/images/Mascara/Maybelline.PNG", "Maybelline Mascara", 9.5f },
                    { 3, "Lengthening, lifting | Water-resistant | Tapered silicone brush with tiered bristles", "/images/Mascara/Glossier.PNG", "Glossier Mascara", 16f },
                    { 4, "What glides on like butter, feels like a second skin and wont budge? Our Liquid Catsuit Matte Lipstick! Made with glammed out superpowers, it goes on glossy yet transforms into a high - pigmented matte finish with some serious staying power. Read our lips This color is going nowhere.", "/images/Lipstick/MegaLastLiquid.PNG", "MegaLastLiquid Lipstick", 4f },
                    { 5, "This cult-classic lipstick is the perfect combination of high-impact color in a super-moisturizing formula.", "/images/Lipstick/Maybelline.PNG", "Maybelline Lipstick", 5f },
                    { 6, "Satin lipstick gives a sheen like a cream lipstick but with the boldness of a matte.", "/images/Lipstick/Satin.PNG", "Satin Lipstick", 3f },
                    { 7, "Volumizing, defining | Washable | Conic nylon brush with full, soft bristles.", "/images/Powder/ELF.PNG", "ELF Powder", 7f },
                    { 8, "Volumizing, defining | Washable | Conic nylon brush with full, soft bristles.", "/images/Powder/FitMe.PNG", "FitMe Powder", 10f },
                    { 9, "Volumizing, defining | Washable | Conic nylon brush with full, soft bristles.", "/images/Powder/StayMatte.PNG", "StayMatte Powder", 15f },
                    { 10, "Up To 30 Hour Wear |Full Coverage Foundation | Light As Air Feel |Transfer Resistant |Seamless Matte Finish |Oil Free", " /images/Foundation/Maybelline.PNG", "Maybelline Foundation", 20f },
                    { 11, "Achieve a matte finish that won’t fall flat with this air-light, longwearing liquid formula. Lightweight and creamy, foundation goes on smooth with a demi-matte finish that lasts up to 24 hours—hiding imperfections for a smooth, clear complexion.", "/images/Foundation/LOreal.PNG", "LOreal Foundation", 13f },
                    { 12, "This M Perfect Cover BB Cream makes your skin tone clean and chic by concealing blemishes with excellent skin coverage it is a multi functional makeup cream with blocking UV rays, whitening and wrinkle care effects and simplifies makeup formalities its moisturized application with W/S texture makes sleek skin tone while supplying moisture and nutrition at the same time.", "/images/Foundation/Missha.PNG", "Missha Foundation", 8f }
                });

            migrationBuilder.InsertData(
                table: "ProductCatedories",
                columns: new[] { "Id", "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 1, 3 },
                    { 4, 2, 4 },
                    { 5, 2, 5 },
                    { 6, 2, 6 },
                    { 7, 3, 7 },
                    { 8, 3, 8 },
                    { 9, 3, 9 },
                    { 10, 4, 10 },
                    { 11, 4, 11 },
                    { 12, 4, 12 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductCatedories_CategoryId",
                table: "ProductCatedories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCatedories_ProductId",
                table: "ProductCatedories",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductCatedories");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
