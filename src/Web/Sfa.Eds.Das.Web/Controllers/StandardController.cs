﻿namespace Sfa.Eds.Das.Web.Controllers
{
    using System;
    using System.Globalization;
    using System.Web.Mvc;

    using Sfa.Das.ApplicationServices;
    using Sfa.Das.ApplicationServices.Models;
    using Sfa.Eds.Das.Core.Domain.Services;
    using Sfa.Eds.Das.Core.Logging;
    using Sfa.Eds.Das.Web.Models;
    using Sfa.Eds.Das.Web.Services;
    using Sfa.Eds.Das.Web.ViewModels;
    using Core.Domain.Model;

    public class StandardController : Controller
    {
        private readonly IStandardSearchService searchService;

        private readonly IStandardRepository standardRepository;

        private readonly ILog _logger;
        private readonly IMappingService _mappingService;

        public StandardController(IStandardSearchService searchService, IStandardRepository standardRepository, ILog logger, IMappingService mappingService)
        {
            this.searchService = searchService;
            this.standardRepository = standardRepository;
            _logger = logger;
            _mappingService = mappingService;
        }

        public ActionResult Search()
        {
            return View();
        }

        [HttpGet]
        public ActionResult SearchResults(StandardCriteria criteria)
        {
            var searchResults = this.searchService.SearchByKeyword(criteria.Keywords, criteria.Skip, criteria.Take);

            var viewModel = _mappingService.Map<StandardSearchResults, StandardSearchResultViewModel>(searchResults);

            return View(viewModel);
        }

        // GET: Standard
        public ActionResult Detail(string id)
        {
            var standardResult = this.standardRepository.GetById(id);
            if (standardResult == null)
            {
                var message = $"Cannot find standard: {id}";
                _logger.Warn($"404 - {message}");
                return new HttpNotFoundResult(message);
            }

            var viewModel = _mappingService.Map<Standard, StandardViewModel>(standardResult);
            viewModel.SearchResultLink = GetSearchResultUrl(Request.UrlReferrer);
            return View(viewModel);
        }

        private LinkViewModel GetSearchResultUrl(Uri urlReferrer)
        {
            if (urlReferrer != null && urlReferrer.OriginalString.ToLower(CultureInfo.CurrentCulture).Contains("?keywords"))
            {
                return new LinkViewModel { Title = "Results", Url = urlReferrer.OriginalString };
            }

            return new LinkViewModel { Title = "Back to search page", Url = Url.Action("Search", "Standard") };
        }
    }
}