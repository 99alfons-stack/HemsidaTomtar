using System;

namespace mvctest.Models;

public class MockProductRepository : IProductRepository
{
    public IEnumerable<Product> AllProducts =>
        new List<Product>
        { //lägga in en bio om prudukterna ?? ex hur länge en täljstund är eller hur det fungerar
          //mer alternativ? kunna klicka på korten för att bli tagen till en ny sida där man möts av flera tomtar av de slaget?
            // Märk varje produkt med Category för filtrering
            new Product { ProductId = 1, Name = "TomteSomGungar", Price = 269m, Category = ProductCategory.Figurer },
            new Product { ProductId = 2, Name = "Hustomte", Price = 215m, Category = ProductCategory.Figurer },
            new Product { ProductId = 3, Name = "Kom och tälj med oss!!", Price = 399m, Category = ProductCategory.Workshops },
            new Product { ProductId = 4, Name = "Tomte med Lykta", Price = 289m, Category = ProductCategory.Figurer },
            new Product { ProductId = 5, Name = "Minitomte", Price = 249m, Category = ProductCategory.Figurer }
        };

    public Product? GetProductById(int productId) =>
        AllProducts.FirstOrDefault(p => p.ProductId == productId);

    // Returnerar produkter för vald kategori
    public IEnumerable<Product> GetByCategory(ProductCategory category) =>
        AllProducts.Where(p => p.Category == category);
}