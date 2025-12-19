using System;

namespace mvctest.Models;
//detta är vårat kontrakt, våra metoder (vilka som ska existera)
public interface ITodoListRepository
{
    IEnumerable<TodoList> AllTodoLists { get; }
    TodoList? GetTodoListById(int id); //detta är våra read operationer
}
