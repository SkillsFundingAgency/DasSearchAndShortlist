﻿using System.Threading.Tasks;

namespace Sfa.Das.ApplicationServices
{
    using Sfa.Das.ApplicationServices.Models;

    public interface ISearchProvider
    {
        StandardSearchResults SearchByKeyword(string keywords, int skip, int take);
        Task<ProviderSearchResults> SearchByLocation(string standardId, int skip, int take, string location);
    }
}
