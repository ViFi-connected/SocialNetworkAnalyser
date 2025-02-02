namespace SocialNetworkAnalyser.Services.Dtos
{
    public class DatasetStatsDto
    {
        public int Id { get; set; }

        public required string Name { get; set; }
        
        public int UserCount { get; set; }
        
        public float AvgFriendshipPerUserCount { get; set; }
    }
}
