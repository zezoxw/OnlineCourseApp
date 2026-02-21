using Microsoft.EntityFrameworkCore;
using OnlineCourseApp.Domain.Courses;
using System.Security.Cryptography;

namespace OnlineCourseApp.Infrastructure.Database.Courses
{
    public class EfCoreCourseRepo : ICourseRepo
    {
        private readonly CourseWebsiteDbContext _context;
        public EfCoreCourseRepo(CourseWebsiteDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }
        public async Task DeleteAsync(int id)
        {
            var course = await _context.Courses.FirstOrDefaultAsync(c => c.Id == id);
            if (course != null)
            {
                _context.Courses.Remove(course);
                _context.SaveChanges();
            }
        }

        public async Task UpdateAsync(Course UpdatedCourse)
        {
            {
                var course = await _context.Courses.FirstOrDefaultAsync(ch => ch.Id == UpdatedCourse.Id);
                if (course != null)
                {
                    course.Title = UpdatedCourse.Title;
                    course.Description = UpdatedCourse.Description;
                    course.Price = UpdatedCourse.Price;
                    // Leater enable updateing instructor and Module

                }
                _context.SaveChanges();

            }

        }
        public async Task<Course> GetByIdAsync(int id)
        {

            var result = await _context.Courses.FirstOrDefaultAsync(c => c.Id == id);
            if (result == null)
            {
                // Fix it leater 
                throw new Exception($"no entity with Id {id}");
            }
            return result;
        }
     
        // Not finished yet
        public async Task<List<Course>> GetAllAsync(int IId, int? pageIndex, int? pageSize)
        {
            var result = new List<Course>();
            foreach (var c in _context.Courses)
            {
                if (c.InstructorId == IId)
                {
                    result.Add(c);
                }

            }
            // Need to add exciption if the list is empty or a massge
            return result;
        }
    }
}
