using OnlineCourseApp.Domain.Courses;
using OnlineCourseApp.Domain.Instructors;
using OnlineCourseApp.Domain.Students;

namespace OnlineCourseApp.Domain.Enrollments
{
    public class Enrollment
    {
        public int Id { get; set; }
        public Student student { get; set; }
        public Course course { get; set; }
        public string Status { get; set; }
        public Instructor instructor { get; set; }
        public DateTime EnrolledAt { get; set; }
    }
}
