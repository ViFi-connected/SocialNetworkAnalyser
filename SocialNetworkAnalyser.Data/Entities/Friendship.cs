using System.ComponentModel.DataAnnotations.Schema;

namespace SocialNetworkAnalyser.Data.Entities
{
    public class Friendship
    {
        public int Id { get; set; }

        public int User1Id { get; set; }

        public int User2Id { get; set; }

        public int DatasetId { get; set; }

        [ForeignKey(nameof(DatasetId))]
        public required Dataset Dataset { get; set; }
    }
}
