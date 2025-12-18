using System;

namespace mvctest.Models;

public interface IProductRepository
{
    IEnumerable<Product> AllProducts { get; }
    Product? GetProductById(int productId);
    IEnumerable<Product> GetByCategory(ProductCategory category);
}
