﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;
using SFA.DAS.Apprenticeships.Api.Types;
using Sfa.Das.Sas.ApplicationServices.Interfaces;
using Sfa.Das.Sas.ApplicationServices.Models;
using Sfa.Das.Sas.ApplicationServices.Queries;
using Sfa.Das.Sas.Core.Domain.Services;
using Sfa.Das.Sas.Shared.Basket.Interfaces;
using Sfa.Das.Sas.Shared.Basket.Models;

namespace Sfa.Das.Sas.ApplicationServices.Handlers
{
    public class GetBasketHandler : IRequestHandler<GetBasketQuery, ApprenticeshipFavouritesBasketRead>
    {
        private readonly ILogger<GetBasketHandler> _logger;
        private readonly IApprenticeshipFavouritesBasketStore _basketStore;
        private readonly IGetStandards _getStandards;
        private readonly IGetFrameworks _getFrameworks;
        private readonly IGetProviderDetails _getProvider;

         public GetBasketHandler(
            ILogger<GetBasketHandler> logger,
            IApprenticeshipFavouritesBasketStore basketStore, IGetStandards getStandards, IGetFrameworks getFrameworks, IGetProviderDetails getProvider)
        {
            _logger = logger;
            _basketStore = basketStore;
            _getStandards = getStandards;
            _getFrameworks = getFrameworks;
            _getProvider = getProvider;
        }

        public async Task<ApprenticeshipFavouritesBasketRead> Handle(GetBasketQuery request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Getting basket for {basketId}", request.BasketId);

            var basket = await _basketStore.GetAsync(request.BasketId);

            ApprenticeshipFavouritesBasketRead basketRead = null;

            if (basket != null)
            {
                basketRead = new ApprenticeshipFavouritesBasketRead();

                Parallel.ForEach(basket, (basketItem) =>
                {
                  basketRead.Add(EnrichApprenticeshipInfo(basketItem));
                });
            }

            return basketRead ?? new ApprenticeshipFavouritesBasketRead();
        }

        private ApprenticeshipFavouriteRead EnrichApprenticeshipInfo(ApprenticeshipFavourite apprenticeship)
        {
            var apprenticeshipRead = new ApprenticeshipFavouriteRead(){ApprenticeshipId = apprenticeship.ApprenticeshipId};

            if (IsFramework(apprenticeship.ApprenticeshipId))
            {
                EnrichFramework(apprenticeshipRead);
            }
            else
            {
                EnrichStandard(apprenticeshipRead);
            }

            EnrichTrainingProvider(apprenticeshipRead, apprenticeship.Ukprns);

            return apprenticeshipRead;
        }

        private void EnrichTrainingProvider(ApprenticeshipFavouriteRead apprenticeship, IEnumerable<int> ukprns)
        {
            Parallel.ForEach(ukprns, async ukprnItem =>
            {
                var providerResult = await _getProvider.GetProviderDetails(ukprnItem);

                if (providerResult != null)
                {
                    apprenticeship.Providers.Add(new ApprenticeshipProviderFavourite(ukprnItem){Name = providerResult.ProviderName});
                }
            });
        }

        private void EnrichFramework(ApprenticeshipFavouriteRead apprenticeship)
        {
            var framework = _getFrameworks.GetFrameworkById(apprenticeship.ApprenticeshipId);

            apprenticeship.Title = framework.Title;
            apprenticeship.Duration = framework.Duration;
            apprenticeship.Level = framework.Level;
        }

        private void EnrichStandard(ApprenticeshipFavouriteRead apprenticeship)
        {
            var standard = _getStandards.GetStandardById(apprenticeship.ApprenticeshipId);

            apprenticeship.Title = standard.Title;
            apprenticeship.Duration = standard.Duration;
            apprenticeship.Level = standard.Level;

        }

        public bool IsFramework(string id)
        {
            return id.Contains("-");
        }
    }
}
