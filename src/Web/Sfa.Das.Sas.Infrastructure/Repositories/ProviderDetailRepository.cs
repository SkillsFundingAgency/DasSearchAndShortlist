﻿namespace Sfa.Das.Sas.Infrastructure.Repositories
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Core.Domain.Repositories;
    using SFA.DAS.Apprenticeships.Api.Types.Providers;
    using SFA.DAS.Providers.Api.Client;

    public class ProviderDetailRepository : IProviderDetailRepository
    {

        private readonly IProviderApiClient _providerApiClient;

        public ProviderDetailRepository(IProviderApiClient providerApiClient)
        {
            _providerApiClient = providerApiClient;
        }

        public async Task<Provider> GetProviderDetails(long ukPrn)
        {
            var result = await _providerApiClient.GetAsync(ukPrn);
            return result;
        }

        public async Task<IEnumerable<ProviderSummary>> GetProviderList()
        {
            var res = await _providerApiClient.FindAllAsync();
            return res;
        }
    }
}
