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
    }
}
