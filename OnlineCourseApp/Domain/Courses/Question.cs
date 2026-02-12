namespace OnlineCourseApp.Domain.Courses
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int QuizId { get; set; }
        public Quiz Quiz { get; set; }
        // later we can limit the number of choices to 4 and add a property for the correct answer
        public List<Choice> Choices { get; set; } = new List<Choice>();
    }
}
