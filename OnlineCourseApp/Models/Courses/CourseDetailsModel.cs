using System.ComponentModel.DataAnnotations;

namespace CourseWebsite.Models.Courses
{
    public class CourseDetailsModel
    {

        [Required] // dose the user enter the id or take it from db?
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Title { get; set; } = string.Empty;
        [Required]
        [StringLength(100)]
        public string Description { get; set; } = string.Empty;
        [Required]
        [Range(0.01, 10000)]
        [RegularExpression(@"^\d+(\.\d{1,2})?$",
        ErrorMessage = "Price must have up to 2 decimal places")]
        public decimal Price { get; set; }
        [Required]
        [StringLength(50)]
        public string InstructorName { get; set; } = string.Empty;

        // later will make it as student object 
        // dose it need a range?
        public int? EnrolledStudentsCount { get; set; }
    }
}
