using Nancy;
using Nancy.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Xunit;
using NSubstitute;
using SkyTechnicalTest.Domain.Interfaces;
using SkyTechnicalTest.Domain;

namespace SkyTechnicalTest.Tests.UnitTesting
{
    public class BillingTests
    {
        [Fact]
        public void WhenBillingIsRequested_ThenAValidResponseShouldbeReturned()
        {
            // Arrange
            var id = 1;
            var bootstrapper = new Bootstrapper();
            var browser = new Browser(bootstrapper);
            var expected = new Bill();

            var service = Substitute.For<IBillingService>();
            service.Get(id).Returns(expected);

            // Act
            var result = browser.Get("/billing", with =>
            {
                with.HttpRequest();
            });

            // Assert
            Assert.Equal(HttpStatusCode.OK, result.StatusCode);
        }


        [Fact]
        public void WhenADefaultRouteIsRequested_ThenA404ResponseShouldbeReturned()
        {
            // Arrange
            var bootstrapper = new Bootstrapper();
            var browser = new Browser(bootstrapper);

            // Act
            var result = browser.Get("/", with =>
            {
                with.HttpRequest();
            });

            // Assert
            Assert.Equal(HttpStatusCode.NotFound, result.StatusCode);
        }

        [Fact]
        public void WhenBillingIsRequested_ThenValidStatementDetailsShouldbeReturned()
        {
            // Arrange
            var id = 1;
            var bootstrapper = new Bootstrapper();
            var browser = new Browser(bootstrapper);
            var expected = new Bill();

            var service = Substitute.For<IBillingService>();
            service.Get(id).Returns(expected);

            // Act
            var result = browser.Get("/billing", with =>
            {
                with.HttpRequest();
            });

            // Assert
            Assert.Equal(HttpStatusCode.OK, result.StatusCode);
            Assert.NotNull(result);
        }
    }
}