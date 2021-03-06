﻿using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Routing;
using MediatR;
using SFA.DAS.NLog.Logger;
using Sfa.Das.Sas.ApplicationServices.Queries;
using Sfa.Das.Sas.ApplicationServices.Responses;
using Sfa.Das.Sas.Core.Configuration;
using Sfa.Das.Sas.Web.Extensions;
using Sfa.Das.Sas.Web.Services;
using Sfa.Das.Sas.Web.Services.MappingActions.Helpers;
using Sfa.Das.Sas.Web.ViewModels;
using SFA.DAS.Apprenticeships.Api.Types;

namespace Sfa.Das.Sas.Web.Controllers
{

    [OutputCacheAttribute(VaryByParam = "*", Duration = 0, NoStore = true)]
    public sealed class ProviderController : Controller
    {
        private readonly ILog _logger;
        private readonly IMappingService _mappingService;
        private readonly IMediator _mediator;
        private readonly IConfigurationSettings _settings;

        public ProviderController(
            ILog logger,
            IMappingService mappingService,
            IMediator mediator,
            IConfigurationSettings settings)
        {
            _logger = logger;
            _mappingService = mappingService;
            _mediator = mediator;
            _settings = settings;
        }

        [HttpGet]
        public async Task<ActionResult> StandardResults(ProviderSearchQuery criteria)
        {

            var response = await _mediator.Send(criteria);

            switch (response.StatusCode)
            {
                case ProviderSearchResponseCodes.InvalidApprenticeshipId:
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

                case ProviderSearchResponseCodes.ApprenticeshipNotFound:
                    return new HttpStatusCodeResult(HttpStatusCode.NotFound);

                case ProviderSearchResponseCodes.ServerError:
                    return new HttpStatusCodeResult(HttpStatusCode.InternalServerError);

                case ProviderSearchResponseCodes.LocationServiceUnavailable:
                case ProviderSearchResponseCodes.PostCodeInvalidFormat:
                case ProviderSearchResponseCodes.WalesPostcode:
                case ProviderSearchResponseCodes.ScotlandPostcode:
                case ProviderSearchResponseCodes.NorthernIrelandPostcode:
                case ProviderSearchResponseCodes.PostCodeTerminated:
                    var postCodeUrl = Url.Action(
                        "SearchForStandardProviders",
                        "Apprenticeship",
                        new { standardId = criteria?.ApprenticeshipId, statusCode = response.StatusCode, postCode = criteria?.PostCode, isLevyPayingEmployer = criteria?.IsLevyPayingEmployer });
                    return new RedirectResult(postCodeUrl);
                case ProviderSearchResponseCodes.PageNumberOutOfUpperBound:
                    var url = Url.Action(
                        "StandardResults",
                        "Provider",
                        GenerateProviderResultsRouteValues(criteria, response.CurrentPage));
                    return new RedirectResult(url);
            }

            var viewModel = _mappingService.Map<ProviderSearchResponse, ProviderStandardSearchResultViewModel>(response, opt => opt
                .AfterMap((src, dest) =>
                {
                    dest.AbsolutePath = Request?.Url?.AbsolutePath;
                    dest.IsLevyPayingEmployer = criteria.IsLevyPayingEmployer;
                    dest.ManageApprenticeshipFunds = new ManageApprenticeshipFundsViewModel(dest.IsLevyPayingEmployer, _settings.ManageApprenticeshipFundsUrl);
                    dest.SortOrder = criteria.Order.ToString();
                }));

            return View(viewModel);
        }

        [HttpGet]
        public async Task<ActionResult> FrameworkResults(ProviderSearchQuery criteria)
        {
            var response = await _mediator.Send(criteria);

            switch (response.StatusCode)
            {
                case ProviderSearchResponseCodes.InvalidApprenticeshipId:
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

                case ProviderSearchResponseCodes.ApprenticeshipNotFound:
                    return new HttpStatusCodeResult(HttpStatusCode.NotFound);

                case ProviderSearchResponseCodes.ServerError:
                    return new HttpStatusCodeResult(HttpStatusCode.InternalServerError);

                case ProviderSearchResponseCodes.LocationServiceUnavailable:
                case ProviderSearchResponseCodes.PostCodeInvalidFormat:
                case ProviderSearchResponseCodes.WalesPostcode:
                case ProviderSearchResponseCodes.ScotlandPostcode:
                case ProviderSearchResponseCodes.NorthernIrelandPostcode:
                case ProviderSearchResponseCodes.PostCodeTerminated:
                    var postCodeUrl = Url.Action(
                        "SearchForFrameworkProviders",
                        "Apprenticeship",
                        new { frameworkId = criteria?.ApprenticeshipId, statusCode = response.StatusCode, postCode = criteria?.PostCode, isLevyPayingEmployer = criteria?.IsLevyPayingEmployer });
                    return new RedirectResult(postCodeUrl);
                case ProviderSearchResponseCodes.PageNumberOutOfUpperBound:
                    var url = Url.Action(
                        "FrameworkResults",
                        "Provider",
                        GenerateProviderResultsRouteValues(criteria, response.CurrentPage));
                    return new RedirectResult(url);
            }

            var viewModel = _mappingService.Map<ProviderSearchResponse, ProviderFrameworkSearchResultViewModel>(response, opt => opt
                .AfterMap((src, dest) =>
                {
                    dest.AbsolutePath = Request?.Url?.AbsolutePath;
                    dest.IsLevyPayingEmployer = criteria.IsLevyPayingEmployer;
                    dest.ManageApprenticeshipFunds = new ManageApprenticeshipFundsViewModel(dest.IsLevyPayingEmployer, _settings.ManageApprenticeshipFundsUrl);
                }));

            return View(viewModel);
        }

