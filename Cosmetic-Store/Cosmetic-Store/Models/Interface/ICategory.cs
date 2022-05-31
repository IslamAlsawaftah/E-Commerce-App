using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cosmetic_Store.Models.Interface
{
    public interface ICategory
    {
        public Task<Category> Create (Category category);
        public Task<Category> GetCategoryById(int id);
        public Task<List<Category>> GetCategories();
        public Task<Category> Update (int id , Category category);
        public Task Delete (int id);
        public Task AddProduct(int categoryId, int croductId);
        public Task RemoveProduct(int categoryId, int productId);
    }
}
