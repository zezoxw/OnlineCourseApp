using OnlineCourseApp.Domain.Courses;
using OnlineCourseApp.Domain.Enrollments;

namespace OnlineCourseApp.Domain.Instructors
{
    // Later add a Employee class and make a job titel that contain Instructor 
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // later we can change it to DateTime for DOB
        public int Age { get; set; }
        // later we can constrain it to be unique and format it as an email address
        public string Email { get; set; }
        // navigation - initialize to avoid null refs
        public List<Course> Courses { get; set; } = new List<Course>();

        // inverse navigation for enrollments
        public List<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}
