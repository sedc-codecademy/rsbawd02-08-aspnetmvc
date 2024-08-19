using Qinshift.Asp.Net.Mvc.Class03.Models.Database;
using Qinshift.Asp.Net.Mvc.Class03.Models.Models.DtoModels;
using System;
using System.Linq;

namespace Qinshift.Asp.Net.Mvc.Class03.Models.Services
{
    public class StudentService
    {
        public StudentWithCourseDto GetStudentWithActiveCourse(int id)
        {
            var student = InMemoryDb.Students.FirstOrDefault(x => x.Id == id);

            if (student == null)
            {
                return null;
            }

            var studentWithCourse = new StudentWithCourseDto
            {
                Id = student.Id,
                FullName = string.Format("{0} {1}", student.FirstName, student.LastName),
                NameOfCourse = student.ActiveCourse.Name,
                Age = DateTime.Now.Year - student.DateOfBirth.Year
            };

            return studentWithCourse;
        }
    }
}
