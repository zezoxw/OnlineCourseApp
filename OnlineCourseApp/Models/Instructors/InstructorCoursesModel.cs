namespace CourseWebsite.Models.Instructors
{
    public class InstructorCoursesModel
    {
        public int InstructorId { get; set; }
        public string InstructorName { get; set; }

        public List<InstructorCourseItemModel> Courses { get; set; }
    }
}
