using System;

namespace Qinshift.Asp.Net.Mvc.Class03.Models.Models.Entities
{
    public class Student
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Course ActiveCourse { get; set; }
    }
}
