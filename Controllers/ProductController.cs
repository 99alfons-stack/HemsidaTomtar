using System;
using Microsoft.AspNetCore.Mvc;
using mvctest.Models;

namespace mvctest.Controllers;

public class ProductController : Controller
{
    private readonly IProductRepository _IProductRepository;

    public ProductController(IProductRepository productRepository)
    {
        _IProductRepository = productRepository;
    }

    // Tar emot kategori  (category=Figurer) för filtrering
    public IActionResult Index(ProductCategory? category)
    {
        IEnumerable<Product> products = _IProductRepository.AllProducts;
        if (category.HasValue)
        {
            products = _IProductRepository.GetByCategory(category.Value);
            ViewBag.message = $"PRODUKTER  {category.Value}";
        }
        else
        {
            ViewBag.message = "PRODUKTER";
        }
        ViewBag.CurrentCategory = category?.ToString(); // Fvisa kategorien föremålet tillhör
        return View(products);
    }
}
