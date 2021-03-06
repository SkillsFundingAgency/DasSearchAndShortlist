﻿namespace Sfa.Das.Sas.Web.UnitTests.Infrastructure.Web.Services
{
    using System.Collections.Generic;
    using FluentAssertions;
    using NUnit.Framework;
    using Sas.Web.Services.MappingActions.Helpers;
    using SFA.DAS.Apprenticeships.Api.Types.Providers;

    [TestFixture]
    public class ForMappingProviderToProviderDetailViewModelTests
    {
        private const string Phone = "123-456";
        private const string ProviderName = "Joe The Plumbers";
        private const string Email = "test@test.com";
        private const long UkPrn = 2221221;
        private const string Uri = "http://test.com/1234";
        private const string Website = "http://test.com";
        private const string MarketingInfo = "some marketing info";
        private const int NoSatisfactionScore = 0;
        private const string NoSatisfactionScoreMessage = "no data available";

        [Test]
        public void ShouldMapAllPassthroughValuesCorrectly()
        {
            var provider = GetProvider();
            var apprenticeshipTrainingSummary = GetApprenticeshipTrainingSummary();
            var providerDetails = ProviderDetailViewModelMapper.GetProviderDetailViewModel(provider, apprenticeshipTrainingSummary);
            providerDetails.Email.Should().Be(Email);
            providerDetails.IsEmployerProvider.Should().BeTrue();
            providerDetails.IsHigherEducationInstitute.Should().BeTrue();
            providerDetails.NationalProvider.Should().BeTrue();
            providerDetails.Phone.Should().Be(Phone);
            providerDetails.UkPrn.Should().Be(UkPrn);
            providerDetails.ProviderName.Should().Be(ProviderName);
            providerDetails.Website.Should().Be(Website);
            providerDetails.MarketingInfo.Should().Be(MarketingInfo);
            providerDetails.ApprenticeshipTrainingSummary.Should().Be(apprenticeshipTrainingSummary);
            providerDetails.DisplayAboutThisProvider.Should().Be(true);

        }

        [Test]
        public void ShouldMapAllEmptyAliasValuesCorrectly()
        {
            var provider = GetProvider();

            var providerDetails = ProviderDetailViewModelMapper.GetProviderDetailViewModel(provider, GetApprenticeshipTrainingSummary());
            providerDetails.TradingNames.Should().Be(null);
        }

        [Test]
        public void ShouldMapAllSingleAliasValuesCorrectly()
        {
            var aliases = new List<string> {"alias 1"};
            const string tradingNames = "alias 1";

            var provider = GetProvider();
            provider.Aliases = aliases;

            var providerDetails = ProviderDetailViewModelMapper.GetProviderDetailViewModel(provider, GetApprenticeshipTrainingSummary());
            providerDetails.TradingNames.Should().Be(tradingNames);
            providerDetails.DisplayAboutThisProvider.Should().Be(true);
         }

        [Test]
        public void ShouldNotDisplayAboutThisProvider()
        {
        var aliases = new List<string> { "alias 1" };
        const string tradingNames = "alias 1";

        var provider = GetProvider();
        provider.Aliases = aliases;

        var providerDetails = ProviderDetailViewModelMapper.GetProviderDetailViewModel(provider, GetApprenticeshipTrainingSummary(), new List<long> { UkPrn });
        providerDetails.DisplayAboutThisProvider.Should().Be(false);
        }

        [Test]
        public void ShouldMapMultipleAliasValuesCorrectly()
        {
            var aliases = new List<string> { "alias 1", "alias 2", "alias 3" };
            const string tradingNames = "alias 1, alias 2, alias 3";

            var provider = GetProvider();
            provider.Aliases = aliases;

            var providerDetails = ProviderDetailViewModelMapper.GetProviderDetailViewModel(provider, GetApprenticeshipTrainingSummary());
            providerDetails.TradingNames.Should().Be(tradingNames);
        }

        [Test]
        public void ShouldMapAllSeveralAliasValuesCorrectly()
        {
            var aliases = new List<string> { "alias 1", "alias 5", "alias 2" };
            var tradingNames = "alias 1, alias 5, alias 2";

            var provider = GetProvider();
            provider.Aliases = aliases;

            var providerDetails = ProviderDetailViewModelMapper.GetProviderDetailViewModel(provider, GetApprenticeshipTrainingSummary());
            providerDetails.TradingNames.Should().Be(tradingNames);
        }

        [Test]
        public void ShouldMapZeroEmployerSatisfactionValuesCorrectly()
        {
            var provider = GetProvider();
            provider.EmployerSatisfaction = 0;

            var providerDetails = ProviderDetailViewModelMapper.GetProviderDetailViewModel(provider, GetApprenticeshipTrainingSummary());
            providerDetails.EmployerSatisfaction.Should().Be(NoSatisfactionScore);
            providerDetails.EmployerSatisfactionMessage.Should().Be(NoSatisfactionScoreMessage);
        }

        [Test]
        public void ShouldMapNonZeroEmployerSatisfactionValuesCorrectly()
        {
            var provider = GetProvider();
            const double providerEmployerSatisfaction = 1.5;
            provider.EmployerSatisfaction = providerEmployerSatisfaction;
            const string expectedEmployerSatisfactionMessage = "1.5%";

            var providerDetails = ProviderDetailViewModelMapper.GetProviderDetailViewModel(provider, GetApprenticeshipTrainingSummary());
            providerDetails.EmployerSatisfaction.Should().Be(providerEmployerSatisfaction);
            providerDetails.EmployerSatisfactionMessage.Should().Be(expectedEmployerSatisfactionMessage);
        }

        [Test]
        public void ShouldMapZeroLearnerSatisfactionValuesCorrectly()
        {
            var provider = GetProvider();
            provider.LearnerSatisfaction = 0;

            var providerDetails = ProviderDetailViewModelMapper.GetProviderDetailViewModel(provider, GetApprenticeshipTrainingSummary());
            providerDetails.LearnerSatisfaction.Should().Be(NoSatisfactionScore);
            providerDetails.LearnerSatisfactionMessage.Should().Be(NoSatisfactionScoreMessage);
        }

        [Test]
        public void ShouldMapNonZeroLearnerSatisfactionValuesCorrectly()
        {
            var provider = GetProvider();
            const double providerLearnerSatisfaction = 53.3;
            provider.LearnerSatisfaction = providerLearnerSatisfaction;
            const string expectedLearnerSatisfactionMessage = "53.3%";

            var providerDetails = ProviderDetailViewModelMapper.GetProviderDetailViewModel(provider, GetApprenticeshipTrainingSummary());
            providerDetails.LearnerSatisfaction.Should().Be(providerLearnerSatisfaction);
            providerDetails.LearnerSatisfactionMessage.Should().Be(expectedLearnerSatisfactionMessage);
        }

        [Test]
        public void ShouldMapIsEmployerProviderTrueCorrectly()
        {
            var provider = GetProvider();
            provider.IsEmployerProvider = true;
            var providerDetails = ProviderDetailViewModelMapper.GetProviderDetailViewModel(provider, GetApprenticeshipTrainingSummary());
            providerDetails.IsEmployerProvider.Should().BeTrue();
         }

        [Test]
        public void ShouldMapIsEmployerProviderFalseCorrectly()
        {
            var provider = GetProvider();
            provider.IsEmployerProvider = false;
            var providerDetails = ProviderDetailViewModelMapper.GetProviderDetailViewModel(provider, GetApprenticeshipTrainingSummary());
            providerDetails.IsEmployerProvider.Should().BeFalse();
        }

        [Test]
        public void ShouldMapIsHigherEducationInstituteTrueCorrectly()
        {
            var provider = GetProvider();
            provider.IsHigherEducationInstitute = true;
            var providerDetails = ProviderDetailViewModelMapper.GetProviderDetailViewModel(provider, GetApprenticeshipTrainingSummary());
            providerDetails.IsHigherEducationInstitute.Should().BeTrue();
        }

        [Test]
        public void ShouldMapIsHigherEducationInstituterFalseCorrectly()
        {
            var provider = GetProvider();
            provider.IsHigherEducationInstitute = false;
            var providerDetails = ProviderDetailViewModelMapper.GetProviderDetailViewModel(provider, GetApprenticeshipTrainingSummary());
            providerDetails.IsHigherEducationInstitute.Should().BeFalse();
        }

        [Test]
        public void ShouldMapNationalProviderTrueCorrectly()
        {
            var provider = GetProvider();
            provider.NationalProvider = true;
            var providerDetails = ProviderDetailViewModelMapper.GetProviderDetailViewModel(provider, GetApprenticeshipTrainingSummary());
            providerDetails.NationalProvider.Should().BeTrue();
        }

        [Test]
        public void ShouldMapNationalProviderFalseCorrectly()
        {
            var provider = GetProvider();
            provider.NationalProvider = false;
            var providerDetails = ProviderDetailViewModelMapper.GetProviderDetailViewModel(provider, GetApprenticeshipTrainingSummary());
            providerDetails.NationalProvider.Should().BeFalse();
        }

        private static Provider GetProvider()
        {
            return new Provider
            {
                Aliases = null,
                EmployerSatisfaction = NoSatisfactionScore,
                LearnerSatisfaction = NoSatisfactionScore,
                Email = Email,
                IsEmployerProvider = true,
                IsHigherEducationInstitute = true,
                NationalProvider = true,
                Phone = Phone,
                Ukprn = UkPrn,
                ProviderName = ProviderName,
                Uri = Uri,
                Website = Website,
                MarketingInfo = MarketingInfo
            };
        }

    
        private static ApprenticeshipTrainingSummary GetApprenticeshipTrainingSummary()
        {
            return new ApprenticeshipTrainingSummary();
        }
    }
}