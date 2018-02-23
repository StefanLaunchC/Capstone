using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Capstone.Controllers
{
    public class HomeController : Controller
    {
        static private List<string> Infos = new List<string>();

        public IActionResult Index()
        {
            return View();
        }
        [Route("/About")]
        public IActionResult About()
        {
            return View();
        }
        [Route("/Contact")]
        public IActionResult Contact()
        {
            return View(); 
        }
        [Route("/ClientInfo")]
        public IActionResult ClientInfo()
        {
            ViewBag.Infos = Infos;
            return View(); 
        }
        
        [Route("/Info/Add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/Info/Add")]
        public IActionResult NewArticle(string name)
        {
            Infos.Add(name);
            return Redirect("/ClientInfo");
        }

        [Route("/PublicInfo")]
        public IActionResult PublicInfo()
        {
            return View(); 
        }
    }
}
