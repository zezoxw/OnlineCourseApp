using CourseWebsite.Models.Account;

namespace CourseWebsite.Services
{
    public interface IStudentService
    {
        MyCoursesModel GetMyCourses(int studentId);
        StudentProfileModel GetProfile(int studentId);
        StudentSettingModel GetSettings(int studentId);
        void UpdateSettings(int studentId, StudentSettingModel model);
        void EnrollInCourse(int studentId, int courseId);
        void UnEnrollFromCourse(int studentId, int courseId);
    }
}
