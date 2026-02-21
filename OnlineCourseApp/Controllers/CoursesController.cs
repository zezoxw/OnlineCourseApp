using CourseWebsite.Services;
using Microsoft.AspNetCore.Mvc;

namespace OnlineCourseApp.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ICourseService _courseService;

        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public IActionResult Index()
        {
            return View(_courseService.GetAllCourses  );
        }

        public IActionResult Details(int id)
        {
            return View(_courseService.GetCourseDetails);

        }

    }
}
