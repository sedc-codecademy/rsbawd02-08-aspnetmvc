using DemoFilterAnsMiddleware.Filters;
using DemoFilterAnsMiddleware.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoFilterAnsMiddleware.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [AuthorizationFilter]
        public IActionResult Weather(string apiKey) {

           
            return new JsonResult(new WeatherData()
            {
                City = "New York",
                Temperature = "10"
            });
        }

        [AuthorizationFilter]       
        public IActionResult UvRadiation(string apiKey) {      


            return new OkResult();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
