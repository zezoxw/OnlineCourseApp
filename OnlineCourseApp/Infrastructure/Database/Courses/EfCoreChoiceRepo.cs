using OnlineCourseApp.Domain.Courses;

namespace OnlineCourseApp.Infrastructure.Database.Courses
{
    public class EfCoreChoiceRepo : IChoiceRepo
    {
        private static int _nextId = 1;
        private static List<Choice> _choices = new List<Choice>();

        public static int Add(Choice choice)
        {
            choice.Id = _nextId++;
            _choices.Add(choice);
            return choice.Id;
        }
        public static void Delete(int id)
        {
            var choice = _choices.FirstOrDefault(c => c.Id == id);
            if (choice != null)
            {
                _choices.Remove(choice);
            }
        }
        public static global::System.Collections.Generic.List<Choice> GetAllChoices()
        {
            return _choices;
        }
        public static void Update(Choice updatedChoice)
        {
            var choice = _choices.FirstOrDefault(c => c.Id == updatedChoice.Id);
            if (choice != null)
            {
                choice.Text = updatedChoice.Text;
                choice.IsCorrect = updatedChoice.IsCorrect;
                choice.QuestionId = updatedChoice.QuestionId;
            }
        }


    }
}
