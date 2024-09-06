using DemoEf.Database.Entities;
using Microsoft.AspNetCore.Mvc;
using TodoWebApp.Database;


namespace DemoEf.Controllers
{
    
    public class StudentsController : Controller
    {

        private DemoDbContext _context;
        public StudentsController(DemoDbContext context)
        {
            _context = context;
        }

      
        public IActionResult Index()
        {

            var students = _context.Students.Where(s => s.FirstName.StartsWith("A")).Select(s => new Student { FirstName = s.FirstName, LastName = s.LastName}).ToList();
            return View(students);
        }
    }
}
