using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Sfa.Eds.Das.Indexer.Common.Models;

namespace Sfa.Eds.Das.Indexer.Common.Helpers
{
    public interface IBlobStorageHelper
    {
        Task<byte[]> ReadStandardPdfAsync(string containerName, string fileName);
        bool FileExists(string containerName, string fileName);
        Task UploadPdfFromUrl(string containerName, string fileName, string url);
    }
}