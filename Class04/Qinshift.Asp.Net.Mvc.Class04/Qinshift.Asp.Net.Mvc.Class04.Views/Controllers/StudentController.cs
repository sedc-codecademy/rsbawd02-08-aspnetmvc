using Microsoft.AspNetCore.Mvc;
using Qinshift.Asp.Net.Mvc.Class04.Views.Database;
using Qinshift.Asp.Net.Mvc.Class04.Views.Models.DtoModels;
using Qinshift.Asp.Net.Mvc.Class04.Views.Models.Entities;
using Qinshift.Asp.Net.Mvc.Class04.Views.Models.ViewModels;
using System.Linq;

namespace Qinshift.Asp.Net.Mvc.Class04.Views.Controllers
{
    [Route("students")]
    public class StudentController : Controller
    {
        public ActionResult Index()
        {
            return View(InMemoryDatabase.Students.Select(x => new StudentWithCourseDto(x.Id, x.FirstName, x.LastName, x.DateOfBirth, x.ActiveCourse.Id, x.ActiveCourse.Name)));
        }

        [HttpGet("{id}")]
        public ActionResult GetStudentById(int id)
        {
            var student = InMemoryDatabase.Students.FirstOrDefault(x => x.Id == id);
            if (student == null)
            {
                return View();
            }

            var studentWithCourse = new StudentWithCourseDto(student.Id, student.FirstName, student.LastName, student.DateOfBirth, student.ActiveCourse.Id, student.ActiveCourse.Name);

            return View(studentWithCourse);
        }

        [HttpGet("create")]
        public ActionResult CreateStudent()
        {
            return View("CreateStudent");
        }

        [HttpPost("create")]
        public IActionResult CreateStudent(CreateStudentVM viewModel)
        {
            // Map view model to your entity model
            var entity = new Student
            {
                DateOfBirth = viewModel.DateOfBirth,
                FirstName = viewModel.FirstName,
                LastName = viewModel.LastName,
                Id = InMemoryDatabase.Students.Count + 1,
                ActiveCourse = InMemoryDatabase.Courses[3]
            };

            InMemoryDatabase.Students.Add(entity);

            return RedirectToAction("Index"); // Redirect to index action after successful creation
        }
    }
}
