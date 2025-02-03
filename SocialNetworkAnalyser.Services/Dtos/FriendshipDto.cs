namespace SocialNetworkAnalyser.Shared.Dtos
{
    public class FriendshipDto
    {
        public int Id { get; set; }
        public uint User1Id { get; set; }
        public uint User2Id { get; set; }
        public int DatasetId { get; set; }
    }
}
