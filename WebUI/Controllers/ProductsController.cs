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
        public async Task<IActionResult> List(int genreId, int publisherId, int authorId, string query)
        {
            var products = await _productService.GetAllProductDetailsAsync();
            if (genreId != 0)
            {
                products = await _productService.GetAllProductByGenreIdAsync(genreId);
            }

            if (publisherId != 0)
            {
                products = await _productService.GetAllProductByPublisherIdAsync(publisherId);
            }

            if (authorId != 0)
            {
                products = await _productService.GetAllProductByAuthorIdAsync(authorId);
            }

            if (query != null)
            {
                products = await _productService.GetAllProductByProductName(query);
            }
            return View(products);
        }

        public IActionResult Details(int id)
        {
            var product = _productService.GetProductDetails(id);
            return View(product.Data);
        }
    }
}
