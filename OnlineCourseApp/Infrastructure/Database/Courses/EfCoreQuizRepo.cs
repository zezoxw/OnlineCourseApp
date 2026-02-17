using Microsoft.EntityFrameworkCore;
using OnlineCourseApp.Domain.Courses;
using OnlineCourseApp.Infrastructure.Database;
using OnlineCourseApp.Infrastructure.Database.Courses;

namespace OnlineCourseApp.Infrastructure.Database.Courses
{
    public class EfCoreQuizRepo : IQuizRepo
    {


        private readonly CourseWebsiteDbContext _context;
        public EfCoreQuizRepo(CourseWebsiteDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Quiz quiz)
        {
            _context.Quizs.Add(quiz);
            _context.SaveChanges();
        }
        public async Task DeleteAsync(int id)
        {
            var quiz = await _context.Quizs.FirstOrDefaultAsync(q => q.Id == id);
            if (quiz != null)
            {
                _context.Quizs.Remove(quiz);
                _context.SaveChanges();
            }
        }

        public async Task UpdateAsync(Quiz UpdatedQuiz)
        {
            {
                var quiz = await _context.Quizs.FirstOrDefaultAsync(q => q.Id == UpdatedQuiz.Id);
                if (quiz != null)
                {
                    quiz.Title = UpdatedQuiz.Title;
                  // Leater will add function to add the qusition

                }
                _context.SaveChanges();

            }

        }
        public async Task<Quiz> GetByIdAsync(int id)
        {

            var result = await _context.Quizs.FirstOrDefaultAsync(q => q.Id == id);
            if (result == null)
            {
                // Fix it leater 
                throw new Exception($"no entity with Id {id}");
            }
            return result;
        }
        // Take the Modul id and return all the Quizs
        public async Task<List<Quiz>> GetAllAsync(int MId, int? pageIndex, int? pageSize)
        {
            var result = new List<Quiz>();
            foreach (var q in _context.Quizs)
            {
                if (q.ModuleId == MId)
                {
                    result.Add(q);
                }

            }
            // Need to add exciption if the list is empty or not?
            return result;

        }
    }
}
