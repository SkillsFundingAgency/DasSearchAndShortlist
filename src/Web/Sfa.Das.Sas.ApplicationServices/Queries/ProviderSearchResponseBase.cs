﻿using Sfa.Das.Sas.ApplicationServices.Models;

namespace Sfa.Das.Sas.ApplicationServices.Queries
{
    public abstract class ProviderSearchResponseBase<T>
    {
        public enum ResponseCodes
        {
            Success,
            InvalidApprenticeshipId,
            PostCodeInvalidFormat,
            ApprenticeshipNotFound,
            PageNumberOutOfUpperBound,
            LocationServiceUnavailable,
            ServerError
        }

        public bool Success { get; set; }
        public int CurrentPage { get; set; }
        public T Results { get; set; }
        public ShortlistedApprenticeship Shortlist { get; set; }
        public long TotalResultsForCountry { get; set; }
        public string SearchTerms { get; set; }
        public bool ShowAllProviders { get; set; }
        public ResponseCodes StatusCode { get; set; }
    }
}
