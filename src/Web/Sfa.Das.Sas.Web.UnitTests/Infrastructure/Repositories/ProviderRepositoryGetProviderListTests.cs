﻿namespace Sfa.Das.Sas.Web.UnitTests.Infrastructure.Repositories
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Moq;
    using NUnit.Framework;
    using Sas.Infrastructure.Repositories;
    using SFA.DAS.Apprenticeships.Api.Types.Providers;
    using SFA.DAS.Providers.Api.Client;

    [TestFixture]
    public class ProviderRepositoryGetProviderListTests
    {
        private List<ProviderSummary> _actualResult;
        private List<ProviderSummary> _expectedResult;

        [SetUp]
        public void Init()
        {
            var mockProviderApiClient = new Mock<IProviderApiClient>();
            const long ukprn = 11000;
            const long ukprn2 = 20;
            const long ukprn3 = 1;

            const string providerName1 = "first item added";
            const string providerName2 = "a second item";
            const string providerName3 = "third company";

            var providerSummaries = new List<ProviderSummary>
            {
                new ProviderSummary { Ukprn = ukprn, ProviderName = providerName1 },
                new ProviderSummary { Ukprn = ukprn2, ProviderName = providerName2 },
                new ProviderSummary { Ukprn = ukprn3, ProviderName = providerName3 }
            };

            _expectedResult = providerSummaries;

            mockProviderApiClient.Setup(x => x.FindAllAsync()).Returns(Task.FromResult((IEnumerable<ProviderSummary>)providerSummaries));
            var providerRepository = new ProviderDetailRepository(mockProviderApiClient.Object);
            var res = providerRepository.GetProviderList();
            _actualResult = res.Result.ToList();
        }

        [Test]
        public void ShouldProvideTheMatchingNumberOfProviderSummaries()
        {
            Assert.AreEqual(_actualResult, _expectedResult);
        }
    }
}