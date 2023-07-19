using System;
using ClassCraftFinal.Models;
using ClassCraftFinal.Services;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ClassCraftFinal.Pages
{
    public class ProductListModel : PageModel
    {
        public JsonFileProductService ProductService;

        public IEnumerable<Product> Products { get; private set; } = default!;

       public ProductListModel(JsonFileProductService productService)
        {
            
            ProductService = productService;
        }

        public void OnGet()
        {
            Products = ProductService.GetProducts();
        }
    }
}
