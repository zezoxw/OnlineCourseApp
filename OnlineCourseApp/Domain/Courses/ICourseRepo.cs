using OnlineCourseApp.Domain.Students;

namespace OnlineCourseApp.Domain.Courses
{
    public interface ICourseRepo
    {
        Task AddAsync(Course course);
        Task DeleteAsync(int id);
        Task UpdateAsync(Course UpdatedCourse);
        Task<Course> GetByIdAsync(int id);
        Task<List<Course>> GetAllAsync(int Id, int? pageIndex, int? pageSize);
    }
}
