﻿using Microsoft.AspNetCore.Mvc;

namespace Capstone.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("<h1>Bill & Mike Law Firm</h1>", "text/html");
        }
        [Route("/About")]
        public IActionResult About()
        { 
            return Content("<h1>This is Bill, This is Mike</h1>", "text/html");
        }
        [Route("/Contact")]
        public IActionResult Contact()
        {
            return Content("<h1>This is where Bill and Mikes office is located</h1>", "text/html");
        }
        [Route("/ClientInfo")]
        public IActionResult ClientInfo()
        {
            return Content("<h1>Helpful information for clients</h1>", "text/html");
        }
        [Route("/PublicInfo")]
        public IActionResult PublicInfo()
        {
            return Content("<h1>Headings</h1>", "text/html");
        }
    }
}
