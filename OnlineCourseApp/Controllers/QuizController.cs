using Microsoft.AspNetCore.Mvc;

namespace OnlineCourseApp.Controllers
{
    public class QuizController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
