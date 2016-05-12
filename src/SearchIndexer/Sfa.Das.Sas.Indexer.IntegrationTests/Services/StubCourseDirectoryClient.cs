using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Sfa.Das.Sas.Indexer.IntegrationTests.Services
{
    using System;
    using System.Threading;

    using Microsoft.Rest;

    using Sfa.Das.Sas.Indexer.Infrastructure.CourseDirectory;
    using Infrastructure.CourseDirectory.Models;

    public class StubCourseDirectoryClient : ICourseDirectoryProviderDataService, IDisposable // TBD ToDo: Delete
    {
        private IEnumerable<Provider> Retrieve()
        {
            return JsonConvert.DeserializeObject<IEnumerable<Provider>>(StubCourseDirectoryData.Json);
        }

        public void Dispose()
        {
        }

        public Uri BaseUri { get; set; }

        public ServiceClientCredentials Credentials { get; set; }

        Task<HttpOperationResponse<IList<Provider>>> ICourseDirectoryProviderDataService.BulkprovidersWithOperationResponseAsync(int? version, CancellationToken cancellationToken)
        {
            var response = new HttpOperationResponse<IList<Provider>>();
            var l = Retrieve();
            foreach (var provider in l)
            {
                response.Body.Add(provider);
            }

            return Task.FromResult(response);
        }
    }
}