using OnlineCourseApp.Domain.Enrollments;

namespace OnlineCourseApp.Infrastructure.Database.Enrollments
{
    public class EfCoreEnrollmentRepo : IEnrollmentRepo
    {
        private static int _nextId = 1;
        private static List<Enrollment> _enrollments = new List<Enrollment>();
        public static int Add(Enrollment enrollment)
        {
            enrollment.Id = _nextId++;
            _enrollments.Add(enrollment);
            return enrollment.Id;
        }
        public static void Delete(int id)
        {
            var enrollment = _enrollments.FirstOrDefault(e => e.Id == id);
            if (enrollment != null)
            {
                _enrollments.Remove(enrollment);
            }
        }
        public static List<Enrollment> GetAll()
        {
            return _enrollments;
        }
        public static void Update(Enrollment updatedEnrollment)
        {
            var enrollment = _enrollments.FirstOrDefault(e => e.Id == updatedEnrollment.Id);
            if (enrollment != null)
            {
                _enrollments.Remove(enrollment); _nextId++;
                _enrollments.Add(updatedEnrollment);
            }
        }
        public Enrollment? GetById(int id)
        {
            return _enrollments.FirstOrDefault(e => e.Id == id);
        }
    }
}
