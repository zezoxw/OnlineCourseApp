namespace OnlineCourseApp.Domain.Courses
{
    public class Quiz
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ModuleId { get; set; }
        public Module Module { get; set; }
        // add a list of questions to the quiz
        public List<Question> Questions { get; set; } = new List<Question>();
    }
}
