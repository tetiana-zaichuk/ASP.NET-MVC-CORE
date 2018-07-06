using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetMvcCore.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcCore.Controllers
{
    public class UserController : Controller
    {
        private UserService userService;

        public UserController()
        {
            userService=new UserService();
        }

        //GET: /User/Index
        public IActionResult Index()
        {
            return View(userService.GetAll());
        }
    }
}