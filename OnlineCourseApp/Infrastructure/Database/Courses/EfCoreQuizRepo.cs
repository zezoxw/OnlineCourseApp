using OnlineCourseApp.Domain.Courses;

namespace OnlineCourseApp.Infrastructure.Database.Courses
{
    public class EfCoreQuizRepo : IQuizRepo
    {
        private static int _nextId = 1;
        private static List<Quiz> _quizzes = new List<Quiz>();
        public static int Add(Quiz quiz)
        {
            quiz.Id = _nextId++;
            _quizzes.Add(quiz);
            return quiz.Id;
        }
        public static void Delete(int id)
        {
            var quiz = _quizzes.FirstOrDefault(q => q.Id == id);
            if (quiz != null)
            {
                _quizzes.Remove(quiz);
            }
        }
        public static List<Quiz> GetAllQuizzes()
        {
            return _quizzes;
        }
        public static Quiz? GetQuizById(int id)
        {
            return _quizzes.FirstOrDefault(q => q.Id == id);
        }
        public static void Update(Quiz quiz)
        {
            var existingQuiz = _quizzes.FirstOrDefault(q => q.Id == quiz.Id);
            if (existingQuiz != null)
            {
                existingQuiz.Title = quiz.Title;
                existingQuiz.Questions = quiz.Questions;
            }
        }
    }
    }
