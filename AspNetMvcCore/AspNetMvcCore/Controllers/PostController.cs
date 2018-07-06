using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetMvcCore.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcCore.Controllers
{
    public class PostController : Controller
    {
        private PostService postService;

        public PostController()
        {
            postService = new PostService();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetPost(string name)
        {
            return View(postService.GetPost(name));
        }
    }
}