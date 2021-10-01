using System.Collections.Generic;
using Congo.RazorPages.Models;
using Congo.RazorPages.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Congo.RazorPages.Pages
{
    public class ProductsModel : PageModel
    {
        public IEnumerable<Product> SampleData;
        private readonly IProductsService _productsService;

        public ProductsModel(IProductsService productsService)
        {
            _productsService = productsService;
        }

        public void OnGet()
        {
            SampleData = _productsService.GetSampleProducts();
        }
    }
}