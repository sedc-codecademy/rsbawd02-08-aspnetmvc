using Microsoft.AspNetCore.Mvc;
using TodoWebApp.Services;

namespace TodoWebApp.Controllers
{
    public class TodoController : Controller
    {
        private TodoService todoService;

        public TodoController()
        {
            todoService = new TodoService();
        }
        public IActionResult Index()
        {
            var result = todoService.GetTodos();

            return View(result);
        }
    }
}
