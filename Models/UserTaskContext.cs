using Microsoft.EntityFrameworkCore;
namespace CIDM3312_WorkList.Models
{
    public class UserTaskDbContext : DbContext
    {
        public UserTaskDbContext (DbContextOptions<UserTaskDbContext> options)
			: base(options)
		{
		}

        public DbSet<Task> Tasks {get; set;} = default!;
        public DbSet<User> Users {get; set;} 
    }
}