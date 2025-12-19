using System;

namespace mvctest.Models;

public interface ITodoItemRepository
{
    IEnumerable<TodoItem> GetAllTodoItemsByCategoryId(int id);
    TodoItem? UpdateTodoItemDone(int id);
    TodoItem SaveNewTodoItem(TodoItem newTodoItem);
}
