using CourseWebsite.Models.Authentication.Sign_In;
using CourseWebsite.Models.Authentication.Sign_Up;

namespace CourseWebsite.Services
{
    public interface IAuthenticatService
    {
        void SignUp(SignUpModel model);
        bool SignIn(SignInModel model);
        void ChangePassword(int userId, NewPasswordModel model);
        void ResetPassword(PasswordResetModel model);
    }
}
