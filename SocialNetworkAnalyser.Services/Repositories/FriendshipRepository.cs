using Microsoft.EntityFrameworkCore;
using SocialNetworkAnalyser.Data;
using SocialNetworkAnalyser.Data.Entities;
using SocialNetworkAnalyser.Shared.Interfaces;

namespace SocialNetworkAnalyser.Shared.Repositories
{
    public class FriendshipRepository : IFriendshipRepository
    {
        private readonly ApplicationDbContext _context;

        public FriendshipRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Friendship> GetAsync(int id)
        {
            return await _context.Friendships.FindAsync(id);
        }

        public async Task<List<Friendship>> GetAllAsync()
        {
            return await _context.Friendships.ToListAsync();
        }

        public async Task AddAsync(Friendship friendship)
        {
            await _context.Friendships.AddAsync(friendship);
            await _context.SaveChangesAsync();
        }

        public async Task AddRangeAsync(IEnumerable<Friendship> friendships)
        {
            await _context.Friendships.AddRangeAsync(friendships);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Friendship friendship)
        {
            _context.Friendships.Update(friendship);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var friendship = await _context.Friendships.FindAsync(id);
            if (friendship != null)
            {
                _context.Friendships.Remove(friendship);
                await _context.SaveChangesAsync();
            }
        }
    }
}
