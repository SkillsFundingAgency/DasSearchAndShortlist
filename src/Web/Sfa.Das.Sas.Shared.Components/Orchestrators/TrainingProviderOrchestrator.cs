﻿using System;
using System.Threading.Tasks;
using MediatR;
using Sfa.Das.Sas.ApplicationServices.Queries;
using Sfa.Das.Sas.Shared.Components.Mapping;
using Sfa.Das.Sas.Shared.Components.ViewComponents.Fat;
using Sfa.Das.Sas.Shared.Components.ViewComponents.TrainingProvider.Search;
using Sfa.Das.Sas.Shared.Components.ViewModels;

namespace Sfa.Das.Sas.Shared.Components.Orchestrators
{
    public class TrainingProviderOrchestrator : ITrainingProviderOrchestrator
    {
        private readonly IMediator _mediator;
        private readonly ISearchResultsViewModelMapper _searchResultsViewModelMapper;

        public TrainingProviderOrchestrator(IMediator mediator, ISearchResultsViewModelMapper searchResultsViewModelMapper)
        {
            _mediator = mediator;
            _searchResultsViewModelMapper = searchResultsViewModelMapper;
        }

        public async Task<SearchResultsViewModel<TrainingProviderSearchResultsItem, TrainingProviderSearchViewModel>> GetSearchResults(TrainingProviderSearchViewModel searchQueryModel)
        {

            var results = await _mediator.Send(new ProviderSearchQuery()
            {
                ApprenticeshipId = searchQueryModel.ApprenticeshipId,
                PostCode = searchQueryModel.Postcode,
            });

            if (results.Success = false)
            {
                throw new Exception($"Unable to get provider search response: {results.StatusCode}");
               
            }

            return _searchResultsViewModelMapper.Map(results, searchQueryModel);
        }
    }
}