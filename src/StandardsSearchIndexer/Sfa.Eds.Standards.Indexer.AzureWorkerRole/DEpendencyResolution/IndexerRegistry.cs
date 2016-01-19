﻿using Sfa.Eds.Standards.Indexer.AzureWorkerRole.Consumers;
using Sfa.Eds.Standards.Indexer.AzureWorkerRole.Services;
using Sfa.Eds.Standards.Indexer.AzureWorkerRole.Settings;
using StructureMap;

namespace Sfa.Eds.Standards.Indexer.AzureWorkerRole.DEpendencyResolution
{
    public class IndexerRegistry : Registry
    {
        public IndexerRegistry()
        {
            For<IStandardService>().Use<StandardService>();
            For<IStandardControlQueueConsumer>().Use<StandardControlQueueConsumer>();
            For<IDedsService>().Use<Services.DedsService>();
            For<IStandardIndexSettings>().Use<StandardIndexSettings>();
        }
    }
}