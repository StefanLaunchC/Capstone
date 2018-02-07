using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Capstone.Controllers
{
    public class MainController : Controller
    {
        // GET: /<controller>/
        public IActionResult Home()
        {
            return Content("<h1>Herzlich Willkommen!</h1>", "text?/html");
        }

        public IActionResult AboutUs()
        {
            return Content("MIKE and BILL");
        }

        public IActionResult Location_Contact()
        {
            return Content("Google Map Link");
        }

        public IActionResult Appointment_Calendar()
        {
            return Content("calender to shedule appointments");
        }
    }
}
