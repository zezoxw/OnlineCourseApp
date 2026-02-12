namespace OnlineCourseApp.Domain.Courses
{
    public class Module
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }

        // later we can add a list of lessons and quizzes to the module
        public List<Quiz> Quizzes { get; set; } = new List<Quiz>();
    }
}
