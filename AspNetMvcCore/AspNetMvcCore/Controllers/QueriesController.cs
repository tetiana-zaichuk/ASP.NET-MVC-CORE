using AspNetMvcCore.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcCore.Controllers
{
    public class QueriesController : Controller
    {
        private QueriesService queriesService;

        public QueriesController()
        {
            queriesService=new QueriesService();
        }

        public IActionResult Index() => View();
        
        public IActionResult NumberOfComments() => View();
        
        public IActionResult NumberOfCommentsResult(int id) => View(queriesService.NumberOfCommentsPost(id));
        
        public IActionResult CommentsListPost() => View();
        
        public IActionResult CommentsListPostResult(int id) => View(queriesService.CommentsListPost(id));
        
        public IActionResult TodosListDone() => View();

        public IActionResult TodosListDoneResult(int id) => View(queriesService.TodoListDone(id));
        
        public IActionResult UsersList(int id) => View(queriesService.UserTodoList());
        
        public IActionResult StructureUser() => View();
        
        public IActionResult StructureUserResult(int id) => View(queriesService.StructureUserService(id));
        
        public IActionResult StructurePost() => View();
        
        public IActionResult StructurePostResult(int id) => View(queriesService.StructurePostService(id));
        
    }
}