using System;

namespace mvctest.Models;

public class MockProductRepository : IProductRepository
{
    public IEnumerable<Product> AllProducts =>
        new List<Product>
        {
            new Product { ProductId = 1, Name = "TomteSomGungar" },
            new Product { ProductId = 2, Name = "Hustomte" },
            new Product { ProductId = 3, Name = "Kom och tälj med oss!!" }
        };

    public Product? GetProductById(int productId) =>
        AllProducts.FirstOrDefault(p => p.ProductId == productId);


        
}