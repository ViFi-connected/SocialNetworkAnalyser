using SocialNetworkAnalyser.Data.Entities;
using SocialNetworkAnalyser.Shared.Interfaces;

namespace SocialNetworkAnalyser.Shared.Services
{
    public class DatasetImportJob : IDatasetImportJob
    {
        private readonly IFriendshipRepository _friendshipRepository;
        private readonly IDatasetRepository _datasetRepository;

        public DatasetImportJob(IFriendshipRepository friendshipRepository, IDatasetRepository datasetRepository)
        {
            _friendshipRepository = friendshipRepository;
            _datasetRepository = datasetRepository;
        }

        public void Execute(List<string> lines, string datasetName)
        {
            Task.Run(async () =>
            {
                try
                {
                    var dataset = new Dataset
                    {
                        Name = datasetName,
                    };

                    await _datasetRepository.AddAsync(dataset);

                    var userIds = new HashSet<int>();
                    var friendships = new List<Friendship>();

                    foreach (var line in lines)
                    {
                        var ids = line.Split(' ');
                        if (ids.Length != 2) continue;

                        if (int.TryParse(ids[0], out var user1Id) && int.TryParse(ids[1], out var user2Id))
                        {
                            userIds.Add(user1Id);
                            userIds.Add(user2Id);

                            var friendship = new Friendship
                            {
                                User1Id = user1Id,
                                User2Id = user2Id,
                                Dataset = dataset
                            };

                            friendships.Add(friendship);
                        }
                    }

                    await _friendshipRepository.AddRangeAsync(friendships);

                    dataset.UserCount = userIds.Count;
                    dataset.AvgFriendshipPerUserCount = (float)friendships.Count / userIds.Count;

                    await _datasetRepository.UpdateAsync(dataset);

                    Console.WriteLine($"{nameof(DatasetImportJob)} has finished processing.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error in {nameof(DatasetImportJob)}: {ex.Message}");
                }
            });
        }
    }
}
