using EFRelationships.model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFRelationships.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OneToManyController(AppDbContext context) : ControllerBase
    {
        [HttpPost("add-blog")]
        public async Task<IActionResult> CreateBlog(Blog blog)
        {
            context.Blogs.Add(blog);
            await context.SaveChangesAsync();
            return Ok(blog);
        }
        [HttpGet("get-blogs")]
        public async Task<IActionResult> GetBlog()
        {

            return Ok(await context.Blogs.Include(x => x.Posts).ToListAsync());
        }
        [HttpPost("add-posts")]
        public async Task<IActionResult> CreatePosts(Post post)
        {
            context.Posts.Add(post);
            await context.SaveChangesAsync();
            return Ok(post);
        }
        [HttpGet("get-posts")]
        public async Task<IActionResult> GetProfile()
        {

            return Ok(await context.Posts.Include(x => x.Blog).ToListAsync());
        }
    }
    public partial class AppDbContext : DbContext
    {
        public DbSet<Blog> Blogs => Set<Blog>();
        public DbSet<Post> Posts => Set<Post>();
    }
}
