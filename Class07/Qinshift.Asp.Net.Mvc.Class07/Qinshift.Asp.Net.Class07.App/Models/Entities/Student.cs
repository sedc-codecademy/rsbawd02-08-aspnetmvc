using System;
using System.ComponentModel.DataAnnotations;

namespace Qinshift.Asp.Net.Class07.App.Models.Entities
{
    public class Student
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
    }
}
