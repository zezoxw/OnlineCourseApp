using OnlineCourseApp.Domain.Instructors;

namespace OnlineCourseApp.Domain.Courses
{
    public class Course
    {
        public int Id { get; set; }
        public Instructor instructor { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }// make it optional later
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public List<Module> Modules { get; set; } = new List<Module>();
        // later we can add a list of students enrolled in the course
        // later we can add a category or tags for the course

    }
}
