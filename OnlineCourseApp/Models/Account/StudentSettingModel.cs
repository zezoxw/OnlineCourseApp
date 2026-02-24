using System.ComponentModel.DataAnnotations;

namespace CourseWebsite.Models.Account
{
    public class StudentSettingModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        public bool EmailNotifications { get; set; }

    }
}
/*
  userInterface =>
  * trycount
  * lockoutTime
  * 
  userManager =>
    * changePassword
    * ....ets
  the manager is using the repository to update the database and
  the user you cant use the repo directly in the controller.
  */
