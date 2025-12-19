using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using mvctest.Models;

public partial class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddScoped<ITodoListRepository, TodoListRepository>();
        builder.Services.AddScoped<ITodoItemRepository, TodoItemRepository>();
        builder.Services.AddScoped<IStaffRepository, MockStaffRepository>(); // lagt till personalen
        builder.Services.AddScoped<IProductRepository, MockProductRepository>();// lagt till produkterna
        builder.Services.AddControllersWithViews();
        builder.Services.AddDbContext<AppDbContext>(Options =>
        {
            Options.UseMySql(builder.Configuration.GetConnectionString("AppDbContextConnection"),
            ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("AppDbContextConnection")));
        });

        var app = builder.Build();

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