using Microsoft.EntityFrameworkCore;
using OnlineCourseApp.Domain.Courses;

namespace OnlineCourseApp.Infrastructure.Database.Courses
{
    public class EfCoreQuestionRepo : IQuestionRepo
    {
        private readonly CourseWebsiteDbContext _context;
        public EfCoreQuestionRepo(CourseWebsiteDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Question question)
        {
            _context.Questions.Add(question);
            _context.SaveChanges();
        }
        public async Task DeleteAsync(int id)
        {
            var question = await _context.Questions.FirstOrDefaultAsync(qu => qu.Id == id);
            if (question != null)
            {
                _context.Questions.Remove(question);
                _context.SaveChanges();
            }
        }

        public async Task UpdateAsync(Question UpdatedQuestion)
        {
            {
                var question = await _context.Questions.FirstOrDefaultAsync(ch => ch.Id == UpdatedQuestion.Id);
                if (question != null)
                {
                    question.Text = UpdatedQuestion.Text;
                    question.Choices = UpdatedQuestion.Choices;
                    _context.SaveChanges();

                }
                _context.SaveChanges();

            }

        }
        public async Task<Question> GetByIdAsync(int id)
        {

            var result = await _context.Questions.FirstOrDefaultAsync(qu => qu.Id == id);
            if (result == null)
            {
                // Fix it leater 
                throw new Exception($"no entity with Id {id}");
            }
            return result;
        }
        // Take the Quiz id and return all the Quistion of the Quiz
        public async Task<List<Question>> GetAllAsync(int Id, int? pageIndex, int? pageSize)
        {
            var result = new List<Question>();
            foreach (var qu in _context.Questions)
            {
                if (qu.QuizId == Id)
                {
                    result.Add(qu);
                }

            }
            // Need to add exciption if the list is empty
            return result;

        }

    }
}
