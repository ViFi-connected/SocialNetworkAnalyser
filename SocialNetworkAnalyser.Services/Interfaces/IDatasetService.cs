using SocialNetworkAnalyser.Services.Dtos;

namespace SocialNetworkAnalyser.Services.Interfaces
{
    public interface IDatasetService
    {
        Task ProcessDatasetAsync(List<string> lines, string datasetName);

        Task<List<DatasetDto>> GetAllDatasetsAsync();

        Task<DatasetStatsDto> GetDatasetStatsAsync(int datasetId);
    }
}
