using System.ComponentModel.DataAnnotations;

namespace CourseWebsite.Models.Authentication.Sign_In
{
    public class PasswordResetModel
    {
        // Add format for them later 
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string NewPassword { get; set; } = string.Empty;
        [Required]
        public string ConfirmPassword { get; set; } = string.Empty;
        // Add a function to check if the new and confirm password are the same.
    }
}
