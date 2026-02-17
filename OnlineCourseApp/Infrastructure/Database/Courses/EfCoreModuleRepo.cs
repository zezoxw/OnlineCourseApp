using Microsoft.EntityFrameworkCore;
using OnlineCourseApp.Domain.Courses;

namespace OnlineCourseApp.Infrastructure.Database.Courses
{
    public class EfCoreModuleRepo : IModuleRepo
    {
        private readonly CourseWebsiteDbContext _context;
        public EfCoreModuleRepo(CourseWebsiteDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Module module)
        {
            _context.Modules.Add(module);
            _context.SaveChanges();
        }
        public async Task DeleteAsync(int id)
        {
            var module = await _context.Modules.FirstOrDefaultAsync(m => m.Id == id);
            if (module != null)
            {
                _context.Modules.Remove(module);
                _context.SaveChanges();
            }
        }

        public async Task UpdateAsync(Module UpdatedModule)
        {
            {
                var module = await _context.Modules.FirstOrDefaultAsync(ch => ch.Id == UpdatedModule.Id);
                if (module != null)
                {
                    module.Title = UpdatedModule.Title;
                    // leater will add updateing quiz

                }
                _context.SaveChanges();

            }

        }
        public async Task<Module> GetByIdAsync(int id)
        {

            var result = await _context.Modules.FirstOrDefaultAsync(m => m.Id == id);
            if (result == null)
            {
                // Fix it leater 
                throw new Exception($"no entity with Id {id}");
            }
            return result;
        }
        // Take the Course id and return all the Module of the Course
        public async Task<List<Module>> GetAllAsync(int CId, int pageIndex, int pageSize)
        {
            var result = new List<Module>();
            foreach (var m in _context.Modules)
            {
                if (m.CourseId == CId)
                {
                    result.Add(m);
                }

            }
            // Need to add exciption if the list is empty
            return result;

        }

    }
}
