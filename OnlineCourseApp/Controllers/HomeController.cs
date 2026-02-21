using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OnlineCourseApp.Models;

namespace OnlineCourseApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult About()
        {
            return View();
        }

 
        public IActionResult OurTeam()
        {
            return View();
        }

        public IActionResult FAQ()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ContactUs()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ContactUs(string name, string email, string message)
        {
            // Leater will add the logic to contact as 
            return RedirectToAction("Index");
        }





        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}

    }
}
