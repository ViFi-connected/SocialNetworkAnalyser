using SocialNetworkAnalyser.Data;
using SocialNetworkAnalyser.Data.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialNetworkAnalyser.Services.Interfaces
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
