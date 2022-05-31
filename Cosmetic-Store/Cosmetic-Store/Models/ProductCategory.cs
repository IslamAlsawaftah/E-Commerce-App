namespace Cosmetic_Store.Models
{
    public class ProductCategory
    {
        public int Id { get; set; } 
        public int CategoryId { get; set; }
        public int ProductId { get; set; }

        // Navigation Properties
        public Product Product { get; set; }
        public Category Category { get; set; }
    }
}
