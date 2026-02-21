namespace CourseWebsite.Models.Instructors
{
    public class InstructorCourseItemModel
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public int StudentsCount { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
