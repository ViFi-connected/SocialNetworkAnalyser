using System.Collections.Generic;

namespace SocialNetworkAnalyser.Services.Interfaces
{
    public interface IDatasetImportJob
    {
        void Execute(List<string> lines, string datasetName);
    }
}
