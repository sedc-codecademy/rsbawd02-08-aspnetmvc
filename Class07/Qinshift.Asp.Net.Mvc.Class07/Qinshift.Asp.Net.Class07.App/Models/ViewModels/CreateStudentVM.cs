using System;
using System.ComponentModel.DataAnnotations;

namespace Qinshift.Asp.Net.Class07.App.Models.ViewModels
{
    public class CreateStudentVM
    {
        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string FirstName { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string LastName { get; set; }

        [MaxLength(50)]
        public string Description { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }
    }
}
