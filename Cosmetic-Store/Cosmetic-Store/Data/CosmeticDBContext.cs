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
              new Category { CategoryId= 1, Name = "Mascara" ,Description= "Mascara is a makeup product that aims to lengthen, enhance, and define eyelashes." },
              new Category { CategoryId = 2, Name = "Lipstick",Description= "Lipstick is makeup that makes your lips look darker, redder, or shinier." },
              new Category { CategoryId = 3, Name = "Powder",Description= "Face powder is a cosmetic product applied to the face to serve different functions, typically to beautify the face." },
              new Category { CategoryId = 4, Name = "Foundation", Description= "Foundation is a liquid, cream, or powder makeup applied to the face and neck to create an even, uniform color to the complexion, cover flaws and, sometimes, to change the natural skin tone." }
            );
            modelBuilder.Entity<Product>().HasData(
              new Product { ProductId = 1, Name = "Waterproof Mascara", Description = "Waterproof mascara is a form of mascara that doesn't get washed off with water easily.",Price= 7.5f },
              new Product { ProductId = 2, Name = "Volumizing Mascara", Description = "A tubular, volumizing mascara that forms a water-resistant, 360-degree coating around lashes, dries instantly and cannot smudge or smear.", Price = 8.5f },
              new Product { ProductId = 3, Name = "Glossy", Description = " A kind of paint that dries to a shiny finish.", Price = 3.5f },
              new Product { ProductId = 4, Name = "Lip Liner", Description = "Lip liner, also known as a lip pencil, is a cosmetic product. It is intended to fill in uneven areas on the outer edges of the lips before applying lipstick to give a smoother shape.", Price = 5.0f }
            );
            modelBuilder.Entity<ProductCategory>().HasData(
              new ProductCategory { Id = 1,CategoryId=1,ProductId=1},
              new ProductCategory { Id = 2, CategoryId = 1, ProductId = 2 },
              new ProductCategory { Id = 3, CategoryId = 2, ProductId = 3 },
              new ProductCategory { Id = 4, CategoryId = 2, ProductId = 4 }
            );
        }

    }
}
