namespace OnlineCourseApp.Domain.Instructors
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // later we can change it to DateTime for DOB
        public int Age { get; set; }
        // later we can constrain it to be unique and format it as an email address
        public string Email { get; set; }
        // we will add a list of courses that the instructor teaches later, but for now we can keep it simple
    }
}
