using OnlineCourseApp.Domain.Students;

namespace OnlineCourseApp.Domain.Courses
{
    public interface IQuizRepo
    {
        Task AddAsync(Quiz quiz);
        Task DeleteAsync(int id);
        Task UpdateAsync(Quiz UpdatedQuiz);
        Task<Quiz> GetByIdAsync(int id);
        Task<List<Quiz>> GetAllAsync(int Id, int? pageIndex, int? pageSize);

    }
}
