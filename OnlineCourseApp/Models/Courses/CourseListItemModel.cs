using System.ComponentModel.DataAnnotations;

namespace CourseWebsite.Models.Courses
{
    public class CourseListItemModel
    {
        // do i need to add a range if this will be use for search?
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Title { get; set; } = string.Empty;
        [Required]
        [Range(0.01, 10000)]
        [RegularExpression(@"^\d+(\.\d{1,2})?$",
        ErrorMessage = "Price must have up to 2 decimal places")]
        public decimal Price { get; set; }
        [Required]
        [StringLength(50)]
        public string InstructorName { get; set; } = string.Empty;
    }
}
