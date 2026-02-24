
using System.ComponentModel.DataAnnotations;

namespace CourseWebsite.Models.Account
{
    public class MyCoursesModel
    {
        [Required]
        // Range?
        public int StudentId { get; set; }
        [Required]
        [StringLength(50)]
        public string StudentName { get; set; } = string.Empty;
        public List<MyCourseItemModel>? Courses { get; set; }
    }
}
