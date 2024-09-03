using Microsoft.AspNetCore.Mvc;
using Qinshift.Asp.Net.Class07.App.Models.Dtos;
using Qinshift.Asp.Net.Class07.App.Models.ViewModels;
using System.Collections.Generic;

namespace Qinshift.Asp.Net.Class07.App.Controllers
{
    [Route("students")]
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new List<StudentDto>
            {
                new StudentDto
                {
                    FullName = "Bob Bobski",
                    Age = 33
                },
                new StudentDto
                {
                    FullName = "Jill Wayne",
                    Age = 54
                },
                new StudentDto
                {
                    FullName = "John Doe",
                    Age = 23
                },
            });
        }

        [HttpGet("{id}")]
        public IActionResult GetStudent([FromRoute] int id, [FromQuery] StudentFilterVM filter)
        {
            // Show filter via debugging
            var student = new StudentDto()
            {
                Age = 33,
                FullName = "Bob Bobski"
            };

            return View(student);
        }

        [HttpGet("create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create([FromForm] CreateStudentVM model)
        {
            if (ModelState.IsValid)
            {
                // Logic to save the student to the database
                // For demonstration purposes, let's just return a success message
                return Content("Student created successfully!");
            }
            return View(model); // If model is not valid, return the view with validation errors
        }
    }
}
