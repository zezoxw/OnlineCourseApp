namespace CourseWebsite.Models.Account
{
    public class MyCourseItemModel
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string InstructorName { get; set; }
        public DateTime EnrolledAt { get; set; }
        public string Status { get; set; }
    }
}
