using AspNetMvcCore.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcCore.Controllers
{
    public class TodoController : Controller
    {
        private readonly TodoService _todoService;

        public TodoController() =>_todoService = new TodoService();
        
        public IActionResult TodoInput() => View();

        public IActionResult TodoResult(string name) => View(_todoService.GetTodo(name));
    }
}