using Microsoft.AspNetCore.Mvc;
using Qinshift.Asp.Net.Mvc.Class02.Controllers.Models;
using System.Collections.Generic;
using System.Linq;

namespace Qinshift.Asp.Net.Mvc.Class02.Controllers.Controllers
{
    // Conventional routing
    public class CoursesController : Controller
    {
        private List<Course> _courses = new List<Course>()
        {
            new() { Id = 1, Name = "C# basic" },
            new() { Id = 2, Name = "C# Advanced" },
            new() { Id = 3, Name = "Database development and design" },
            new() { Id = 4, Name = "ASP.NET Mvc" }
        };

        public JsonResult GetAllCourses()
        {
            return Json(_courses);
        }


        public IActionResult GetCourseById(int id)
        {
            return Json(_courses.FirstOrDefault(x => x.Id == id));
        }


        public IActionResult GetCourseByName(string name)
        {
            return Json(_courses.FirstOrDefault(x => x.Name == name));
        }

        public string GetCourse(int id = 1)
        {
            return _courses.FirstOrDefault(x => x.Id == id).Name;
        }

        public IActionResult GetCourseByIdOrName(int id, string name)
        {
            var course = _courses.FirstOrDefault(x => x.Id == id);
            if (course == null)
            {
                course = _courses.FirstOrDefault(x => x.Name == name);
                return Json(course);
            }
            else
            {
                return NoContent();
            }
        }
    }
}
