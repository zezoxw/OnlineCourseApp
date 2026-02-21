using CourseWebsite.Models.Authentication.Sign_In;
using CourseWebsite.Models.Authentication.Sign_Up;
using CourseWebsite.Services;
using Microsoft.AspNetCore.Mvc;

namespace CourseWebsite.Controllers
{
    public class AccountController : Controller
    {
        private readonly AuthenticatService _authService;

        public AccountController(AuthenticatService authService)
        {
            _authService = authService;
        }

        [HttpGet]
        public IActionResult SignUp() => View();

        [HttpPost]
        public IActionResult SignUp(SignUpModel model)
        {
            _authService.SignUp(model);
            return RedirectToAction("SignIn");
        }

        [HttpGet]
        public IActionResult SignIn() => View();

        [HttpPost]
        public IActionResult SignIn(SignInModel model)
        {
            if (_authService.SignIn(model))
                return RedirectToAction("Index", "Home");

            ModelState.AddModelError("", "Invalid login");
            return View(model);
        }

        [HttpGet]
        public IActionResult ResetPassword() => View();

        [HttpPost]
        public IActionResult ResetPassword(PasswordResetModel model)
        {
            _authService.ResetPassword(model);
            return RedirectToAction("SignIn");
        }
    }
}
