using CourseWebsite.Services;
using Microsoft.AspNetCore.Mvc;

namespace OnlineCourseApp.Controllers
{
    public class InstructoresController : Controller
    {
        private readonly IInstructorService _instructorService;

        public InstructoresController(IInstructorService instructorService)
        {
            _instructorService = instructorService;
        }

        // Find a way to get the instructer id
        //public IActionResult MyCourses()
        //{
        //    return View(_instructorService.GetMyCourses());
        //}
    }
}
