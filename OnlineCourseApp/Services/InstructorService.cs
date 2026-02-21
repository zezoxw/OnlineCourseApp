using CourseWebsite.Models.Instructors;
using Microsoft.EntityFrameworkCore;

namespace CourseWebsite.Services
{
    public class InstructorService : IInstructorService
    {
        public InstructorCoursesModel GetMyCourses(int instructorId)
        {
            var instructor = _context.Instructors
                .Include(i => i.Courses)
                    .ThenInclude(c => c.Students)
                .First(i => i.Id == instructorId);

            return new InstructorCoursesModel
            {
                InstructorId = instructor.Id,
                InstructorName = instructor.Name,
                Courses = instructor.Courses.Select(c => new InstructorCourseItemModel
                {
                    CourseId = c.Id,
                    Title = c.Title,
                    Price = c.Price,
                    StudentsCount = c.Students.Count,
                    CreatedAt = c.CreatedAt
                }).ToList()
            };
        }
    }
}
