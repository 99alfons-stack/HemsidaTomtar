using System;

namespace mvctest.Models;

public class TodoListRepository : ITodoListRepository
{

    private readonly  AppDbContext _appDbContext;

    //skapa construktor
    public TodoListRepository( AppDbContext appDbContext)
    {
        this._appDbContext = appDbContext;
    }
    public IEnumerable<TodoList> AllTodoLists

    {
        get
        {
            return _appDbContext.TodoLists;
        }


    }

    public TodoList? GetTodoListById(int id) //frågetecknet gör att värdet aldrig kan va null
    {
       return _appDbContext.TodoLists.FirstOrDefault(l => l.TodoListId ==id);
    }
    }
