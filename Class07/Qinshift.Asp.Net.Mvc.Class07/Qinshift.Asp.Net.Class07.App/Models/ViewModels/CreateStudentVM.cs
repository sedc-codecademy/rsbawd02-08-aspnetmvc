using System;
using System.ComponentModel.DataAnnotations;

namespace Qinshift.Asp.Net.Class07.App.Models.ViewModels
{
    public class CreateStudentVM
    {
       
        public string FirstName { get; set; }
     
        public string LastName { get; set; }

       
        public string Description { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }
    }
}
