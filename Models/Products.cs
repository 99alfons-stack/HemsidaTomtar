using System;

namespace mvctest.Models;

// Enum för att kategorisera produkter – lägg till fler vid behov
public enum ProductCategory
{
    Figurer,
    Workshops
}

public class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; } =string.Empty;
    public decimal Price { get; set; }
    public ProductCategory Category { get; set; } // Filtrerar våra prudukter i kategorier
}