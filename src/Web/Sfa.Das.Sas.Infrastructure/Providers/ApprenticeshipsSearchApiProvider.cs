﻿using System.Linq;
using System.Threading.Tasks;
using Sfa.Das.FatApi.Client.Api;

namespace Sfa.Das.Sas.Infrastructure.Providers
{
    using Sfa.Das.Sas.ApplicationServices;
    using Sfa.Das.Sas.ApplicationServices.Models;
    using Sfa.Das.Sas.Infrastructure.Helpers;
    using Sfa.Das.Sas.Infrastructure.Mapping;
    using System.Collections.Generic;

    public class ApprenticeshipsSearchApiProvider : IApprenticeshipSearchProvider
    {
        private readonly ISearchVApi _apprenticeshipProgrammeApiClient;
        private readonly IApprenticeshipSearchResultsMapping _apprenticeshipSearchResultsMapping;
        public ApprenticeshipsSearchApiProvider(ISearchVApi apprenticeshipProgrammeApiClient, IApprenticeshipSearchResultsMapping apprenticeshipSearchResultsMapping)
        {
            _apprenticeshipProgrammeApiClient = apprenticeshipProgrammeApiClient;
            _apprenticeshipSearchResultsMapping = apprenticeshipSearchResultsMapping;
        }

        public async Task<ApprenticeshipSearchResults> SearchByKeyword(string keywords, int page, int take, int order, List<int> selectedLevels)
        {
            var formattedKeywords = QueryHelper.FormatQuery(keywords);

            var selectedLevelsCsv = (selectedLevels != null && selectedLevels.Any()) ? string.Join(",", selectedLevels) : null;
            
            var results = _apprenticeshipSearchResultsMapping.Map(await _apprenticeshipProgrammeApiClient.SearchActiveApprenticeshipsAsync(formattedKeywords, page, take, order, selectedLevelsCsv));
            results.SearchTerm = keywords;
            results.SortOrder = order.ToString();
            return results;
        }
    }
}