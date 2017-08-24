﻿namespace Sfa.Das.Sas.Infrastructure.Repositories
{
    using System.Collections.Generic;
    using System.Linq;
    using Core.Domain.Repositories;
    using SFA.DAS.Apprenticeships.Api.Types.Providers;
    using SFA.DAS.Providers.Api.Client;

    public class ProviderRepository : IProviderRepository
    {

        private readonly IProviderApiClient _providerApiClient;

        public ProviderRepository(IProviderApiClient providerApiClient)
        {
            _providerApiClient = providerApiClient;
        }

        public Dictionary<long, string> GetProviderList()
        {
            var res = _providerApiClient.FindAll()
                .ToDictionary(x => x.Ukprn, x => x.ProviderName);

            return res;
        }

        public Provider GetProviderDetails(long prn)
        {
            return _providerApiClient.Get(prn);
        }
    }
}
