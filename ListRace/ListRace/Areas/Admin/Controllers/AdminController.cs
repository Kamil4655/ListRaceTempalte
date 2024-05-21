using Microsoft.AspNetCore.Mvc;

namespace ListRace.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        //public async Task<IActionResult> Create()
        //{
        //    return View();
        //}


        public async Task<IActionResult> Update()
        {
            return View();
        }
        //[HttpPost]
        //public async Task<IActionResult> Update()
        //{
        //    return View();
        //}


    }

}
