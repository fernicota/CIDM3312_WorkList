using Microsoft.EntityFrameworkCore;

namespace CIDM3312_WorkList.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new UserTaskDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<UserTaskDbContext>>()))
            {
                if (context.Tasks.Any())
                {
                    return; // DB has been seeded
                }

                // Add Organizations
                var tasks = new[]
                {
                    new Task {Name = "Daily Rounds Inspection", Description = "Do a daily walk around and make sure everything is operating normally.", DateCreated = new DateTime (2023, 11, 23), Duration = "1 hour" },
                    new Task {Name = "Battery Changes and Battery PMs", Description = "Change batteries on equipment as needed and check water level on batteries.", DateCreated = new DateTime (2023, 12, 1), Duration = "2 hours"},
                };   
            }
        }    
    }
}