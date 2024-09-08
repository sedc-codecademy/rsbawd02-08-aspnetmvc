namespace DemoEf.Services
{
    public class StudentDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string ParentName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int ActiveCourseId { get; set; }

    }
}