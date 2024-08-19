using Microsoft.AspNetCore.Mvc;

namespace Qinshift.Asp.Net.Mvc.Class02.Controllers.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello class, we are returning result via HTTP";
        }
    }
}
