namespace CourseWebsite.Models.Instructors
{
    public class InstructorProfileModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        // Leater will make it as course object so the instructer can access the course detile
        public int CoursesCount { get; set; }
        public int TotalStudents { get; set; }
    }
}
