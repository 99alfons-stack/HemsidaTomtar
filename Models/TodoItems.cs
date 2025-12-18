using System;

namespace mvctest.Models;

public class TodoItems
{
    public int TodoId {get; set;}
    public int TodoListId {get; set;}
    public string Name {get; set;} =string.Empty;
    public bool Done {get; set;}

}
