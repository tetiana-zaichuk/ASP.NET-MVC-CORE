﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetMvcCore.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcCore.Controllers
{
    public class TodoController : Controller
    {
        private readonly TodoService _todoService;

        public TodoController()
        {
            _todoService = new TodoService();
        }

        public IActionResult Index() => View();

        public IActionResult GetTodo(string name) => View(_todoService.GetTodo(name));
    }
}