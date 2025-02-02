using Microsoft.EntityFrameworkCore;
using SocialNetworkAnalyser.Data.Entities;

namespace SocialNetworkAnalyser.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Friendship> Friendships { get; set; }
        public DbSet<Dataset> Datasets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure the relationship between Friendship and Dataset
            modelBuilder.Entity<Friendship>()
                .HasOne(f => f.Dataset)
                .WithMany(d => d.Friendships)
                .HasForeignKey(f => f.DatasetId);
        }
    }
}
