using Nancy;
using SkyTechnicalTest.Domain;
using SkyTechnicalTest.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkyTechnicalTest.Modules
{
    public class BillingModule : NancyModule
    {
        public BillingModule(IBillingService billingService) : base("/billing")
        {
            Get["/{id}"] = parameters =>
            {
                Bill result = billingService.Get(parameters.id);
                return Response.AsJson(result);
            };
        }
    }
}