using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;
using Nancy.TinyIoc;
using Nancy.Bootstrapper;
using SkyTechnicalTest.Domain.Interfaces;
using SkyTechnicalTest.Services;

namespace SkyTechnicalTest
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
        {
            container.Register<IBillingService, BillingService>().AsSingleton();
        }
    }
}