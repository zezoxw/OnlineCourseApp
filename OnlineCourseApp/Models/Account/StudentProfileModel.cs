using System.ComponentModel.DataAnnotations;

namespace CourseWebsite.Models.Account
{
    public class StudentProfileModel
    {
        // StudentId ?
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        [Range(5, 100,ErrorMessage ="The Age should be between 5 and 100")]
        public int Age { get; set; }

        public int? EnrolledCoursesCount { get; set; }
    }
}
