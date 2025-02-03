using Microsoft.EntityFrameworkCore;
using SocialNetworkAnalyser.Shared.Interfaces;

namespace SocialNetworkAnalyser.Shared.Services;

public class DatasetService(IDatasetImportJob datasetImportJob) : IDatasetService
{
    private readonly IDatasetImportJob _datasetImportJob = datasetImportJob;

    public async Task ProcessDatasetAsync(List<string> lines, string datasetName)
    {
        _datasetImportJob.Execute(lines, datasetName);
        await Task.CompletedTask;
    }
}
