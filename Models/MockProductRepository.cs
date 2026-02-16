using System;

namespace mvctest.Models;

public class MockProductRepository : IProductRepository
{
    public IEnumerable<Product> AllProducts =>
        new List<Product>
        {
            new Product { ProductId = 1, Name = "TomteSomGungar", Price = 269m, Category = ProductCategory.Figurer },
            new Product { ProductId = 2, Name = "Hustomte", Price = 215m, Category = ProductCategory.Figurer },
            new Product { ProductId = 3, Name = "Kom och tälj med oss!!", Price = 399m, Category = ProductCategory.Workshops },
            new Product { ProductId = 4, Name = "Gammel Tomten", Price = 289m, Category = ProductCategory.Figurer },
            new Product { ProductId = 5, Name = "Minitomte", Price = 127m, Category = ProductCategory.Figurer },
            new Product { ProductId = 6, Name = "Tälj din egna jul tomte", Price = 249, Category = ProductCategory.Workshops, Bio = "Kom in och tälj din helt egna jultomte" },
            new Product { ProductId = 7, Name = "Blommor och blad, dekor i trä", Price = 425, Category = ProductCategory.Workshops, Bio = "under våren startar vi upp *Dekor i trä igen* enbart ett fåtal platser finns, boka i tid" },
            new Product { ProductId = 8, Name = "Introduktion till trätäljning", Price = 249, Category = ProductCategory.Workshops, Bio = "perfekt för alla hemma täljare från Nybörjare till proffs" }
        };

    public Product? GetProductById(int productId) =>
        AllProducts.FirstOrDefault(p => p.ProductId == productId);

    public IEnumerable<Product> GetByCategory(ProductCategory category) =>
        AllProducts.Where(p => p.Category == category);
}
