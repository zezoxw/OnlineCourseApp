namespace CourseWebsite.Models.Authentication.Sign_In
{
    public class PasswordResetModel
    {
        // Add Attribute for them leater 
        public string Email { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
