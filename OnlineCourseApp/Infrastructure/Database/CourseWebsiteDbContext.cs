using Microsoft.EntityFrameworkCore;
using OnlineCourseApp.Domain.Courses;
using OnlineCourseApp.Domain.Enrollments;
using OnlineCourseApp.Domain.Instructors;
using OnlineCourseApp.Domain.Students;


namespace OnlineCourseApp.Infrastructure.Database
{
    public class CourseWebsiteDbContext : DbContext
    {

        public CourseWebsiteDbContext(DbContextOptions<CourseWebsiteDbContext> options) : base(options)
        {

        }
        // Course table
        public DbSet<Course> Courses { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Quiz> Quizs { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Choice> Choices { get; set; }

        //Enrollment table
        public DbSet<Enrollment> Enrollments { get; set; }
         
        // Instructors table
        public DbSet<Instructor> Instructors { get; set; }

        // Student table
        public DbSet<Student> Students { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);

            // Course 
            modelBuilder.Entity<Course>(entity =>
            {
                // Set the id as primary key
                entity.HasKey(c => c.Id);
                entity.Property(c => c.Title).IsRequired();
                entity.Property(c =>c.Description).IsRequired();
                entity.Property(c => c.Price).IsRequired();

                // Configure the relations between course and instructor
                entity.HasOne(c => c.instructor)
                       .WithMany(i => i.Courses)
                       .HasForeignKey(c => c.InstructorId)
                       .OnDelete(DeleteBehavior.SetNull);
                // modules: Module.CourseId is the FK
                entity.HasMany(c => c.Modules)
                      .WithOne(m => m.Course)
                      .HasForeignKey(m => m.CourseId)
                      .OnDelete(DeleteBehavior.Cascade);
                /*
                // many-to-many with Student using explicit join table
                entity.HasMany(c => c.students)
                      .WithMany(s => s.courses)
                      .UsingEntity<Dictionary<string, object>>(
                          "CourseStudent",
                          j => j.HasOne<Student>().WithMany().HasForeignKey("StudentId").OnDelete(DeleteBehavior.Cascade),
                          j => j.HasOne<Course>().WithMany().HasForeignKey("CourseId").OnDelete(DeleteBehavior.Cascade),
                          j =>
                          {
                              j.HasKey("CourseId", "StudentId");
                              j.ToTable("CourseStudent");
                          });*/

            });
           
            // Module
            modelBuilder.Entity<Module>(entity =>
            {
                // Set the id as primary key
                entity.HasKey(m => m.Id);
                entity.Property(m => m.Title).IsRequired();
                entity.Property(m => m.CourseId).IsRequired();
                entity.HasMany(m => m.Quizzes)
                      .WithOne(q => q.Module)
                      .HasForeignKey(q => q.ModuleId)
                      .OnDelete(DeleteBehavior.Cascade);


            });
            // Quiz
            modelBuilder.Entity<Quiz>(entity =>
            {
                // Set the id as primary key
                entity.HasKey(q => q.Id);
                entity.Property(q => q.Title).IsRequired();
                entity.Property(q => q.ModuleId).IsRequired();
                entity.HasMany(q => q.Questions)
                      .WithOne(qu => qu.Quiz)
                      .HasForeignKey(qu => qu.QuizId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            // Question 
            modelBuilder.Entity<Question>(entity =>
            {
                // Set the id as primary key
                entity.HasKey(qu => qu.Id);
                entity.Property(qu => qu.Text).IsRequired();
                entity.Property(qu => qu.QuizId).IsRequired();
                entity.HasMany(qu => qu.Choices)
                      .WithOne(ch => ch.Question)
                      .HasForeignKey(ch => ch.QuestionId)// I need to set the QustionId to be uniqe and represent the question
                      .OnDelete(DeleteBehavior.Cascade);
            });

            // Choice
            modelBuilder.Entity<Choice>(entity =>
            {
                // Set the id as primary key
                entity.HasKey(qu => qu.Id);
                entity.Property(ch => ch.Text).IsRequired();
                entity.Property(ch => ch.IsCorrect).IsRequired();

             });

            //Student
            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(s => s.Id);
                entity.Property(s => s.Name).IsRequired();
                entity.Property(s => s.Age);// Leater I will make it date and caluculate the age
                entity.Property(s => s.Email).IsRequired();// Leater I will but evaliation on the format
            });

            // Instructor
            modelBuilder.Entity<Instructor>(entity =>
            {
                entity.HasKey(i => i.Id);
                entity.Property(i => i.Name).IsRequired();// Add a formating and a length leater
                entity.Property(i => i.Age).IsRequired();// Leater I will make it date and caluculate the age
                entity.Property(i => i.Email).IsRequired();// Leater I will but evaliation on the format
            });

            // Enrollment
            modelBuilder.Entity<Enrollment>(entity => 
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.EnrolledAt).IsRequired();// Need to reviwing 
                entity.Property(e => e.Status).IsRequired();// Add a set of option to status

                // Student and Enrollment relation configuration 
                entity.HasOne(e => e.student)
                      .WithMany(s => s.Enrollments) // Need to check if this is right for define the relation
                      .HasForeignKey(e => e.StudentId)
                      .IsRequired()
                      .OnDelete(DeleteBehavior.Cascade);

                // Course and Enrollment relation configuration
                entity.HasOne(e => e.course)
                      .WithMany()   
                      .HasForeignKey(e => e.CourseId)  
                      .IsRequired() 
                      .OnDelete(DeleteBehavior.Cascade);

                // Instructor and Enrollment relation configuration
                entity.HasOne(e => e.instructor)    
                      .WithMany(i => i.Enrollments)   
                      .HasForeignKey(e => e.InstructorId)  
                      .IsRequired() 
                      .OnDelete(DeleteBehavior.Restrict);

            });

            }

    }
}
