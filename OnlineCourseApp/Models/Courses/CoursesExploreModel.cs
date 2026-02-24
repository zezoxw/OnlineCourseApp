using System.ComponentModel.DataAnnotations;

namespace CourseWebsite.Models.Courses
{
    public class CoursesExploreModel
    {
        // For Search you can use any of the property to find the course.
        [Range(0,1000)]
        public int? Id { get; set; }
        [StringLength(50)]
        public string? Title { get; set; }
        [Range(0.01, 10000)]
        [RegularExpression(@"^\d+(\.\d{1,2})?$",
       ErrorMessage = "Price must have up to 2 decimal places")]
        public decimal? Price { get; set; }
        [StringLength(50)]
        public string? InstructorName { get; set; }
    }
}
