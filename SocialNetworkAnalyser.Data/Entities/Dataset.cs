using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace SocialNetworkAnalyser.Data.Entities
{
    [Index(nameof(Name), IsUnique = true)]
    public class Dataset
    {
        public int Id { get; set; }

        [Required]
        public required string Name { get; set; }

        public int UserCount { get; set; }

        public float AvgFriendshipPerUserCount { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation property to represent the relationship
        public ICollection<Friendship> Friendships { get; set; } = new List<Friendship>();
    }
}
