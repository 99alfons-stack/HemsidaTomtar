using System;

namespace mvctest.Models;

public class TodoItemRepository : ITodoItemRepository
{

    private readonly AppDbContext _appDbContext;

    public TodoItemRepository(AppDbContext appDbContext)
    {
        this._appDbContext = appDbContext;
    }

    public IEnumerable<TodoItem> GetAllTodoItemsByCategoryId(int id)
    {
        return _appDbContext.TodoItems.Where(i => i.TodoListId ==id); //i för alla items
    }

    public TodoItem SaveNewTodoItem(TodoItem newTodoItem)
    {
        _appDbContext.TodoItems.Add(newTodoItem);
        _appDbContext.SaveChanges();
        return newTodoItem;
    }

    public TodoItem? UpdateTodoItemDone(int id)
    {
       
        var todoItem = _appDbContext.TodoItems.FirstOrDefault(i => i.TodoItemId==id);

        if (todoItem==null)
        {
            return null;
        }
        todoItem.Done = !todoItem.Done;
        _appDbContext.SaveChanges();

        return todoItem;
    }
}
