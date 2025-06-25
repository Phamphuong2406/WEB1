using Microsoft.EntityFrameworkCore;

namespace Web1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Users> users { get; set; }
       public DbSet<Subscriber> subscribers { get; set; }
        public DbSet<IntroductoryPost> posts { get; set; } 
    }
}
