using System.Collections.Generic;

namespace Cosmetic_Store.Models
{
    public class Category
    {
        public int CategoryId { get; set; } 
        public string Name { get; set; }
        public string Logo { get; set; }
        public string Description { get; set; }

        // Navigation Properties
        public List<ProductCategory> ProductCategories { get; set; }

    }
}
