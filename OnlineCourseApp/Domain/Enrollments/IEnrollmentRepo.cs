using OnlineCourseApp.Domain.Courses;

namespace OnlineCourseApp.Domain.Enrollments
{
    public interface IEnrollmentRepo
    {
        Task AddAsync(Enrollment enrollment);
        Task DeleteAsync(int id);
        Task UpdateAsync(Enrollment UpdatedEnrollment);
        Task<Enrollment> GetByIdAsync(int id);
        Task<List<Enrollment>> GetAllAsync(int Id, int? pageIndex, int? pageSize);
    }
}
