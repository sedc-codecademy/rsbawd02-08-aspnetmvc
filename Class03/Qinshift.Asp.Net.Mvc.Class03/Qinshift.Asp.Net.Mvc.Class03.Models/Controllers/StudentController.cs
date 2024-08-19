using Microsoft.AspNetCore.Mvc;
using Qinshift.Asp.Net.Mvc.Class03.Models.Services;

namespace Qinshift.Asp.Net.Mvc.Class03.Models.Controllers
{
    [Route("students")]
    public class StudentController : Controller
    {
        private StudentService _studentService;
        public StudentController()
        {
            _studentService = new StudentService();
        }

        public IActionResult GetStudentById(int id)
        {
            var student = _studentService.GetStudentWithActiveCourse(id);

            if(student == null)
            {
                return Content("Student not found");
            }

            return Json(student);
        }
    }
}
