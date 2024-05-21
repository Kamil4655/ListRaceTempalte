using ListRace.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ListRace.Controllers
{
    public class HomeController(ListRaceContext _context) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var data = await _context.Categories.ToListAsync();
            return View(data);
        }
    }
}
