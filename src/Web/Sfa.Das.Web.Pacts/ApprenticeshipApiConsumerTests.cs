﻿using System.Collections.Generic;
using NUnit.Framework;
using PactNet.Mocks.MockHttpService.Models;
using PactNet.TestExtensions;
using SFA.DAS.Apprenticeships.Api.Client;

namespace Sfa.Das.Web.Pacts
{
    [TestFixture]
    [PactProvider("Apprenticeship API")]
    public class ApprenticeshipApiClientTests : PactTestBase
    {
        [Test]
        public void ShouldGetaStandard()
        {
            //Arrange
            const int standardCode = 12;
            MockProviderService
                .UponReceiving($"a request to retrieve standard with id '{standardCode}'")
                .With(new ProviderServiceRequest
                {
                    Method = HttpVerb.Get,
                    Path = $"/standards/{standardCode}",
                    Headers = new Dictionary<string, string>
                    {
                        { "Accept", "application/json" }
                    }
                })
                .WillRespondWith(new ProviderServiceResponse
                {
                    Status = 200,
                    Headers = new Dictionary<string, string>
                    {
                        { "Content-Type", "application/json; charset=utf-8" }
                    },
                    Body = new
                    {
                        StandardId = standardCode.ToString()
                    }
                });

            var consumer = new StandardApiClient(MockProviderServiceBaseUri);

            //Act
            var result = consumer.Get(standardCode); // TODO is this needed?

            //Assert
            Assert.AreEqual(standardCode, result.StandardId);

            MockProviderService.VerifyInteractions();
        }
    }
}