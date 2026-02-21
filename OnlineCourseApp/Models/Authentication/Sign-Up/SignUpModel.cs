namespace CourseWebsite.Models.Authentication.Sign_Up
{
    public class SignUpModel
    {
        // this is the basic leater will edite it for each student and instructor
        public string Name { get; set; }
        public int Age { get; set; }
        // Add Attribute for them leater 
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public string Role { get; set; } // "Student" or "Instructor"
    }
}
