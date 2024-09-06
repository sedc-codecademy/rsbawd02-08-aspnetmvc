using DemoEf.Database.Entities;
using Microsoft.EntityFrameworkCore;


namespace TodoWebApp.Database
{
    public class DemoDbContext : DbContext
    {
        public  DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        public DemoDbContext(DbContextOptions options) : base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var Courses = new List<Course>()
            {
                new() { Id = 1, Name = "C# basic", NumberOfClasses = 40 },
                new() { Id = 2, Name = "C# Advanced", NumberOfClasses = 60 },
                new() { Id = 3, Name = "Database development and design", NumberOfClasses = 28 },
                new() { Id = 4, Name = "ASP.NET Mvc", NumberOfClasses = 40 }
            };
            var Students = new List<Student>
            {
                new Student()
                {
                    Id = 1,
                    FirstName = "Bob",
                    ParentName="David",
                    LastName = "Bobski",
                    DateOfBirth = DateTime.Now.AddYears(-27),
                    ActiveCourseId = 4
                },
                new Student()
                {
                    Id = 2,
                    FirstName = "Jill",
                    ParentName="Milena",
                    LastName = "Jilski",
                    DateOfBirth = DateTime.Now.AddYears(-37),
                    ActiveCourseId = 4
                },
                new Student()
                {
                    Id = 3,
                    FirstName = "John",
                    ParentName="Jovan",
                    LastName = "Doe",
                    DateOfBirth = DateTime.Now.AddYears(-45),
                    ActiveCourseId = 4
                },
                new Student()
                {
                    Id = 4,
                    FirstName = "Jane",
                    ParentName="Ana",
                    LastName = "Doe",
                    DateOfBirth = DateTime.Now.AddYears(-17),
                    ActiveCourseId = 4
                },
        };
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Course>().HasData(Courses);
            modelBuilder.Entity<Student>().HasData(Students);
        }
       
    }
}
