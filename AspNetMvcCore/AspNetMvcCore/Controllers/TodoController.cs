using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetMvcCore.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcCore.Controllers
{
    public class TodoController : Controller
    {
        private TodoService todoService;

        public TodoController()
        {
            todoService=new TodoService();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetTodo(string name)
        {
            return View(todoService.GetTodo(name));
        }
    }
}