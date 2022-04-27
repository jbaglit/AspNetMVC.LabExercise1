
using AspNetMVC.LabExercise1.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMVC.LabExercise1.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            ViewData["ProductList"] = _productService.GetCatalog();
            ViewData["ProductListGrandTotal"] = _productService.GetGrandTotal();
            return View();
        }
    }
}
