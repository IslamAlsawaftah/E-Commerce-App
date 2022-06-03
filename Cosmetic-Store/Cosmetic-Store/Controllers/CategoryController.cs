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
            var listOfCategories = await _category.GetCategories();
            return View(listOfCategories);
        }
        public async Task<IActionResult> Detail(int id)
        {
            var category = await _category.GetCategoryById(id);
            return View(category);
        }

        public IActionResult Create()
        {
            return View();  
        }
        [HttpPost]
        public async Task<IActionResult> Create(Category category)
        {
            if (ModelState.IsValid)
            {
                var newCategory = await _category.Create(category);
                return RedirectToAction("Index");
            }
            return View(category);
        }

        public async Task<IActionResult> Edit(int id)
        {
            Category category = await _category.GetCategoryById(id);
            return View(category);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                var updateCategory = await _category.Update(category.CategoryId, category);
                return RedirectToAction("Index");
            }
            return View(category);
        }
        public async Task<IActionResult> Delete(int id)
        {
            Category category = await _category.GetCategoryById(id);
            return View(category);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _category.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
