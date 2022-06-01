using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cosmetic_Store.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }

        // Navigation Properties
        public List<ProductCategory> ProductCatedories { get; set; }
    }
}
