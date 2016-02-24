using System.Collections.Generic;
using System.Threading.Tasks;
using Sfa.Eds.Das.Indexer.Common.Services;
using Sfa.Eds.Das.ProviderIndexer.Services;
using Sfa.Eds.Das.StandardIndexer.Services;

namespace Sfa.Eds.Das.Indexer.AzureWorkerRole
{
    public class IndexerJob : IIndexerJob
    {
        private readonly IGenericControlQueueConsumer _controlQueueConsumer;

        public IndexerJob(IGenericControlQueueConsumer controlQueueConsumer)
        {
            _controlQueueConsumer = controlQueueConsumer;
        }

        public void Run()
        {
            var tasks = new List<Task>
            {
                _controlQueueConsumer.CheckMessage<IStandardIndexerService>(),
                _controlQueueConsumer.CheckMessage<IProviderIndexerService>()
            };

            Task.WaitAll(tasks.ToArray());
        }
    }
}