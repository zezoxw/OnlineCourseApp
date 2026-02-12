using OnlineCourseApp.Domain.Instructors;

namespace OnlineCourseApp.Infrastructure.Database.Instructors
{
    public class EfCoreInstructorRepo : IInstructorRepo
    {
        private static int _nextId = 1;
        private static List<Instructor> _instructors = new List<Instructor>();


        public static int Add(Instructor instructor)
        {
            instructor.Id = _nextId++;
            _instructors.Add(instructor);
            return instructor.Id;
        }
        public static void Delete(int id)
        {
            var instructor = _instructors.FirstOrDefault(i => i.Id == id);
            if (instructor != null)
            {
                _instructors.Remove(instructor);
            }
        }
        public static List<Instructor> GetAllInstructors()
        {
            return _instructors;
        }
        public static Instructor? GetById(int id)
        {
            // Return null if not found
            return _instructors.FirstOrDefault(i => i.Id == id);
        }
        public static void Update(Instructor updatedInstructor)
        {
            var instructor = _instructors.FirstOrDefault(i => i.Id == updatedInstructor.Id);
            if (instructor != null)
            {
                _instructors.Remove(instructor);
                _instructors.Add(updatedInstructor);
            }
        }
    }
}
