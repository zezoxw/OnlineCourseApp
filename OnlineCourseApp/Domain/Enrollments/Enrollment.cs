using OnlineCourseApp.Domain.Courses;
using OnlineCourseApp.Domain.Instructors;
using OnlineCourseApp.Domain.Students;

namespace OnlineCourseApp.Domain.Enrollments
{
    public class Enrollment
    {
        public int Id { get; set; }
        public DateTime EnrolledAt { get; set; }
        public string Status { get; set; } // Make it a nonNull value leater

        // explicit FKs
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public int InstructorId { get; set; }

        // navigation properties - Make them a nonNull value leater
        public Student student { get; set; }
        public Course course { get; set; }
        public Instructor instructor { get; set; }
    
    }
}
