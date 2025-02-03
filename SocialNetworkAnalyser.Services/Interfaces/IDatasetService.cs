namespace SocialNetworkAnalyser.Shared.Interfaces
{
    public interface IDatasetService
    {
        Task ProcessDatasetAsync(List<string> lines, string datasetName);
    }
}
