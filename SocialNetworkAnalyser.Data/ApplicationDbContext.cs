using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

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


    public class Friendship
    {
        public int Id { get; set; }
        
        public uint User1Id { get; set; }
        
        public uint User2Id { get; set; }
        
        public int DatasetId { get; set; }

        [ForeignKey(nameof(DatasetId))]
        public required Dataset Dataset { get; set; }
    }

    public class Dataset
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public ushort UserCount { get; set; }

        public float AvgFriendshipPerUserCount { get; set; }

        // Navigation property to represent the relationship
        public ICollection<Friendship> Friendships { get; set; } = [];
    }
}
