using DemoEf.Database.Entities;
using DemoEf.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoWebApp.Database;


namespace DemoEf.Controllers
{
    
    public class StudentsController : Controller
    {

        StudentService _studentService;
        public StudentsController(StudentService studentService)
        {
            _studentService = studentService;
        }

      
        public IActionResult Index()
        {

            var students = _studentService.GetAll();

            return View(students);
        }       


        public IActionResult Create(string studentName, string lastName)
        {

            _studentService.Create(new StudentDto { 
            
            FirstName = studentName,
            LastName = lastName,
            ParentName = "Somebody",
            ActiveCourseId = 1            
            });


            return Ok();
        }
    }
}
