using AspNetMvcCore.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcCore.Controllers
{
    public class QueriesController : Controller
    {
        private readonly QueriesService _queriesService;

        public QueriesController() =>_queriesService=new QueriesService();

        public IActionResult QueriesList() => View();
        
        public IActionResult NumberOfComments() => View();
        
        public IActionResult NumberOfCommentsResult(int id) => View(_queriesService.NumberOfCommentsPost(id));
        
        public IActionResult CommentsListPost() => View();
        
        public IActionResult CommentsListPostResult(int id) => View(_queriesService.CommentsListPost(id));
        
        public IActionResult TodosListDone() => View();

        public IActionResult TodosListDoneResult(int id) => View(_queriesService.TodoListDone(id));
        
        public IActionResult UsersList(int id) => View(_queriesService.UserTodoList());
        
        public IActionResult StructureUser() => View();
        
        public IActionResult StructureUserResult(int id) => View(_queriesService.StructureUserService(id));
        
        public IActionResult StructurePost() => View();
        
        public IActionResult StructurePostResult(int id) => View(_queriesService.StructurePostService(id));
        
    }
}