using EFRelationships.model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFRelationships.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OneToOneController(AppDbContext context ) : ControllerBase
    {
        [HttpPost("add-user")]
        public async Task<IActionResult> CreateUser(User user)
        {
            context.Users.Add(user);
            await context.SaveChangesAsync();   
            return Ok(user);    
        }
        [HttpGet("get-users")]
        public async Task<IActionResult> GetUser()
        {
 
            return Ok(await context.Users.Include(x => x.Profile).ToListAsync());
        }
        [HttpPost("add-profile")]
        public async Task<IActionResult> CreateProfile(Profile profile)
        {
            context.Profiles.Add(profile);
            await context.SaveChangesAsync();
            return Ok(profile);
        }
        [HttpGet("get-profiles")]
        public async Task<IActionResult> GetProfile()
        {

            return Ok(await context.Profiles.Include(x => x.User).ToListAsync());
        }

    }

  
  
    public partial  class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users => Set<User>();
        public DbSet<Profile> Profiles => Set<Profile>();
    }
}
