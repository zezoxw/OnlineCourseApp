using Microsoft.AspNetCore.Mvc;

namespace OnlineCourseApp.Controllers
{
    public class InstructoresController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
