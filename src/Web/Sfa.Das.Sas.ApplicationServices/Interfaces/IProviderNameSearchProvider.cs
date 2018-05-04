﻿using System.Threading.Tasks;
using Sfa.Das.Sas.ApplicationServices.Models;

namespace Sfa.Das.Sas.ApplicationServices.Interfaces
{
    public interface IProviderNameSearchProvider
    {
        Task<ProviderNameSearchResults> SearchByTerm(string searchTerm, int page, int take);
    }
}
