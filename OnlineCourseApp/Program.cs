using CourseWebsite.Services;
using Microsoft.EntityFrameworkCore;
using OnlineCourseApp.Domain.Courses;
using OnlineCourseApp.Domain.Enrollments;
using OnlineCourseApp.Domain.Instructors;
using OnlineCourseApp.Domain.Students;
using OnlineCourseApp.Infrastructure.Database;
using OnlineCourseApp.Infrastructure.Database.Courses;
using OnlineCourseApp.Infrastructure.Database.Enrollments;
using OnlineCourseApp.Infrastructure.Database.Instructors;
using OnlineCourseApp.Infrastructure.Database.Students;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


// Inject Reposetory 
// Students 
builder.Services.AddScoped<IStudentRepo, EfCoreStudentRepo>();
// Courses
builder.Services.AddScoped<ICourseRepo, EfCoreCourseRepo>();
builder.Services.AddScoped<IQuizRepo, EfCoreQuizRepo>();
builder.Services.AddScoped<IQuestionRepo, EfCoreQuestionRepo>();
builder.Services.AddScoped<IChoiceRepo, EfCoreChoiceRepo>();
// Instructers
builder.Services.AddScoped<IInstructorRepo, EfCoreInstructorRepo>();
// Enrollment
builder.Services.AddScoped<IEnrollmentRepo, EfCoreEnrollmentRepo>();



// Inject services
builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddScoped<IInstructorService, InstructorService>();
builder.Services.AddScoped<ICourseService, CourseService>();
builder.Services.AddScoped<IAuthenticatService, AuthenticatService>();





builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<CourseWebsiteDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
