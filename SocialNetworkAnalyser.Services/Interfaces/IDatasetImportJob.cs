namespace SocialNetworkAnalyser.Shared.Interfaces
{
    public interface IDatasetImportJob
    {
        void Execute(List<string> lines, string datasetName);
    }
}
