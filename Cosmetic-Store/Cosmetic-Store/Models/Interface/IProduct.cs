using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cosmetic_Store.Models.Interface
{
    public interface IProduct
    {
        public Task<Product> Create(Product product);
        public Task<Product> GetProductById(int id);
        public Task<List<Product>> GetProducts();
        public Task<Product> Update(int id, Product product);
        public Task Delete(int id);
    }
}
