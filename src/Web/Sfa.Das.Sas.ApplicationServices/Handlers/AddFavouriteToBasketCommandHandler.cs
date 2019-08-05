﻿using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;
using Sfa.Das.Sas.ApplicationServices.Commands;
using Sfa.Das.Sas.ApplicationServices.Interfaces;
using Sfa.Das.Sas.ApplicationServices.Models;

namespace Sfa.Das.Sas.ApplicationServices.Handlers
{
    public class AddFavouriteToBasketCommandHandler : IRequestHandler<AddFavouriteToBasketCommand, Guid>
    {
        private readonly IApprenticeshipFavouritesBasketStore _basketStore;
        private readonly ILogger<AddFavouriteToBasketCommandHandler> _logger;

        public AddFavouriteToBasketCommandHandler(ILogger<AddFavouriteToBasketCommandHandler> logger, IApprenticeshipFavouritesBasketStore basketStore)
        {
            _basketStore = basketStore;
            _logger = logger;
        }

        public async Task<Guid> Handle(AddFavouriteToBasketCommand request, CancellationToken cancellationToken)
        {
            ApprenticeshipFavouritesBasketWrite basket;
            Guid basketId;

            if (request.BasketId.HasValue)
            {
                basketId = request.BasketId.Value;
                basket = (await _basketStore.GetAsync(request.BasketId.Value)).ToBasketWrite() ?? new ApprenticeshipFavouritesBasketWrite();

                if (basket.Any(x => x.ApprenticeshipId == request.ApprenticeshipId))
                    return basketId; // Ignore if saving just an apprenticehip that is already in the basket.

                basket.Add(new ApprenticeshipFavouriteWrite(request.ApprenticeshipId));
            }
            else
            {
                CreateNewBasket(request, out basket, out basketId);
            }

            await _basketStore.UpdateAsync(basketId, basket);

            _logger.LogDebug("Updated apprenticeship basket: {basketId}", basketId);

            return basketId;
        }

        private static void CreateNewBasket(AddFavouriteToBasketCommand request, out ApprenticeshipFavouritesBasketWrite basket, out Guid basketId)
        {
            basketId = Guid.NewGuid();
            basket = new ApprenticeshipFavouritesBasketWrite
                {
                    new ApprenticeshipFavouriteWrite(request.ApprenticeshipId)
                };
        }
    }
}
