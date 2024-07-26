using Microsoft.AspNetCore.Mvc;
using MyTodoList_001.Domain.Entities;
using MyTodoList_001.Domain.Repoitories;
using MyTodoList_001.Domain.Services;
using MyTodoList_001.Models;
using System.Diagnostics;

namespace MyTodoList_001.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ITodoItemServices _todoItemService;

        public HomeController(ILogger<HomeController> logger, ITodoItemServices todoItemService)
        {
            _logger = logger;
            _todoItemService = todoItemService;
        }

        public IActionResult Index()
        {
            var model = new TodoModel();
            model.Items = _todoItemService.GetAll();
            return View(model);
        }

        [HttpGet("/add")]
        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Create(TodoItem item)
        {
            _todoItemService.Create(item);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("/edit/{id}")]
        public IActionResult Edit(int id)
        {
            var item = _todoItemService.GetById(id);
            return View(item);
        }

        [HttpPost]
        public IActionResult Update(TodoItem item)
        {
            _todoItemService.Update(item);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("/delete/{id}")]
        public IActionResult Delete(int id)
        {
            _todoItemService.Delete(id);
            return RedirectToAction("Index");
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
