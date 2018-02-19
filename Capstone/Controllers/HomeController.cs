using Microsoft.AspNetCore.Mvc;

namespace Capstone.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("<h1>Bill & Mike Law Firm</h1>", "text/html");
        }
    }
}
