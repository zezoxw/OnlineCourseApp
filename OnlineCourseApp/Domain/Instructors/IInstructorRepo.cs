using OnlineCourseApp.Domain.Courses;

namespace OnlineCourseApp.Domain.Instructors
{
    public interface IInstructorRepo
    {
        Task AddAsync(Instructor instructor);
        Task DeleteAsync(int id);
        Task UpdateAsync(Instructor UpdatedInstructer);
        Task<Instructor> GetByIdAsync(int id);
        Task<List<Instructor>> GetAllAsync(int Id, int? pageIndex, int? pageSize);
    }
}
