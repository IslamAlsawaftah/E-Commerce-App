using Cosmetic_Store.Data;
using Cosmetic_Store.Models.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cosmetic_Store.Models.Services
{
    public class CategoryServices : ICategory
    {
        private CosmeticDBContext _context;

        public CategoryServices(CosmeticDBContext context)
        {
            _context = context;
        }
        //public async Task<List<Category>> GetCategories()
        //{
        //    return await _context.Categories.Select(x => new Category
        //    {
        //        CategoryId = x.CategoryId,
        //        Name = x.Name,
        //        Description = x.Description,
        //        Logo = x.Logo,
        //    }).ToListAsync();
        //}
        public async Task<List<Category>> GetCategories()
        {
            return await _context.Categories.Include(x => x.ProductCategories).ThenInclude(x => x.Product).ToListAsync();
        }

        //public async Task<Category> GetCategoryById(int id)
        //{
        //    return await _context.Categories.Select(x => new Category
        //    {
        //        CategoryId = x.CategoryId,
        //        Name = x.Name,
        //        Description = x.Description,
        //        Logo = x.Logo,
        //    }).FirstOrDefaultAsync(x=>x.CategoryId==id);
        //}

        public async Task<Category> GetCategoryById(int id)
        {
            return await _context.Categories.Include(x => x.ProductCategories).ThenInclude(x => x.Product).FirstOrDefaultAsync(x => x.CategoryId == id);
        }
        public async Task<Category> Create(Category category)
        {
            var newCategory = new Category
            {
                CategoryId = category.CategoryId,
                Name = category.Name,
                Description = category.Description
            };
            _context.Entry(newCategory).State= EntityState.Added;
            await _context.SaveChangesAsync();
            return newCategory;

        }

        public async Task Delete(int id)
        {
            Category category = await GetCategoryById(id);
            _context.Entry(category).State= EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

        public async Task<Category> Update(int id, Category category)
        {
            var updateCategory = new Category
            {
                CategoryId = category.CategoryId,
                Name = category.Name,
                Description = category.Description
            };
            _context.Entry(updateCategory).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return updateCategory;
        }

        public async Task AddProduct(int categoryId, int productId)
        {
            ProductCategory newProductCategory = new ProductCategory
            {
               ProductId = productId,
               CategoryId = categoryId
            };
            _context.Entry(newProductCategory).State = EntityState.Added;
            await _context.SaveChangesAsync();
        }

        public async Task RemoveProduct(int categoryId, int productId)
        {
            var result = await _context.ProductCatedories.FirstOrDefaultAsync(cp => cp.CategoryId== categoryId && cp.ProductId == productId);
            _context.Entry(result).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }
    }
}
