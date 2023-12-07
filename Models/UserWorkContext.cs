using Microsoft.EntityFrameworkCore;
namespace CIDM3312_WorkList.Models
{
    public class UserWorkDbContext : DbContext
    {
        public UserWorkDbContext (DbContextOptions<UserWorkDbContext> options)
			: base(options)
		{
		}
 
        public DbSet<User> Users {get; set;} = default!;
        public DbSet<Work> Works {get; set;}
    }
}