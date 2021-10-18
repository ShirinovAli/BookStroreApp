using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;

namespace WebUI.Controllers
{
    public class ProductsController : Controller
    {
        private IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<IActionResult> List()
        {
            var products = await _productService.GetAllProductDetailsAsync();
            return View(products);
        }

        public IActionResult Details(int id)
        {
            var product = _productService.GetProductDetails(id);
            return View(product.Data);
        }
    }
}
