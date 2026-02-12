using Microsoft.AspNetCore.Mvc;

namespace OnlineCourseApp.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
