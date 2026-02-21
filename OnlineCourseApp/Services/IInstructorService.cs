using CourseWebsite.Models.Instructors;

namespace CourseWebsite.Services
{
    public interface IInstructorService
    {
        InstructorCoursesModel GetMyCourses(int instructorId);
        InstructorProfileModel GetProfile(int instructorId);
    }
}
