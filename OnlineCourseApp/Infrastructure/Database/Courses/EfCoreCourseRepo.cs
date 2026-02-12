using OnlineCourseApp.Domain.Courses;

namespace OnlineCourseApp.Infrastructure.Database.Courses
{
    public class EfCoreCourseRepo : ICourseRepo
    {
        private static int _nextId = 1;
        private static List<Course> _courses = new List<Course>();

        public static int Add(Course course)
        {
            course.Id = _nextId++;
            _courses.Add(course);
            return course.Id;
        }
        public static void Delete(int id)
        {
            var course = _courses.FirstOrDefault(c => c.Id == id);
            if (course != null)
            {
                _courses.Remove(course);
            }
        }
        public static List<Course> GetAllCourses()
        {
            return _courses;
        }
        public static void Update(Course updatedCourse)
        {
            var course = _courses.FirstOrDefault(c => c.Id == updatedCourse.Id);
            if (course != null)
            {
                course.Title = updatedCourse.Title;
                course.Description = updatedCourse.Description;
                course.instructor = updatedCourse.instructor;
                // later we will add the update of modules and price
            }
        }
    }
}
