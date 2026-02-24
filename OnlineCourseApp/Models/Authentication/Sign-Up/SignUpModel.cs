using System.ComponentModel.DataAnnotations;

namespace CourseWebsite.Models.Authentication.Sign_Up
{
    public class SignUpModel
    {
        // this is the basic later will edit it for each student and instructor
        [Required]
        [StringLength(100)] //Add a check if the user is exist.
        public string Name { get; set; } = string.Empty;
        [Required]
        [Range(5, 100, ErrorMessage = "The Age should be between 5 and 100")]
        public int Age { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        // Add a format for the password.
        public string Password { get; set; } = string.Empty;
        [Required]
        // Add a format for the password and a function to check if confirm equal password.
        public string ConfirmPassword { get; set; } = string.Empty;
        // Not sure how to do it.
        public string Role { get; set; } // "Student" or "Instructor"
    }
}
