namespace DemoEf.Database.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfClasses { get; set; }

        // add this property for second migration 
        public bool IsActiveCourse { get; set; }
    }
}
