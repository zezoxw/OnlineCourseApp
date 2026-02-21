using OnlineCourseApp.Domain.Students;

namespace OnlineCourseApp.Domain.Courses
{
    public interface IModuleRepo
    {
        Task AddAsync(Module module);
        Task DeleteAsync(int id);
        Task UpdateAsync(Module UpdatedModule);
        Task<Module> GetByIdAsync(int id);
        Task<List<Module>> GetAllAsync(int Id, int? pageIndex, int? pageSize);
    }
}
