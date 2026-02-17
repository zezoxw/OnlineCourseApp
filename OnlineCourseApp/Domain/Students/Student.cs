using OnlineCourseApp.Domain.Courses;
using OnlineCourseApp.Domain.Enrollments;

namespace OnlineCourseApp.Domain.Students
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // later we can change it to DateTime for DOB
        public int Age { get; set; }
        // later we can constrain it to be unique and format it as an email address
        public string Email { get; set; }
        public List<Course> courses { get; set; } = new List<Course>();
        // inverse navigation for enrollments
        public List<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}
