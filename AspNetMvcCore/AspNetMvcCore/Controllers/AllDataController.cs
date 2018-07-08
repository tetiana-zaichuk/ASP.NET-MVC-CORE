using AspNetMvcCore.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcCore.Controllers
{
    public class AllDataController : Controller
    {
        private readonly AllData _allData;

        public AllDataController()
        {
            _allData = new AllData();
        }

        public IActionResult AllData() => View(_allData.GetAll());
    }
}