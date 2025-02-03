using AutoMapper;
using SocialNetworkAnalyser.Data.Entities;
using SocialNetworkAnalyser.Shared.Dtos;
using SocialNetworkAnalyser.Shared.Interfaces;

namespace SocialNetworkAnalyser.Shared.Services;

public class DatasetService(IDatasetRepository datasetRepository, IDatasetImportJob datasetImportJob, IMapper mapper) : IDatasetService
{
    private readonly IDatasetRepository _datasetRepository = datasetRepository;
    private readonly IDatasetImportJob _datasetImportJob = datasetImportJob;
    private readonly IMapper _mapper = mapper;

    public async Task ProcessDatasetAsync(List<string> lines, string datasetName)
    {
        _datasetImportJob.Execute(lines, datasetName);
        await Task.CompletedTask;
    }

    public async Task<List<DatasetDto>> GetAllDatasetsAsync()
    {
        var datasets = await _datasetRepository.GetAllAsync();
        return _mapper.Map<List<DatasetDto>>(datasets);
    }

    public async Task<DatasetStatsDto> GetDatasetStatsAsync(int datasetId)
    {
        var dataset = await _datasetRepository.GetAsync(datasetId);
        return _mapper.Map<Dataset, DatasetStatsDto>(dataset);
    }
}
