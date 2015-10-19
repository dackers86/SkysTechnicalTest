using Xunit;
using NSubstitute;
using SkyTechnicalTest.Repository;
using SkyTechnicalTest.Domain;
using FluentValidation;
using SkyTechnicalTest.Domain.Models;
using System.Collections.Generic;
using System;
using FluentValidation.Results;

namespace SkyTechnicalTest.Services.Tests
{
    public class BillingUnitTests
    {
        [Fact]
        public void WhenABillIsRequested_ThenABillShouldBeReturned()
        {
            // Arrange
            var id = 1;

            var bill = new Bill
            {
                CallCharges = new CallCharges { Calls = new List<Call> { new Call { Called = string.Empty, Cost = 0.00, Duration = string.Empty } } },
                Package = new Package { Subscriptions = new List<Subscription> { new Subscription { Type = string.Empty, Cost = 0.00, Name = string.Empty } } },
                SkyStore = new SkyStore { BuyAndKeeps = new List<BuyAndKeep> { new BuyAndKeep { Cost = 0.00, Title = string.Empty } } },
                Statement = new Statement { Due = DateTime.Now, Generated = DateTime.Now, Period = new Period { From = DateTime.Now, To = DateTime.Now } },
                Total = 0.00
            };


            var _billingRepository = Substitute.For<IBillingRepository>();
            _billingRepository.Get(id)
                              .Returns(bill);

            var _billingService = new BillingService(_billingRepository);

            // Act
            var actual = _billingService.Get(id);

            //Assert
            Assert.NotNull(actual);
        }
    }
}