        [HttpGet]
        public async Task<ActionResult> ProviderDetail(long ukprn, string providerName = "", string pageNumber = "", string keyword = "")
        {
            int page;
            if (!int.TryParse(pageNumber, out page))
            {
                page = 1;
            }

            var response = await _mediator.Send(new ProviderDetailQuery { UkPrn = ukprn, Page = page });

            if (response.StatusCode == ProviderDetailResponse.ResponseCodes.ProviderNotFound)
            {
                var message = $"Cannot find provider: {ukprn}";
                _logger.Warn($"404 - {message}");
                return new HttpNotFoundResult(message);
            }

            if (response.StatusCode == ProviderDetailResponse.ResponseCodes.HttpRequestException)
            {
                var message = $"Not able to call the apprenticeship service.";
                _logger.Warn($"{response.StatusCode} - {message}");

                return new HttpStatusCodeResult(HttpStatusCode.InternalServerError, message);
            }

            var viewModel = ProviderDetailViewModelMapper.GetProviderDetailViewModel(response.Provider,response.ApprenticeshipTrainingSummary,_settings.HideAboutProviderForUkprns,keyword);

            return View(viewModel);
        }


        public ActionResult Search()
        {
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> SearchResults(ProviderNameSearchQuery query)
        {
            var response = await _mediator.Send(query);

            var viewModel = _mappingService.Map<ProviderNameSearchResponse, ProviderNameSearchResultViewModel>(response);

            return View(viewModel);
        }

        [HttpGet]
        public async Task<ActionResult> Detail(ApprenticeshipProviderDetailQuery criteria)
        {
            var response = await _mediator.Send(criteria);

            switch (response.StatusCode)
            {
                case ApprenticeshipProviderDetailResponse.ResponseCodes.ApprenticeshipProviderNotFound:
                    _logger.Warn($"404 - Cannot find provider: ({criteria.UkPrn}) for apprenticeship product: ({criteria.FrameworkId ?? criteria.StandardCode}) with location: ({criteria.LocationId})");
                    return new HttpStatusCodeResult(HttpStatusCode.NotFound);

                case ApprenticeshipProviderDetailResponse.ResponseCodes.InvalidInput:
                    _logger.Warn($"400 - Bad Request: {criteria.UkPrn}");
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var viewModel = _mappingService.Map<ApprenticeshipProviderDetailResponse, ApprenticeshipDetailsViewModel>(response, opt => opt
                .AfterMap((src, dest) =>
                {
                    dest.SurveyUrl = _settings.SurveyUrl.ToString();
                    dest.SatisfactionSourceUrl = _settings.SatisfactionSourceUrl.ToString();
                    dest.AchievementRateSourceUrl = _settings.AchievementRateUrl.ToString();
                    dest.IsLevyPayingEmployer = criteria.IsLevyPayingEmployer;
                    dest.ManageApprenticeshipFunds = new ManageApprenticeshipFundsViewModel(dest.IsLevyPayingEmployer, _settings.ManageApprenticeshipFundsUrl);
                    dest.SearchTerm = criteria.Keyword;
                    dest.ApprenticeshipId = dest.ApprenticeshipType == ApprenticeshipTrainingType.Framework ? criteria.FrameworkId : criteria.StandardCode;
                    dest.Postcode = criteria.Postcode;
                }));

            return View(viewModel);
        }

        private static RouteValueDictionary GenerateProviderResultsRouteValues(ProviderSearchQuery criteria, int currentPage)
        {
            return new RouteValueDictionary()
                .AddValue("page", currentPage)
                .AddValue("postcode", criteria?.PostCode ?? string.Empty)
                .AddValue("apprenticeshipId", criteria?.ApprenticeshipId)
                .AddValue("showall", criteria?.ShowAll)
                .AddValue("isLevyPayingEmployer", criteria?.IsLevyPayingEmployer)
                .AddValue("keywords", criteria?.Keywords ?? string.Empty)
                .AddList("deliverymodes", criteria?.DeliveryModes);
        }
    }
}