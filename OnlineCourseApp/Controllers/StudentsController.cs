using CourseWebsite.Services;
using Microsoft.AspNetCore.Mvc;

namespace OnlineCourseApp.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public IActionResult MyCourses()
        {
            return View();//_studentService.GetMyCourses(CurrentStudentId)
        }

        //[HttpPost]
        //public IActionResult Enroll(int courseId)
        //{
        //    _studentService.Enroll(CurrentStudentId, courseId);
        //    return RedirectToAction("MyCourses");
        //}

        //[HttpPost]
        //public IActionResult UnEnroll(int courseId)
        //{
        //    _studentService.UnEnroll(CurrentStudentId, courseId);
        //    return RedirectToAction("MyCourses");
        //}
    }
}
