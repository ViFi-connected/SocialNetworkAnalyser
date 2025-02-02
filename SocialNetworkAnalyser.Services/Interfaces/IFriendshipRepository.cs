using SocialNetworkAnalyser.Data.Entities;

namespace SocialNetworkAnalyser.Services.Interfaces
{
    public interface IFriendshipRepository
    {
        Task<Friendship> GetAsync(int id);
        Task<List<Friendship>> GetAllAsync();
        Task AddAsync(Friendship friendship);
        Task AddRangeAsync(IEnumerable<Friendship> friendships);
        Task UpdateAsync(Friendship friendship);
        Task DeleteAsync(int id);
    }
}
