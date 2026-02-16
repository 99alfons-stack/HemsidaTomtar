using System;

namespace mvctest.Models;

// Enum för att kategorisera produkter
public enum ProductCategory
{
    Figurer,
    Workshops,
    Juldekoration,
    Blomdekorationer,
    Familjepaketen
}

public class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public ProductCategory Category { get; set; }
    public string Bio { get; set; } = string.Empty;
}
