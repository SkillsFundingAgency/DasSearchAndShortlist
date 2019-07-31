﻿using System;
using MediatR;
using Sfa.Das.Sas.ApplicationServices.Models;

namespace Sfa.Das.Sas.ApplicationServices.Queries
{
    public class GetBasketQuery : IRequest<ApprenticeshipFavouritesBasket>
    {
        public Guid BasketId { get; set; }
    }
}