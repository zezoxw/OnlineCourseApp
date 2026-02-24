using System.ComponentModel.DataAnnotations;

namespace CourseWebsite.Models.Authentication.Sign_In
{
    public class SignInModel
    {
         
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        // Add a format for the password.
        public string Password { get; set; } = string.Empty;
    }
}
