using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NumberOfComments()
        {
            return View();
        }

        public IActionResult NumberOfCommentsResult(int id)
        {
            return View(queriesService.NumberOfCommentsPost(id));
        }

    }
}