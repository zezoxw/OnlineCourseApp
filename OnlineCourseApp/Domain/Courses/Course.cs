using OnlineCourseApp.Domain.Instructors;
using OnlineCourseApp.Domain.Students;

namespace OnlineCourseApp.Domain.Courses
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }// make it optional later
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
      
        // explicit FK
        public int? InstructorId { get; set; }
        public Instructor instructor { get; set; }
        public List<Module> Modules { get; set; } = new List<Module>();
        public List<Student> students { get; set; } = new List<Student>();
        
        // later we can add a category or tags for the course

    }
}
