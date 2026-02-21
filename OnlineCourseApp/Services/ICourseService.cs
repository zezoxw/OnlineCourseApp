using CourseWebsite.Models.Courses;

namespace CourseWebsite.Services
{
    public interface ICourseService
    {
        List<CourseListItemModel> GetAllCourses();
        CourseDetailsModel GetCourseDetails(int courseId);
    }
}
