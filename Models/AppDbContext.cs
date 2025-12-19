using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.JSInterop.Infrastructure;

namespace mvctest.Models;

public class AppDbContext :DbContext
{

    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
    {
        
        

    }

    public DbSet<TodoItem> TodoItems { get; set; }
    public DbSet<TodoList> TodoLists { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)// en metod som enbart ska köras när vi gör våran migrering
    {
        base.OnModelCreating(modelBuilder);

        //Mock list
        modelBuilder.Entity<TodoList>().HasData(
            new TodoList { TodoListId = 1, Name = "Produkter" },
            new TodoList { TodoListId = 2, Name = "Workshop"  }
        );

        //mock Items
        modelBuilder.Entity<TodoItem>().HasData(
        new TodoItem { TodoItemId = 1, TodoListId = 1, Name = "Gungtomte", Done=false },
        new TodoItem { TodoItemId = 2, TodoListId = 1, Name = "HusTome", Done=false },
        new TodoItem { TodoItemId = 3, TodoListId = 1, Name = "SmåTomtar", Done=false },
        new TodoItem { TodoItemId = 4, TodoListId = 2, Name = "grupp 1", Done=false },
        new TodoItem { TodoItemId = 5, TodoListId = 2, Name = "grupp3", Done=false }
        
        );  
    }
}
