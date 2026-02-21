using CourseWebsite.Models.Account;
using OnlineCourseApp.Domain.Enrollments;
using OnlineCourseApp.Domain.Students;
using OnlineCourseApp.Infrastructure.Database;
using System;

namespace CourseWebsite.Services
{
    public class StudentService : IStudentService
    {

        private IStudentRepo _StudentRepo;
        private IEnrollmentRepo _EnrollmentRepo;

        public StudentService(IStudentRepo studentRepo, IEnrollmentRepo enrollmentRepo)
        {
            _StudentRepo = studentRepo;
            _EnrollmentRepo = enrollmentRepo;
        }

        public void EnrollInCourse(int studentId, int courseId)
        {
            var enrollment = new Enrollment
            {
                StudentId = studentId,
                CourseId = courseId,
                EnrolledAt = DateTime.UtcNow,
                Status = "Active"
            };

            _EnrollmentRepo.AddAsync(enrollment);
           
        }

        public MyCoursesModel GetMyCourses(int studentId)
        {
            throw new NotImplementedException();
        }

        public StudentProfileModel GetProfile(int studentId)
        {
            throw new NotImplementedException();
        }

        public StudentSettingModel GetSettings(int studentId)
        {
            throw new NotImplementedException();
        }

        public void UnEnrollFromCourse(int studentId, int courseId)
        {
            // Make this logic using repo not context


            //var enrollment = _context.Enrollments
            //    .FirstOrDefault(e => e.StudentId == studentId && e.CourseId == courseId);

            //if (enrollment != null)
            //{
            //    _context.Enrollments.Remove(enrollment);
            //    _context.SaveChanges();
            //}
        }

        public void UpdateSettings(int studentId, StudentSettingModel model)
        {
            throw new NotImplementedException();
        }
    }
}
