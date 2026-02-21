namespace CourseWebsite.Models.Courses
{
    public class CourseDetailsModel
    {
        
        // Add Attribute for them leater 
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public string InstructorName { get; set; }

        // may be leater will make it as student object 
        public int EnrolledStudentsCount { get; set; }
    }
}
