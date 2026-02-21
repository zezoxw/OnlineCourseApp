using Microsoft.EntityFrameworkCore;
using OnlineCourseApp.Domain.Enrollments;
using OnlineCourseApp.Domain.Instructors;

namespace OnlineCourseApp.Infrastructure.Database.Instructors
{
    public class EfCoreInstructorRepo : IInstructorRepo
    {
        private readonly CourseWebsiteDbContext _context;
        public EfCoreInstructorRepo(CourseWebsiteDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Instructor instructor)
        {
            _context.Instructors.Add(instructor);
            _context.SaveChanges();
        }
        public async Task DeleteAsync(int id)
        {
            var instructor = await _context.Instructors.FirstOrDefaultAsync(i => i.Id == id);
            if (instructor != null)
            {
                _context.Instructors.Remove(instructor);
                _context.SaveChanges();
            }
        }

        public async Task UpdateAsync(Instructor UpdatedInstructor)
        {
            {
                var instructor = await _context.Instructors.FirstOrDefaultAsync(e => e.Id == UpdatedInstructor.Id);
                if (instructor != null)
                {
                    instructor.Name = UpdatedInstructor.Name;
                    instructor.Age = UpdatedInstructor.Age;
                    instructor.Email = UpdatedInstructor.Email;
                    // Leater will enable updating courses 
                }
                _context.SaveChanges();

            }

        }
        public async Task<Instructor> GetByIdAsync(int id)
        {

            var result = await _context.Instructors.FirstOrDefaultAsync(i => i.Id == id);
            if (result == null)
            {
                // Fix it leater 
                throw new Exception($"no entity with Id {id}");
            }
            return result;
        }
        // Need to be fixed
        public async Task<List<Instructor>> GetAllAsync(int Id, int? pageIndex, int? pageSize)
        {
            var result = new List<Instructor>();
            //foreach (var instructor in _context.Instructors)
            //{
            //    if (instructor == Id)
            //    {
            //        result.Add(instructor);
            //    }

            //}

            // Need to add exciption if the list is empty or a massge
            return result;

        }


    }
}
