﻿using System.Threading;
using FluentAssertions;
using Moq;
using NUnit.Framework;
using Sfa.Das.Sas.ApplicationServices.Handlers;
using Sfa.Das.Sas.ApplicationServices.Queries;
using Sfa.Das.Sas.ApplicationServices.Responses;
using Sfa.Das.Sas.Core.Domain.Model;
using Sfa.Das.Sas.Core.Domain.Services;

namespace Sfa.Das.Sas.Web.UnitTests.Application.Handlers
{
    [TestFixture]
    public class GetStandardProvidersHandlerTest
    {
        private GetStandardProvidersHandler _sut;
        private Mock<IGetStandards> _mockGetStandards;

        [SetUp]
        public void Init()
        {
            _mockGetStandards = new Mock<IGetStandards>();

            _sut = new GetStandardProvidersHandler(_mockGetStandards.Object);
        }

        [Test]
        public void ShouldReturnStandardDetails()
        {
            var standard = new Standard
            {
                StandardId = "2",
                Title = "test standard",
                Level = 3
            };

            var query = new GetStandardProvidersQuery
            {
                StandardId = standard.StandardId,
                Keywords = "Test keywords",
                Postcode = "AB1 2CD"
            };

            _mockGetStandards.Setup(x => x.GetStandardById(standard.StandardId)).Returns(standard);

            var response = _sut.Handle(query, default(CancellationToken)).Result;

            response.StandardId.Should().Be(standard.StandardId);
            response.Keywords.Should().Be(query.Keywords);
            response.Postcode.Should().Be(query.Postcode);
            response.Title.Should().Be(standard.Title + ", level " + standard.Level);
        }

        [Test]
        public void ShouldReturnNotFoundIsStandardCannotBeFound()
        {
            _mockGetStandards.Setup(x => x.GetStandardById(It.IsAny<string>()));

            var response = _sut.Handle(new GetStandardProvidersQuery(), default(CancellationToken)).Result;

            response.StatusCode.Should().Be(GetStandardProvidersResponse.ResponseCodes.NoStandardFound);
        }
    }
}
