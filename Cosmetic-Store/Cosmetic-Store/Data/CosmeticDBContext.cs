using Cosmetic_Store.Models;
using Microsoft.EntityFrameworkCore;

namespace Cosmetic_Store.Data
{
    public class CosmeticDBContext : DbContext
    {
        public DbSet<ProductCategory> ProductCatedories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public CosmeticDBContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<ProductCategory>().HasKey (x => new{ x.CategoryId, x.ProductId });

            // This calls the base method, but does nothing
            // base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
              new Category { CategoryId = 1, Name = "Mascara" ,Description= "Mascara is a makeup product that aims to lengthen, enhance, and define eyelashes.",Logo= "/images/Mascara/Mascara.PNG" },
              new Category { CategoryId = 2, Name = "Lipstick",Description= "Lipstick is makeup that makes your lips look darker, redder, or shinier.", Logo = "/images/Lipstick/Lipstick.PNG" },
              new Category { CategoryId = 3, Name = "Powder",Description= "Face powder is a cosmetic product applied to the face to serve different functions, typically to beautify the face.", Logo = "/images/Powder/Powder.PNG" },
              new Category { CategoryId = 4, Name = "Foundation", Description= "Foundation is a liquid, cream, or powder makeup applied to the face and neck to create an even, uniform color to the complexion, cover flaws and, sometimes, to change the natural skin tone.", Logo = "/images/Foundation/Foundation.PNG" }
            );
            modelBuilder.Entity<Product>().HasData(
              new Product { ProductId = 1, Name = "Essence Mascara", Description = "Volumizing, defining | Washable | Conic nylon brush with full, soft bristles.", Price= 5.0f,ImageURL= "/images/Mascara/Essence.PNG" },
              new Product { ProductId = 2, Name = "Maybelline Mascara", Description = "Defining, lengthening | Washable and waterproof versions | Skinny, low-profile brush with sparse, short bristles.", Price = 9.5f, ImageURL = "/images/Mascara/Maybelline.PNG" },
              new Product { ProductId = 3, Name = "Glossier Mascara", Description = "Lengthening, lifting | Water-resistant | Tapered silicone brush with tiered bristles", Price = 16.0f, ImageURL = "/images/Mascara/Glossier.PNG" },

              new Product { ProductId = 4, Name = "MegaLastLiquid Lipstick", Description = "What glides on like butter, feels like a second skin and wont budge? Our Liquid Catsuit Matte Lipstick! Made with glammed out superpowers, it goes on glossy yet transforms into a high - pigmented matte finish with some serious staying power. Read our lips This color is going nowhere.", Price = 4.0f, ImageURL = "/images/Lipstick/MegaLastLiquid.PNG" },
              new Product { ProductId = 5, Name = "Maybelline Lipstick", Description = "This cult-classic lipstick is the perfect combination of high-impact color in a super-moisturizing formula.", Price = 5.0f, ImageURL = "/images/Lipstick/Maybelline.PNG" },
              new Product { ProductId = 6, Name = "Satin Lipstick", Description = "Satin lipstick gives a sheen like a cream lipstick but with the boldness of a matte.", Price = 3.0f, ImageURL = "/images/Lipstick/Satin.PNG" },

              new Product { ProductId = 7, Name = "ELF Powder", Description = "Volumizing, defining | Washable | Conic nylon brush with full, soft bristles.", Price= 7.0f,ImageURL= "/images/Powder/ELF.PNG" },
              new Product { ProductId = 8, Name = "FitMe Powder", Description = "Volumizing, defining | Washable | Conic nylon brush with full, soft bristles.", Price = 10.0f, ImageURL = "/images/Powder/FitMe.PNG" },
              new Product { ProductId = 9, Name = "StayMatte Powder", Description = "Volumizing, defining | Washable | Conic nylon brush with full, soft bristles.", Price = 15.0f, ImageURL = "/images/Powder/StayMatte.PNG" },

              new Product { ProductId = 10, Name = "Maybelline Foundation", Description = "Up To 30 Hour Wear |Full Coverage Foundation | Light As Air Feel |Transfer Resistant |Seamless Matte Finish |Oil Free", Price = 20.0f, ImageURL = " /images/Foundation/Maybelline.PNG" },
              new Product { ProductId = 11, Name = "LOreal Foundation", Description = "Achieve a matte finish that won’t fall flat with this air-light, longwearing liquid formula. Lightweight and creamy, foundation goes on smooth with a demi-matte finish that lasts up to 24 hours—hiding imperfections for a smooth, clear complexion.", Price = 13.0f, ImageURL = "/images/Foundation/LOreal.PNG" },
              new Product { ProductId = 12, Name = "Missha Foundation", Description = "This M Perfect Cover BB Cream makes your skin tone clean and chic by concealing blemishes with excellent skin coverage it is a multi functional makeup cream with blocking UV rays, whitening and wrinkle care effects and simplifies makeup formalities its moisturized application with W/S texture makes sleek skin tone while supplying moisture and nutrition at the same time.", Price = 8.0f, ImageURL = "/images/Foundation/Missha.PNG" }

            );
            modelBuilder.Entity<ProductCategory>().HasData(
              new ProductCategory { Id = 1, CategoryId = 1, ProductId = 1},
              new ProductCategory { Id = 2, CategoryId = 1, ProductId = 2 },
              new ProductCategory { Id = 3, CategoryId = 1, ProductId = 3 },

              new ProductCategory { Id = 4, CategoryId = 2, ProductId = 4 },
              new ProductCategory { Id = 5, CategoryId = 2, ProductId = 5 },
              new ProductCategory { Id = 6, CategoryId = 2, ProductId = 6 },

              new ProductCategory { Id = 7, CategoryId = 3, ProductId = 7 },
              new ProductCategory { Id = 8, CategoryId = 3, ProductId = 8 },
              new ProductCategory { Id = 9, CategoryId = 3, ProductId = 9 },

              new ProductCategory { Id = 10, CategoryId = 4, ProductId = 10 },
              new ProductCategory { Id = 11, CategoryId = 4, ProductId = 11 },
              new ProductCategory { Id = 12, CategoryId = 4, ProductId = 12 }


            );
        }

    }
}
