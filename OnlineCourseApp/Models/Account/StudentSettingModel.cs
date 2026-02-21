namespace CourseWebsite.Models.Account
{
    public class StudentSettingModel
    {
        public string Email { get; set; }
        public bool EmailNotifications { get; set; }


        //not what the model should have later after creating the view, change them to what needed.
       
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
/*
  userInterface =>
  * trycont
  * loekoutTime
  * 
  userManager =>
    * changePassword
    * ....ets
  the manager is using the repository to update the database and the user you cant use the repo directly in the controller
  */
