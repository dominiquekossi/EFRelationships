using EFRelationships.model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFRelationships.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManyToManyController(AppDbContext context) : ControllerBase
    {
        [HttpPost("add-student")]
        public async Task<IActionResult> CreateStudent(Student student)
        {
            context.Students.Add(student);
            await context.SaveChangesAsync();
            return Ok(student);
        }
        [HttpGet("get-students")]
        public async Task<IActionResult> GetStudents()
        {

            return Ok(await context.Students.Include(x => x.CourseStudent).ToListAsync());
        }
        [HttpPost("add-course")]
        public async Task<IActionResult> CreateCourse(Course course)
        {
            context.Courses.Add(course);
            await context.SaveChangesAsync();
            return Ok(course);
        }
        [HttpGet("get-courses")]
        public async Task<IActionResult> GetCourse()
        {

            return Ok(await context.CoursesStudents.Include(x => x.Courses).ToListAsync());
        }
        [HttpGet("get-courses-students")]
        public async Task<IActionResult> GetCoursesStudents()
        {

            return Ok(await context.CoursesStudents.Include(x => x.Courses).Include(x => x.Student).ToListAsync());
        }
        [HttpPost("add-courses-students")]
        public async Task<IActionResult> GetCoursesStudents(CourseStudent courseStudent)
        {
            context.CoursesStudents.Add(courseStudent);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
    public partial class AppDbContext : DbContext
    {
        public DbSet<Student> Students => Set<Student>();
        public DbSet<Course> Courses => Set<Course>();
        public DbSet<CourseStudent> CoursesStudents => Set<CourseStudent>();


    }
}
