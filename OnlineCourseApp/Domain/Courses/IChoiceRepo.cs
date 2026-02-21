using OnlineCourseApp.Domain.Students;

namespace OnlineCourseApp.Domain.Courses
{
    public interface IChoiceRepo
    {
        Task AddAsync(Choice choice);
        Task DeleteAsync(int id);
        Task UpdateAsync(Choice UpdatedChoice);
        Task<Choice> GetByIdAsync(int id);
        Task<List<Choice>> GetAllAsync(int Id, int? pageIndex, int? pageSize);
    }
}
