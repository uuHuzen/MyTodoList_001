using Microsoft.AspNetCore.Mvc;
using MyTodoList_001.Domain.Repoitories;
using MyTodoList_001.Models;
using System.Diagnostics;

namespace MyTodoList_001.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private TodoDbContext _db;

        public HomeController(ILogger<HomeController> logger, TodoDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            var l = _db.TodoItems.ToList();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
