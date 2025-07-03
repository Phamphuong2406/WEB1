using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace Web1.Data
{
    public class AppDbContext : DbContext
    {
       

        public DbSet<Users> users { get; set; }
       public DbSet<Subscriber> subscribers { get; set; }
        public DbSet<IntroductoryPost> posts { get; set; }
        public DbSet<Settings> settings { get; set; }
       public DbSet<Partner> partners { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IntroductoryPost>()
                .HasOne(p => p.User)
                .WithMany(u => u.Posts)
                .HasForeignKey(p => p.PosterId);

            modelBuilder.Entity<IntroductoryPost>(entity =>
            {
                entity.Property(p => p.title)
                      .HasMaxLength(100)
                      .IsRequired();

                entity.Property(p => p.description)
                      .HasMaxLength(500);

                entity.Property(p => p.Image)
                .HasMaxLength(225);
                entity.Property(p => p.Url)
                .HasMaxLength(100);

                 entity.HasOne(p => p.User)
                .WithMany(u => u.Posts)
                .HasForeignKey(p => p.PosterId);
            });
            modelBuilder.Entity<Settings>(entity => {
                entity.Property(p => p.Key)
                .HasMaxLength(100);
                entity.Property(p => p.Value)
                .HasMaxLength(50);
                entity.Property(p => p.Description)
                .HasMaxLength(225);
            });
            modelBuilder.Entity<Partner>(entity =>
            {
                entity.Property(p => p.Name)
                .HasMaxLength(100);
                entity.Property(p => p.Description)
                .HasMaxLength(500);
            });

        }
    }
}
