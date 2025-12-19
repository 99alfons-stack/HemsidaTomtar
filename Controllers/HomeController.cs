using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvctest.Models;

namespace mvctest.Controllers;

public class HomeController : Controller
{
    
    private readonly ITodoListRepository _todoListRepository;
    private readonly ITodoItemRepository _todoItemRepository;

   public HomeController(ITodoListRepository todoListRepository,
                      ITodoItemRepository todoItemRepository)
{
   this. _todoListRepository = todoListRepository;
   this. _todoItemRepository = todoItemRepository;
}
    public IActionResult Index()
    {
        return View(_todoListRepository.AllTodoLists);
    }

    public IActionResult List(int id)
    {
        ViewBag.List = _todoListRepository.GetTodoListById(id);
        return View(_todoItemRepository.GetAllTodoItemsByCategoryId(id));
    }
    public IActionResult Products()
    {
        return View();
    }
    public IActionResult AddNewItem()
    {
        return View(_todoListRepository.AllTodoLists);
    }

    [HttpPost]
    public IActionResult SaveNewItem(string name, int todoListId)
    {
        System.Console.WriteLine("Form POST" + name + todoListId);

        var newTodoItem = new TodoItem{
              Name = name,
              TodoListId = todoListId,
              Done = false
        };

        _todoItemRepository.SaveNewTodoItem(newTodoItem);

         return RedirectToAction("AddNewItem");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
