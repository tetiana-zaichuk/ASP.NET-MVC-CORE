using AspNetMvcCore.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcCore.Controllers
{
    public class PostController : Controller
    {
        private readonly PostService _postService;

        public PostController()
        {
            _postService = new PostService();
        }

        public IActionResult Index() => View();

        public IActionResult GetPost(string name) => View(_postService.GetPost(name));
    }
}