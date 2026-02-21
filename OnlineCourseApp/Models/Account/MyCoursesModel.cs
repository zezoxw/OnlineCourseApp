
namespace CourseWebsite.Models.Account
{
    public class MyCoursesModel
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public List<MyCourseItemModel> Courses { get; set; }
    }
}
