using System;
using System.Collections.Generic;
using Sfa.Eds.Das.Indexer.Common.Models;

namespace Sfa.Eds.Das.ProviderIndexer.Helpers
{
    public interface IProviderHelper
    {
        bool CreateIndex(DateTime scheduledRefreshDateTime);
        void IndexProviders(DateTime scheduledRefreshDateTime, ICollection<Provider> providers);
        void SwapIndexes(DateTime scheduledRefreshDateTime);
        void DeleteOldIndexes(DateTime scheduledRefreshDateTime);
        bool IsIndexCorrectlyCreated(DateTime scheduledRefreshDateTime);
        string GetIndexNameAndDateExtension(DateTime dateTime);
    }
}