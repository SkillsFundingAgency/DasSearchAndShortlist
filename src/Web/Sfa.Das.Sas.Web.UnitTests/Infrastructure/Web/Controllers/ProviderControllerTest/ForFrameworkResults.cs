﻿using System.Threading;
using Sfa.Das.Sas.ApplicationServices.Responses;

namespace Sfa.Das.Sas.Web.UnitTests.Infrastructure.Web.Controllers.ProviderControllerTest
{
    using System;
    using System.Net;
    using System.Threading.Tasks;
    using System.Web.Mvc;
    using System.Web.Routing;

    using ApplicationServices.Queries;

    using AutoMapper;

    using ControllerBuilders;
    using FluentAssertions;

    using Moq;
    using NUnit.Framework;
    using Sas.Web.Controllers;
    using ViewModels;

    [TestFixture]
    public class ForFrameworkResults
    {
        [Test]
        public async Task FrameworkSearchResultsShouldReturnBadRequestStatusCodeIfApprenticeshipIdIsInvalid()
        {
            var stubSearchResponse = new ProviderSearchResponse { Success = true, StatusCode = ProviderSearchResponseCodes.InvalidApprenticeshipId };

            var stubViewModel = new ProviderFrameworkSearchResultViewModel();

            ProviderController controller = new ProviderControllerBuilder()
                                .SetupMappingService(x => x.Map<ProviderSearchResponse, ProviderFrameworkSearchResultViewModel>(It.IsAny<ProviderSearchResponse>()), stubViewModel)
                                .SetupMediator(x => x.Send<ProviderSearchResponse>(It.IsAny<ProviderSearchQuery>(), default(CancellationToken)), Task.FromResult(stubSearchResponse));

            var result = await controller.FrameworkResults(new ProviderSearchQuery());

            result.Should().BeOfType<HttpStatusCodeResult>();

            var viewResult = (HttpStatusCodeResult)result;

            viewResult.StatusCode.Should().Be((int)HttpStatusCode.BadRequest);
        }

        [Test]
        public async Task FrameworkSearchResultsShouldReturnNotFoundStatusCodeIfTheFrameworkIsNotFound()
        {
            var stubSearchResponse = new ProviderSearchResponse { Success = true, StatusCode = ProviderSearchResponseCodes.ApprenticeshipNotFound };

            var stubViewModel = new ProviderFrameworkSearchResultViewModel();

            ProviderController controller = new ProviderControllerBuilder()
                                .SetupMappingService(x => x.Map<ProviderSearchResponse, ProviderFrameworkSearchResultViewModel>(It.IsAny<ProviderSearchResponse>()), stubViewModel)
                                .SetupMediator(x => x.Send<ProviderSearchResponse>(It.IsAny<ProviderSearchQuery>(),default(CancellationToken)), Task.FromResult(stubSearchResponse));

            var result = await controller.FrameworkResults(new ProviderSearchQuery());

            result.Should().BeOfType<HttpStatusCodeResult>();

            var viewResult = (HttpStatusCodeResult)result;

            viewResult.StatusCode.Should().Be((int)HttpStatusCode.NotFound);
        }

        [Test]
        public async Task SearchResultsShouldRedirectToSearchEntryPageIfPostCodeIsNotSet()
        {
            var stubSearchResponse = new ProviderSearchResponse { Success = true, StatusCode = ProviderSearchResponseCodes.PostCodeInvalidFormat };
            var mockUrlHelper = new Mock<UrlHelper>();
            mockUrlHelper.Setup(x => x.Action("SearchForFrameworkProviders", "Apprenticeship", It.IsAny<object>())).Returns("someurl");

            var stubViewModel = new ProviderFrameworkSearchResultViewModel();

            ProviderController controller = new ProviderControllerBuilder()
                                .SetupMappingService(x => x.Map<ProviderSearchResponse, ProviderFrameworkSearchResultViewModel>(It.IsAny<ProviderSearchResponse>()), stubViewModel)
                                .SetupMediator(x => x.Send<ProviderSearchResponse>(It.IsAny<ProviderSearchQuery>(), default(CancellationToken)), Task.FromResult(stubSearchResponse))
                                .WithUrl(mockUrlHelper.Object);

            var result = await controller.FrameworkResults(new ProviderSearchQuery());

            result.Should().BeOfType<RedirectResult>();

            var viewResult = (RedirectResult)result;

            viewResult.Url.Should().Be("someurl");
        }

        [Test]
        public async Task SearchResultsShouldRedirectToLatPageIfParameterExtendsUpperBound()
        {
            var stubSearchResponse = new ProviderSearchResponse { Success = true, StatusCode = ProviderSearchResponseCodes.PageNumberOutOfUpperBound };
            var mockUrlHelper = new Mock<UrlHelper>();
            mockUrlHelper.Setup(x => x.Action("FrameworkResults", "Provider", It.IsAny<RouteValueDictionary>())).Returns("someurl");

            var stubViewModel = new ProviderFrameworkSearchResultViewModel();

            ProviderController controller = new ProviderControllerBuilder()
                                .SetupMappingService(x => x.Map<ProviderSearchResponse, ProviderFrameworkSearchResultViewModel>(It.IsAny<ProviderSearchResponse>()), stubViewModel)
                                .SetupMediator(x => x.Send<ProviderSearchResponse>(It.IsAny<ProviderSearchQuery>(),default(CancellationToken)), Task.FromResult(stubSearchResponse))
                                .WithUrl(mockUrlHelper.Object);

            var result = await controller.FrameworkResults(new ProviderSearchQuery());

            result.Should().BeOfType<RedirectResult>();

            var viewResult = (RedirectResult)result;

            viewResult.Url.Should().Be("someurl");
        }

        [Test]
        public async Task SearchResultsShouldReturnViewResultWhenFrameworkSearchIsSuccessful()
        {
            var stubSearchResponse = new ProviderSearchResponse { Success = true, StatusCode = ProviderSearchResponseCodes.Success };

            var stubViewModel = new ProviderFrameworkSearchResultViewModel { Title = "title1" };

            ProviderController controller =
                new ProviderControllerBuilder().SetupMappingService(
                    x => x.Map(It.IsAny<ProviderSearchResponse>(), It.IsAny<Action<IMappingOperationOptions<ProviderSearchResponse, ProviderFrameworkSearchResultViewModel>>>()),
                    stubViewModel).SetupMediator(x => x.Send<ProviderSearchResponse>(It.IsAny<ProviderSearchQuery>(), default(CancellationToken)), Task.FromResult(stubSearchResponse));

            var searchCriteria = new ProviderSearchQuery { ApprenticeshipId = "123", PostCode = "AB3 1SD" };

            var result = await controller.FrameworkResults(searchCriteria);

            result.Should().BeOfType<ViewResult>();

            var viewResult = (ViewResult)result;
            viewResult.Model.Should().Be(stubViewModel);
        }
    }
}
