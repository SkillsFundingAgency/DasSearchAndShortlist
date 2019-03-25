﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using SFA.DAS.Apprenticeships.Api.Types.AssessmentOrgs;
using SFA.DAS.Apprenticeships.Api.Types.Exceptions;

namespace Sfa.Das.Sas.Web.UnitTests.Application.Handlers
{
    using Core.Domain.Model;
    using Core.Domain.Services;
    using FluentAssertions;
    using Moq;
    using NUnit.Framework;
    using Sas.ApplicationServices.Handlers;
    using Sas.ApplicationServices.Queries;
    using Sas.ApplicationServices.Responses;
    using SFA.DAS.AssessmentOrgs.Api.Client;
    using SFA.DAS.NLog.Logger;

    [TestFixture]
    public sealed class GetStandardHandlerTest
    {
        private GetStandardHandler _sut;
        private Mock<IGetStandards> _mockGetStandards;
        private Mock<IAssessmentOrgsApiClient> _mockAssessmentOrgsClient;
        [SetUp]
        public void Init()
        {
            _mockGetStandards = new Mock<IGetStandards>();
            _mockAssessmentOrgsClient = new Mock<IAssessmentOrgsApiClient>();

            _sut = new GetStandardHandler(_mockGetStandards.Object, _mockAssessmentOrgsClient.Object, Mock.Of<ILog>());
        }

        [Test]
        public void ShouldReturnInvalidStandardIdStatusIfIdIsBelowZero()
        {
            var response = _sut.Handle(new GetStandardQuery { Id = "-1", Keywords = "Test" }, default(CancellationToken)).Result;

            response.StatusCode.Should().Be(GetStandardResponse.ResponseCodes.InvalidStandardId);
        }

        [Test]
        public void ShouldReturnStandardNotFoundStatusIfStandardCannotBeFound()
        {
            var response = _sut.Handle(new GetStandardQuery() { Id = "1", Keywords = "Test" }, default(CancellationToken)).Result;

            response.StatusCode.Should().Be(GetStandardResponse.ResponseCodes.StandardNotFound);
        }

        [Test]
        public void ShouldReturnStandardGoneStatusIfStandardIsNotActive()
        {
            var query = new GetStandardQuery() { Id = "1", Keywords = "Test" };

            var standard = new Standard { StandardId = query.Id, IsActiveStandard = false };

            _mockGetStandards.Setup(x => x.GetStandardById(query.Id)).Returns(standard);

            var response = _sut.Handle(query, default(CancellationToken)).Result;

            response.StatusCode.Should().Be(GetStandardResponse.ResponseCodes.Gone);
        }

        [Test]
        public void ShouldGetStandardFromGetStandardRepository()
        {
            var query = new GetStandardQuery() { Id = "1", Keywords = "Test" };

            _mockGetStandards.Setup(x => x.GetStandardById(query.Id));

            _sut.Handle(query, default(CancellationToken)).Wait();

            _mockGetStandards.Verify(x => x.GetStandardById(query.Id), Times.Once);
        }

        [Test]
        public void ShouldReturnFoundStandardInResponse()
        {
            var query = new GetStandardQuery() { Id = "1", Keywords = "Test" };
            var standard = new Standard { StandardId = query.Id, IsActiveStandard = true};

            _mockGetStandards.Setup(x => x.GetStandardById(query.Id)).Returns(standard);

            var response = _sut.Handle(query, default(CancellationToken)).Result;

            _mockGetStandards.VerifyAll();
            response.Standard.Should().Be(standard);
        }

        [Test]
        public void ShouldReturnFoundStandardAssessmentOrgsInResponse()
        {
            var query = new GetStandardQuery() { Id = "1", Keywords = "Test" };
            var standard = new Standard { StandardId = query.Id, IsActiveStandard = true};
            var orgs = new List<Organisation> { new Organisation() };
            _mockGetStandards.Setup(x => x.GetStandardById(query.Id)).Returns(standard);
            _mockAssessmentOrgsClient.Setup(x => x.ByStandard(query.Id)).Returns(orgs);
            var response = _sut.Handle(query, default(CancellationToken)).Result;

            _mockGetStandards.VerifyAll();
            _mockAssessmentOrgsClient.VerifyAll();
            response.AssessmentOrganisations.Count.Should().Be(1);
        }

        [Test]
        public void ShouldReturnNoFoundStandardAssessmentOrgsIfNoneInResponse()
        {
            var query = new GetStandardQuery() { Id = "1", Keywords = "Test" };
            var standard = new Standard { StandardId = query.Id, IsActiveStandard = true};
            _mockGetStandards.Setup(x => x.GetStandardById(query.Id)).Returns(standard);
            _mockAssessmentOrgsClient.Setup(x => x.ByStandard(query.Id)).Returns((IEnumerable<Organisation>)null);
            var response = _sut.Handle(query, default(CancellationToken)).Result;

            _mockGetStandards.VerifyAll();
            _mockAssessmentOrgsClient.VerifyAll();
            response.AssessmentOrganisations.Count.Should().Be(0);
        }

        [Test]
        public void ShouldGenerateAHttpRequestExceptionIfHttpExceptionThrownByAssessmentOrgsClient()
        {
            var query = new GetStandardQuery() { Id = "1", Keywords = "Test" };
            var standard = new Standard { StandardId = query.Id, IsActiveStandard = true};
            _mockGetStandards.Setup(x => x.GetStandardById(query.Id)).Returns(standard);
            _mockAssessmentOrgsClient.Setup(x => x.ByStandard(query.Id)).Throws(new HttpRequestException());
            var response = _sut.Handle(query, default(CancellationToken)).Result;

            _mockGetStandards.VerifyAll();
            _mockAssessmentOrgsClient.VerifyAll();

            response.StatusCode.Should().Be(GetStandardResponse.ResponseCodes.HttpRequestException);
            response.AssessmentOrganisations.Should().BeNull();
        }

        [Test]
        public void ShouldGenerateAnEntityNotFoundExceptionIfEntityNotFoundExceptionThrownByAssessmentOrgsClient()
        {
            var entityNotfoundException = new EntityNotFoundException(string.Empty, new Exception());
            var query = new GetStandardQuery() { Id = "1", Keywords = "Test" };
            var standard = new Standard { StandardId = query.Id, IsActiveStandard = true};
            _mockGetStandards.Setup(x => x.GetStandardById(query.Id)).Returns(standard);
            _mockAssessmentOrgsClient.Setup(x => x.ByStandard(query.Id)).Throws(entityNotfoundException);
            var response = _sut.Handle(query, default(CancellationToken)).Result;

            _mockGetStandards.VerifyAll();
            _mockAssessmentOrgsClient.VerifyAll();

            response.StatusCode.Should().Be(GetStandardResponse.ResponseCodes.AssessmentOrgsEntityNotFound);
            response.AssessmentOrganisations.Should().BeEquivalentTo(new List<Organisation>());
        }

        [Test]
        public void ShouldReturnSearchTerms()
        {
            var query = new GetStandardQuery { Id = "1", Keywords = "Test" };
            var standard = new Standard { StandardId = query.Id, IsActiveStandard = true};

            _mockGetStandards.Setup(x => x.GetStandardById(query.Id)).Returns(standard);

            var response = _sut.Handle(query, default(CancellationToken)).Result;

            _mockGetStandards.VerifyAll();
            response.SearchTerms.Should().Be(query.Keywords);
        }
    }
}
