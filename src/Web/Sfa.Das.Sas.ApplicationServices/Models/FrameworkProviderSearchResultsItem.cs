﻿using System.Collections.Generic;
using Sfa.Das.Sas.Core.Domain.Model;

namespace Sfa.Das.Sas.ApplicationServices.Models
{
    public sealed class FrameworkProviderSearchResultsItem : IApprenticeshipProviderSearchResultsItem
    {
        public string Id { get; set; }

        public string Ukprn { get; set; }

        public string ProviderName { get; set; }

        public string FrameworkId { get; set; }

        public int FrameworkCode { get; set; }

        public int PathwayCode { get; set; }

        public int Level { get; set; }

        public string MarketingName { get; set; }

        public string ProviderMarketingInfo { get; set; }

        public string ApprenticeshipMarketingInfo { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string ContactUsUrl { get; set; }

        public string ApprenticeshipInfoUrl { get; set; }

        public List<string> DeliveryModes { get; set; }

        public string Website { get; set; }

        public IEnumerable<TrainingLocation> TrainingLocations { get; set; }

        public double Distance { get; set; }

        public double? EmployerSatisfaction { get; set; }

        public double? LearnerSatisfaction { get; set; }

        public int? MatchingLocationId { get; set; }
    }
}