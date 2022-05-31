using Cosmetic_Store.Models;
using Cosmetic_Store.Models.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cosmetic_Store.Controllers
{
    public class CategoryController : Controller
    {
        private ICategory _category;
        public CategoryController(ICategory category)
        {
            _category = category;
        }
        public async Task<IActionResult> Index()
        {
            //List<Category> categoriesList = new List<Category>()
            //{
            //    new Category() { CategoryId = 1, Name = "Mascara" },
            //    new Category() { CategoryId = 2, Name = "Lipstick" },
            //    new Category() { CategoryId = 3, Name = "Powder" }
            //};

            var listOfCategories = await _category.GetCategories();
            return View(listOfCategories);
        }
        public async Task<IActionResult> GategoryDetail(int id)
        {
            var category = await _category.GetCategoryById(id);
            return View(category);
        }
    }
}
