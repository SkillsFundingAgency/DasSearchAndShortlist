﻿using System;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MediatR;
using Microsoft.Extensions.Logging.Abstractions;
using Moq;
using NUnit.Framework;
using Sfa.Das.Sas.ApplicationServices.Handlers;
using Sfa.Das.Sas.ApplicationServices.Models;
using Sfa.Das.Sas.ApplicationServices.Queries;
using Sfa.Das.Sas.Core.Domain.Model;
using Sfa.Das.Sas.Core.Domain.Services;
using Sfa.Das.Sas.Shared.Basket.Interfaces;
using Sfa.Das.Sas.Shared.Basket.Models;

namespace Sfa.Das.Sas.Web.UnitTests.Application.Handlers
{
    [TestFixture]
    public class GetBasketHandlerTests
    {
        private IRequestHandler<GetBasketQuery, ApprenticeshipFavouritesBasketRead> _sut;
        private Mock<IApprenticeshipFavouritesBasketStore> _mockBasket;
        private Mock<IGetFrameworks> _mockFramework;
        private Mock<IGetStandards> _mockStandard;
        private Mock<IGetProviderDetails> _mockProviders;

        [SetUp]
        public void Setup()
        {
            _mockBasket = new Mock<IApprenticeshipFavouritesBasketStore>();
            _mockFramework = new Mock<IGetFrameworks>();
            _mockStandard = new Mock<IGetStandards>();
            _mockProviders = new Mock<IGetProviderDetails>();

            _mockStandard.Setup(s => s.GetStandardById(It.IsAny<string>())).Returns(new Standard(){Title = "Title", Level = 2,Duration = 18});

            _sut = new GetBasketHandler(new NullLogger<GetBasketHandler>(), _mockBasket.Object,_mockStandard.Object,_mockFramework.Object,_mockProviders.Object);

            var basket = new ApprenticeshipFavouritesBasket();
            basket.Add("23");

            _mockBasket.Setup(x => x.GetAsync(It.IsAny<Guid>())).ReturnsAsync(basket);
        }

        [Test]
        public async Task Handle_ReturnsBasketFromCache_ForGivenBasketId()
        {
            var basketId = Guid.NewGuid();

            var request = new GetBasketQuery
            {
                BasketId = basketId
            };

            var response = await _sut.Handle(request, default(CancellationToken));

            response.Should().NotBeNull();
            response.Should().NotBeEmpty();
            _mockBasket.Verify(x => x.GetAsync(basketId));
        }

        [Test]
        public async Task Handle_ReturnsEmptyBasket_IfBasketDoesNotExist()
        {
            _mockBasket.Setup(x => x.GetAsync(It.IsAny<Guid>())).ReturnsAsync((ApprenticeshipFavouritesBasket)null);

            var basketId = Guid.NewGuid();

            var request = new GetBasketQuery
            {
                BasketId = basketId
            };

            var response = await _sut.Handle(request, default(CancellationToken));

            response.Should().NotBeNull();
            response.Should().BeEmpty();
            _mockBasket.Verify(x => x.GetAsync(basketId));
        }
    }
}
