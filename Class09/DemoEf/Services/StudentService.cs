using DemoEf.Database.Entities;
using Microsoft.EntityFrameworkCore;
using TodoWebApp.Database;

namespace DemoEf.Services
{
    public class StudentService
    {
        private readonly DemoDbContext _context;
        public StudentService(DemoDbContext context)
        {
            _context = context;
        }

        public void Create(StudentDto studentDto) {
            
            var student = new Student
            {
                FirstName = studentDto.FirstName,
                ParentName = studentDto.ParentName,
                LastName = studentDto.LastName,
                ActiveCourseId = studentDto.ActiveCourseId,
            };


            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public List<Student> GetAll() {
            return _context.Students.ToList();
        }
    }
}
