using System.ComponentModel.DataAnnotations;

namespace CourseWebsite.Models.Account
{
    public class MyCourseItemModel
    {
        /// <summary>
        /// do i need to make it require if the user will not enter it?
        /// may be we can reuse this model with other module that take user input 
        /// such as create new course.
        /// </summary>
        [Required]
        public int CourseId { get; set; }

        [Required]
        [StringLength(50)]
        public  string Title { get; set; } = string.Empty;
        [Required]
        [Range(0.01,10000)]
        [RegularExpression(@"^\d+(\.\d{1,2})?$",
        ErrorMessage = "Price must have up to 2 decimal places")]
        public decimal Price { get; set; }
        [Required]
        [StringLength(50)]
        // may be later add a format. 
        public string InstructorName { get; set; } = string.Empty ;
        [Range(typeof(DateTime), "2000-01-01", "2100-01-01",
        ErrorMessage = "Enrollment date is invalid")]
        // later will make it validate the max as today date
        public DateTime EnrolledAt { get; set; }
        [Required]
        [StringLength(50)]
        // Later will add the status as constant list 
        public string Status { get; set; } = string.Empty;
    }
}
