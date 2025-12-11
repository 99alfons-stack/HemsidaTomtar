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

    public IActionResult Index()
    {
        ViewBag.message="PRODUKTER";
        return View(_IProductRepository.AllProducts);
    }
}
