using Microsoft.EntityFrameworkCore;
using OnlineCourseApp.Domain.Students;
using System.Threading.Tasks;

namespace OnlineCourseApp.Infrastructure.Database.Students
{
    public class EfCoreStudentRepo : IStudentRepo
    {

        private readonly CourseWebsiteDbContext _context;
        public EfCoreStudentRepo(CourseWebsiteDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }
        public async Task DeleteAsync(int id)
        {
            var student = await _context.Students.FirstOrDefaultAsync(s => s.Id == id);
            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }
        }

        public async Task UpdateAsync(Student UpdatedStudent)
        {
            {
                var student = await _context.Students.FirstOrDefaultAsync(e => e.Id == UpdatedStudent.Id);
                if (student != null)
                {
                    student.Age = UpdatedStudent.Age;
                    student.Name = UpdatedStudent.Name;
                    student.Email = UpdatedStudent.Email;// Leater make a sepert update for email
                    // Leater enable updateing instructor and Module

                }
                _context.SaveChanges();

            }

        }
        public async Task<Student> GetByIdAsync(int id)
        {

            var result = await _context.Students.FirstOrDefaultAsync(s => s.Id == id);
            if (result == null)
            {
                // Fix it leater 
                throw new Exception($"no entity with Id {id}");
            }
            return result;
        }
        // Not figer it yet 
        public async Task<List<Student>> GetAllAsync(int Id, int? pageIndex, int? pageSize)
        {
            var result = new List<Student>();


            // Need to add exciption if the list is empty or a massge
            return result;

        }
    }
}
