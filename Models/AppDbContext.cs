using System;
using Microsoft.EntityFrameworkCore;

namespace mvctest.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Staff> Staffs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Seed data för produkter - 5 kategorier med minst 4 produkter vardera
        modelBuilder.Entity<Product>().HasData(
            // Kategori 1: Figurer
            new Product { ProductId = 1, Name = "Gungtomte", Price = 199.99m, Category = ProductCategory.Figurer, Bio = "Klassisk tomte på gungstol" },
            new Product { ProductId = 2, Name = "Hustomte", Price = 249.99m, Category = ProductCategory.Figurer, Bio = "Skyddare för ditt hem" },
            new Product { ProductId = 3, Name = "Småtomte", Price = 99.99m, Category = ProductCategory.Figurer, Bio = "Liten rölig tomte" },
            new Product { ProductId = 4, Name = "Tomtepär", Price = 149.99m, Category = ProductCategory.Figurer, Bio = "Tomte med pärongärdad design" },
            new Product { ProductId = 5, Name = "Skäggig Tomte", Price = 179.99m, Category = ProductCategory.Figurer, Bio = "Tomte med imponerande skägg" },

            // Kategori 2: Workshops
            new Product { ProductId = 6, Name = "Tomtefigurer Workshop", Price = 299.99m, Category = ProductCategory.Workshops, Bio = "Lär dig göra egna tomtefigurer" },
            new Product { ProductId = 7, Name = "Dekoration Workshop", Price = 199.99m, Category = ProductCategory.Workshops, Bio = "Skapa juldekorationer tillsammans" },
            new Product { ProductId = 8, Name = "Keramik Tomtar Workshop", Price = 349.99m, Category = ProductCategory.Workshops, Bio = "Arbeta med lera och form" },
            new Product { ProductId = 9, Name = "Målning För Barn Workshop", Price = 149.99m, Category = ProductCategory.Workshops, Bio = "Måla dina egna tomtefigurer" },
            new Product { ProductId = 10, Name = "Familj Workshop Paket", Price = 599.99m, Category = ProductCategory.Workshops, Bio = "Workshop för hela familjen" },

            // Kategori 3: Juldekoration
            new Product { ProductId = 11, Name = "Adventsljusstake", Price = 299.99m, Category = ProductCategory.Juldekoration, Bio = "Vacker adventsljusstake med tomtar" },
            new Product { ProductId = 12, Name = "Julkrans", Price = 249.99m, Category = ProductCategory.Juldekoration, Bio = "Traditionell julkrans med tomteskulpturer" },
            new Product { ProductId = 13, Name = "Julgranprydnad Set", Price = 349.99m, Category = ProductCategory.Juldekoration, Bio = "Paket med 10 handtillverkade julgransprydnader" },
            new Product { ProductId = 14, Name = "Väggdekorationslapp", Price = 179.99m, Category = ProductCategory.Juldekoration, Bio = "Julkort och väggdekorationer med tomtarmotiv" },
            new Product { ProductId = 15, Name = "Lysande Jul Tomte", Price = 399.99m, Category = ProductCategory.Juldekoration, Bio = "Belyst tomte med LED-ljus" },

            // Kategori 4: Blomdekorationer
            new Product { ProductId = 16, Name = "Vårbukett med Tomte", Price = 189.99m, Category = ProductCategory.Blomdekorationer, Bio = "Färgglad blomsterarrangering med tomteskulptur" },
            new Product { ProductId = 17, Name = "Blomkrukommit Tomte", Price = 149.99m, Category = ProductCategory.Blomdekorationer, Bio = "Dekorativ blomkruka med inpräglad tomte" },
            new Product { ProductId = 18, Name = "Gräsbevuxen Tomte", Price = 129.99m, Category = ProductCategory.Blomdekorationer, Bio = "Mini tomte med gräs på huvudet" },
            new Product { ProductId = 19, Name = "Växtkompost med Tomtesignatur", Price = 79.99m, Category = ProductCategory.Blomdekorationer, Bio = "Biologisk kompost för blomstrar med tomtemärkning" },
            new Product { ProductId = 20, Name = "Tomatris Trädgårdsprydnad", Price = 219.99m, Category = ProductCategory.Blomdekorationer, Bio = "Unik trädgårdsprydnad med tomtemotiv" },

            // Kategori 5: Familjepaketen
            new Product { ProductId = 21, Name = "Familj Klassiker Paket", Price = 799.99m, Category = ProductCategory.Familjepaketen, Bio = "5 figurer för hela familjen" },
            new Product { ProductId = 22, Name = "Hemmet Paket", Price = 599.99m, Category = ProductCategory.Familjepaketen, Bio = "Hustomte + 4 accessoarer" },
            new Product { ProductId = 23, Name = "Jul Celebration Paket", Price = 999.99m, Category = ProductCategory.Familjepaketen, Bio = "Allt för en perfekt jul hemma" },
            new Product { ProductId = 24, Name = "Generationsfavoriter", Price = 699.99m, Category = ProductCategory.Familjepaketen, Bio = "Traditionsrik samling som generationer älskar" },
            new Product { ProductId = 25, Name = "Trädgårdspaket Deluxe", Price = 1199.99m, Category = ProductCategory.Familjepaketen, Bio = "Komplett trädgårdsdekorationspaket med 8 tomtar" }
        );
    }
}
