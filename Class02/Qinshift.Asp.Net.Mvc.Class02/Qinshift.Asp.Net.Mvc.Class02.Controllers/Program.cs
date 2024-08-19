using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing.Constraints;

namespace Qinshift.Asp.Net.Mvc.Class02.Controllers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                //Configuring the MVC middleware to the request processing pipeline
                endpoints.MapDefaultControllerRoute();
            });


            // Conventional routing

            app.MapControllerRoute("default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.MapControllerRoute("allCourses",
                pattern: "courses/allcourses",
                defaults: new { controller = "Courses", action = "GetAllCourses" });

            //app.MapControllerRoute("course_by_id",
            //    pattern: "courses/{id}",
            //    defaults: new { controller = "Courses", action = "GetCourseById" });

            app.MapControllerRoute("course_by_name_with_constraint",
                pattern: "courses/{name:string}",
                defaults: new { controller = "Courses", action = "GetCourseByName" },
                constraints: new { name = new MinLengthRouteConstraint(5) }); // Length constraint: min 5 characters);

            app.MapControllerRoute("course_with_default_value",
                pattern: "courses/{id}",
                defaults: new { controller = "Courses", action = "GetCourse" });

            app.MapControllerRoute("couses_multiple_params",
                pattern: "courses/{index}/{name}",
                defaults: new { controller = "Courses", action = "GetCourseByIdOrName" });


            app.Run();
        }
    }
}
