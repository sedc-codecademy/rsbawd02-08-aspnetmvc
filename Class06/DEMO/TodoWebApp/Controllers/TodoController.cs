using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using TodoWebApp.Database;
using TodoWebApp.Models.ViewModels;
using TodoWebApp.Services;
using TodoWebApp.Services.Dtos;

namespace TodoWebApp.Controllers
{
    public class TodoController : Controller
    {
        private TodoService todoService;

        public TodoController()
        {
            todoService = new TodoService();
        }
        public IActionResult Index(int categoryId, int statusId)
        {
            ViewBag.Filter = new FilterVM { 
                Categories  = InMemoryDatabase.Categories,
                Statuses = InMemoryDatabase.Statuses,
                SelectedCategoryId = categoryId,
                SelectedStatusId = statusId,
            };

            var result = todoService.GetTodos(categoryId, statusId);

            return View(result);
        }

        [HttpGet()]
        public IActionResult AddTodo() { 
            ViewBag.Categories = InMemoryDatabase.Categories;
            ViewBag.Statuses = InMemoryDatabase.Statuses;

            return View();
        }

        [HttpPost()]
        public IActionResult AddTodo(CreateTodoDto createTodoDto) {
            todoService.AddTodo(createTodoDto);
            return RedirectToAction("Index");
        }

        [HttpPost()]
        public IActionResult MarkCompleted(int id) {
            todoService.MarkCompleted(id);
            return RedirectToAction("Index");
        }
        
        [HttpPost()]
        public IActionResult RemoveCompleted() {
            todoService.RemoveCompleted();
            return RedirectToAction("Index");
        }
    }
}
