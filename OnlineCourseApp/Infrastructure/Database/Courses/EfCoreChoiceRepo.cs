using Microsoft.EntityFrameworkCore;
using OnlineCourseApp.Domain.Courses;
using OnlineCourseApp.Infrastructure.Database;

namespace OnlineCourseApp.Infrastructure.Database.Courses
{
    public class EfCoreChoiceRepo : IChoiceRepo
    {
        private readonly CourseWebsiteDbContext _context;
        public EfCoreChoiceRepo(CourseWebsiteDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Choice choice)
        {
             _context.Choices.Add(choice);
             _context.SaveChanges();
        }
        public async Task DeleteAsync(int id)
        {
            var choice = await _context.Choices.FirstOrDefaultAsync(ch => ch.Id == id);
            if (choice != null)
            {
                _context.Choices.Remove(choice);
                _context.SaveChanges();
            }
        }
        
        public async Task UpdateAsync(Choice updatedChoice)
        {
            {
                var choice = await _context.Choices.FirstOrDefaultAsync(ch => ch.Id == updatedChoice.Id);
                if (choice != null)
                {
                    choice.Text = updatedChoice.Text;
                    choice.IsCorrect = updatedChoice.IsCorrect;

                }
                _context.SaveChanges();

            }

        }
        public async Task<Choice> GetByIdAsync(int id)
        {

            var result = await _context.Choices.FirstOrDefaultAsync(ch => ch.Id == id);
            if (result == null)
            {
                // Fix it leater 
                throw new Exception($"no entity with Id {id}");
            }
            return result;
        }
        // Take the Qusiton id and return all the Quistion choices
        public async Task<List<Choice>> GetAllAsync(int QId, int? pageIndex, int? pageSize)
        {
            var result  = new List<Choice>();
            foreach (var ch in _context.Choices)
            {
                if (ch.QuestionId == QId)
                {
                    result.Add(ch);
                }

            }
            // Need to add exciption if the list is empty
            return result;
           
        }

    }
}
