using CourseWebsite.Models.Authentication.Sign_In;
using CourseWebsite.Models.Authentication.Sign_Up;
using OnlineCourseApp.Domain.Instructors;
using OnlineCourseApp.Domain.Students;
using OnlineCourseApp.Infrastructure.Database;
using OnlineCourseApp.Infrastructure.Database.Instructors;
using OnlineCourseApp.Infrastructure.Database.Students;
using System;

namespace CourseWebsite.Services
{
    public class AuthenticatService : IAuthenticatService
    {
        private  IInstructorRepo _instructorRepo;
        private  IStudentRepo _studentRepo;

        public AuthenticatService(IInstructorRepo instructorRepo, IStudentRepo studentRepo)
        {
            _instructorRepo = instructorRepo;
            _studentRepo = studentRepo;
        }

        public void SignUp(SignUpModel model)
        {
            if (model.Password != model.ConfirmPassword)
                throw new Exception("Passwords do not match");

            if (model.Role == "Student")
            {
                var student = new Student
                {
                    Name = model.Name,
                    Age = model.Age,
                    Email = model.Email
                };

                
            }
            else
            {
                var instructor = new Instructor
                {
                    Name = model.Name,
                    Age = model.Age,
                    Email = model.Email
                };

                _context.Instructors.Add(instructor);
            }

            _context.SaveChanges();
        }

        public bool SignIn(SignInModel model)
        {
            return _context.Students.Any(s => s.Email == model.Email)
                || _context.Instructors.Any(i => i.Email == model.Email);
        }

        public void ChangePassword(int userId, NewPasswordModel model)
        {
            if (model.NewPassword != model.ConfirmPassword)
                throw new Exception("Passwords do not match");

            // password logic later (hashing, identity, etc.)
        }

        public void ResetPassword(PasswordResetModel model)
        {
            if (model.NewPassword != model.ConfirmPassword)
                throw new Exception("Passwords do not match");

            // token validation later
        }
    }
}
