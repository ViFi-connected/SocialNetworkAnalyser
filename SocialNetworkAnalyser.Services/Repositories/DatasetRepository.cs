using Microsoft.EntityFrameworkCore;
using SocialNetworkAnalyser.Data;
using SocialNetworkAnalyser.Data.Entities;
using SocialNetworkAnalyser.Services.Interfaces;

namespace SocialNetworkAnalyser.Services.Repositories
{
    public class DatasetRepository : IDatasetRepository
    {
        private readonly ApplicationDbContext _context;

        public DatasetRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Dataset> GetAsync(int id)
        {
            return await _context.Datasets.FindAsync(id);
        }

        public async Task<List<Dataset>> GetAllAsync()
        {
            return await _context.Datasets.ToListAsync();
        }

        public async Task AddAsync(Dataset dataset)
        {
            await _context.Datasets.AddAsync(dataset);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Dataset dataset)
        {
            _context.Datasets.Update(dataset);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var dataset = await _context.Datasets.FindAsync(id);
            if (dataset != null)
            {
                _context.Datasets.Remove(dataset);
                await _context.SaveChangesAsync();
            }
        }
    }
}
