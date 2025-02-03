using SocialNetworkAnalyser.Shared.Dtos;

namespace SocialNetworkAnalyser.Shared.Interfaces
{
    public interface IDatasetService
    {
        Task ProcessDatasetAsync(List<string> lines, string datasetName);

        Task<List<DatasetDto>> GetAllDatasetsAsync();

        Task<DatasetStatsDto> GetDatasetStatsAsync(int datasetId);
    }
}
