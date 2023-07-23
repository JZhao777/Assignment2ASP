using System;
using Assignment2.Models;
using Assignment2.Services;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assignment2.Pages
{
    public class ProductListModel : PageModel
    {
        public JsonFileProductService ProductService;

        public IEnumerable<Fruit> Fruits { get; private set; } = default!;

       public ProductListModel(JsonFileProductService productService)
        {
            
            ProductService = productService;
        }

        public void OnGet()
        {
            Fruits = ProductService.GetProducts();
        }
    }
}
