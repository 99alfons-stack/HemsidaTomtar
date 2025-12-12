using System;

namespace mvctest.Models;

public class MockProductRepository : IProductRepository
{
    public IEnumerable<Product> AllProducts =>
        new List<Product>
        { //lägga in en bio om prudukterna ?? ex hur länge en täljstund är eller hur det fungerar
          //mer alternativ? kunna klicka på korten för att bli tagen till en ny sida där man möts av flera tomtar av de slaget?
            new Product { ProductId = 1, Name = "TomteSomGungar", Price = 269m },
            new Product { ProductId = 2, Name = "Hustomte", Price = 215m },
            new Product { ProductId = 3, Name = "Kom och tälj med oss!!", Price = 399m }
        };

    public Product? GetProductById(int productId) =>
        AllProducts.FirstOrDefault(p => p.ProductId == productId);


        
}