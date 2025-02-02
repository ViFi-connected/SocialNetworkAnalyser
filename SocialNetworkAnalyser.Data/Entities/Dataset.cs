namespace SocialNetworkAnalyser.Data.Entities
{
    public class Dataset
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public int UserCount { get; set; }

        public float AvgFriendshipPerUserCount { get; set; }

        // Navigation property to represent the relationship
        public ICollection<Friendship> Friendships { get; set; } = [];
    }
}
