using Microsoft.EntityFrameworkCore;

namespace OnlineCourseApp.Infrastructure.Database
{
    public class CourseWebsiteDbContext : DbContext
    {

        public CourseWebsiteDbContext(DbContextOptions<CourseWebsiteDbContext> options) : base(options)
        {
        }
    }
}
