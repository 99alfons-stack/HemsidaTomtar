using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using mvctest.Models;

public partial class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddScoped<IStaffRepository, MockStaffRepository>();
        builder.Services.AddScoped<IProductRepository, MockProductRepository>();
        builder.Services.AddControllersWithViews();
        
        // Use InMemoryDatabase för Entity Framework
        builder.Services.AddDbContext<AppDbContext>(Options =>
        {
            Options.UseInMemoryDatabase("TomatArDatabase");
        });

        var app = builder.Build();

        // Initialize the database with seed data
        using (var scope = app.Services.CreateScope())
        {
            var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            dbContext.Database.EnsureCreated();
        }

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseRouting();

        app.UseAuthorization();

        app.MapStaticAssets();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}")
            .WithStaticAssets();


        app.Run();
    }
}