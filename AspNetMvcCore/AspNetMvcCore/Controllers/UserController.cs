using AspNetMvcCore.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcCore.Controllers
{
    public class UserController : Controller
    {
        private readonly UserService _userService;

        public UserController() => _userService=new UserService();
        
        //GET: /User/UserInput
        public IActionResult UserInput() => View();
        
        public IActionResult UserResult(string name) => View(_userService.GetUser(name));
    }
}