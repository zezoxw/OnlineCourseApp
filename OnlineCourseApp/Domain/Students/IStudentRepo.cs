using OnlineCourseApp.Domain.Enrollments;

namespace OnlineCourseApp.Domain.Students
{
    public interface IStudentRepo
    {
        Task AddAsync(Student student);
        Task DeleteAsync(int id);
        Task UpdateAsync(Student UpdatedStudent);
        Task<Student> GetByIdAsync(int id);
        Task<List<Student>> GetAllAsync(int SId, int? pageIndex, int? pageSize);
    }
}
