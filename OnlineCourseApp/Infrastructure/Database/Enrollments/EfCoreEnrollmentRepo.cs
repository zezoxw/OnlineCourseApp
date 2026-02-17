using Microsoft.EntityFrameworkCore;
using OnlineCourseApp.Domain.Courses;
using OnlineCourseApp.Domain.Enrollments;

namespace OnlineCourseApp.Infrastructure.Database.Enrollments
{
    public class EfCoreEnrollmentRepo : IEnrollmentRepo
    {
        private readonly CourseWebsiteDbContext _context;
        public EfCoreEnrollmentRepo(CourseWebsiteDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Enrollment enrollment)
        {
            _context.Enrollments.Add(enrollment);
            _context.SaveChanges();
        }
        public async Task DeleteAsync(int id)
        {
            var enrollment = await _context.Enrollments.FirstOrDefaultAsync(e => e.Id == id);
            if (enrollment != null)
            {
                _context.Enrollments.Remove(enrollment);
                _context.SaveChanges();
            }
        }

        public async Task UpdateAsync(Enrollment UpdatedEnrollment)
        {
            {
                var enrollment = await _context.Enrollments.FirstOrDefaultAsync(e => e.Id == UpdatedEnrollment.Id);
                if (enrollment != null)
                {
                    enrollment.student = UpdatedEnrollment.student;
                    enrollment.course = UpdatedEnrollment.course;
                    enrollment.instructor = UpdatedEnrollment.instructor;
                    // Leater enable updateing instructor and Module

                }
                _context.SaveChanges();

            }

        }
        public async Task<Enrollment> GetByIdAsync(int id)
        {

            var result = await _context.Enrollments.FirstOrDefaultAsync(e => e.Id == id);
            if (result == null)
            {
                // Fix it leater 
                throw new Exception($"no entity with Id {id}");
            }
            return result;
        }
        // Take the Course id and return all the Enrollment of the Course
        public async Task<List<Enrollment>> GetAllAsync(int CId, int? pageIndex, int? pageSize)
        {
            var result = new List<Enrollment>();
            foreach (var enrollment in _context.Enrollments)
            {
                if (enrollment.CourseId == CId)
                {
                    result.Add(enrollment);
                }

            }

            // Need to add exciption if the list is empty or a massge
            return result;

        }

    }
}
