using System;
using Microsoft.AspNetCore.Mvc;
using mvctest.Models;

namespace mvctest.Controllers;

public class ProductController : Controller
{
    private readonly AppDbContext _context;

    public ProductController(AppDbContext context)
    {
        _context = context;
    }

    // Display all products or filter by category
    public IActionResult Index(ProductCategory? category)
    {
        IEnumerable<Product> products = _context.Products.ToList();
        if (category.HasValue)
        {
            products = _context.Products.Where(p => p.Category == category).ToList();
            ViewBag.message = $"PRODUKTER - {category.Value}";
        }
        else
        {
            ViewBag.message = "ALLA PRODUKTER";
        }
        ViewBag.CurrentCategory = category?.ToString();
        return View(products);
    }

    // Display products by category (dynamic page)
    public IActionResult Category(string categoryName)
    {
        if (!Enum.TryParse<ProductCategory>(categoryName, ignoreCase: true, out var category))
        {
            return NotFound();
        }

        var products = _context.Products.Where(p => p.Category == category).ToList();
        ViewBag.CategoryName = category.ToString();
        return View("CategoryView", products);
    }
}