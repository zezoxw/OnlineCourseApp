using OnlineCourseApp.Domain.Courses;

namespace OnlineCourseApp.Infrastructure.Database.Courses
{
    public class EfCoreQuestionRepo : IQuestionRepo
    {
        private static int _nextId = 1;
        private static List<Question> _questions = new List<Question>();
        public static int Add(Question question)
        {
            question.Id = _nextId++;
            _questions.Add(question);
            return question.Id;
        }
        public static void Delete(int id)
        {
            var question = _questions.FirstOrDefault(q => q.Id == id);
            if (question != null)
            {
                _questions.Remove(question);
            }
        }
        public static List<Question> GetAllQuestions()
        {
            return _questions;
        }
        public static Question? GetById(int id)
        {
            return _questions.FirstOrDefault(q => q.Id == id);
        }

    }
}
