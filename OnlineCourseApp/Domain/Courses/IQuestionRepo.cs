using OnlineCourseApp.Domain.Students;

namespace OnlineCourseApp.Domain.Courses
{
    public interface IQuestionRepo
    {
        Task AddAsync(Question question);
        Task DeleteAsync(int id);
        Task UpdateAsync( Question UpdatedQuestion);
        Task<Question> GetByIdAsync(int id);
        Task<List<Question>> GetAllAsync(int SId, int? pageIndex, int? pageSize);
    }
}
