using Microsoft.AspNetCore.Mvc;

namespace Qinshift.Asp.Net.Class05.App.Controllers
{
    [Route("home")]
    public class HomeController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
