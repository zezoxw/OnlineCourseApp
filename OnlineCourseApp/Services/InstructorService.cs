using CourseWebsite.Models.Instructors;
using Microsoft.EntityFrameworkCore;
using OnlineCourseApp.Domain.Instructors;

namespace CourseWebsite.Services
{
    public class InstructorService : IInstructorService
    {
        private IInstructorRepo _instructorRepo;
        public InstructorService(IInstructorRepo instructorRepo)
        {
            _instructorRepo = instructorRepo;
        }

        public InstructorCoursesModel GetMyCourses(int instructorId)
        {
            // Need to Impliment the logic of finding all the courses of an instructoer

            return new InstructorCoursesModel
            {
            };
        }

        public InstructorProfileModel GetProfile(int instructorId)
        {
            // Need to Impliment the logic of getting the info of the instructure by id
            // and convert it to instructorprofilemodel type.
            throw new NotImplementedException();
        }
    }
}
