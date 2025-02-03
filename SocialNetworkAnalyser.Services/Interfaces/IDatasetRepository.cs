using SocialNetworkAnalyser.Data.Entities;

namespace SocialNetworkAnalyser.Shared.Interfaces
{
    public interface IDatasetRepository
    {
        Task<Dataset> GetAsync(int id);
        Task<List<Dataset>> GetAllAsync();
        Task AddAsync(Dataset dataset);
        Task UpdateAsync(Dataset dataset);
        Task DeleteAsync(int id);
    }
}
