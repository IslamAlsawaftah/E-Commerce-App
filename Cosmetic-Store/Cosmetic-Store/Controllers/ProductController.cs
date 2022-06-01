using Cosmetic_Store.Models;
using Cosmetic_Store.Models.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Cosmetic_Store.Controllers
{
    public class ProductController : Controller
    {
        private IProduct _product;
        public ProductController(IProduct product)
        {
            _product = product;
        }
        public async Task<IActionResult> Index()
        {
            var listOfProducts = await _product.GetProducts();
            return View(listOfProducts);
        }
        public async Task<IActionResult> ProductDetail(int id)
        {
            var product = await _product.GetProductById(id);
            return View(product);
        }
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Product product)
        {
            var products = await _product.Create(product);
            if (ModelState.IsValid)
            {
                return Content("You have successfully added a product ! \nName: " + product.Name + " \nPrice: " + product.Price + " \nDescription: " + product.Description + " \nImage: " + product.ImageURL);
            }
            return View(products);
        }
        public async Task<IActionResult> Update(int id)    
        {
            Product product1 = await _product.GetProductById(id);
            return View(product1);
        }

        [HttpPost]
        // -http://localhost:22304/Product/Update?id=11
        public async Task<IActionResult> Update(Product product)
        {
            if (ModelState.IsValid)
            {
                await _product.Update(product.ProductId, product);
                return Content("You have successfully edited data");
            }
            return View(product);
        }
        // -http://localhost:22304/Product/Delete?id=11
        public async Task<IActionResult> Delete(int id)
        {
            await _product.Delete(id);
            return Content("Product deleted successfully");
        }
    }
}
