using OnlineCourseApp.Domain.Students;

namespace OnlineCourseApp.Infrastructure.Database.Students
{
    public class EfCoreStudentRepo : IStudentRepo
    {

        private static List<Student> _students = new List<Student>();

        public static void Add(Student student)
        {
            _students.Add(student);
        }
        public static void Delete(int id)
        {
            var student = _students.FirstOrDefault(s => s.Id == id);
            if (student != null)
            {
                _students.Remove(student);
            }
        }
        public static List<Student> GetAllStudents()
        {
            return _students;
        }
        public static void Update(Student updatedStudent)
        {
            var student = _students.FirstOrDefault(s => s.Id == updatedStudent.Id);
            if (student != null)
            {
                student.Name = updatedStudent.Name;
                student.Age = updatedStudent.Age;
            }
        }
    }
}
