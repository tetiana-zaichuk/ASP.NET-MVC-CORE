using AspNetMvcCore.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcCore.Controllers
{
    public class PostController : Controller
    {
        private readonly PostService _postService;

        public PostController() =>_postService = new PostService();
        
        public IActionResult PostInput() => View();

        public IActionResult PostResult(string title) => View(_postService.PostResult(title));

        public IActionResult PostResultId(int id) => View(_postService.PostResultId(id));
    }
}