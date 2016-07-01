using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Mvc;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel.Core.Implementation;
using Travel.Core.Interfaces;
using Travel.DAL;
using Travel.DAL.Implementation;
using Travel.DAL.Interfaces;

namespace Travel.Web.App_Start
{
    public static class UnityConfig
    {
        public static IUnityContainer Initialise()
        {
            // var unityContainer = new UnityContainer();
            // DependencyResolver.SetResolver(new UnityDependencyResolver(unityContainer));
            return BuildDIContainer();
        }

        private static IUnityContainer BuildDIContainer()
        {
            var container = new UnityContainer();

            container.RegisterType(typeof(IRepository<>), typeof(RepositoryBase<>));
            container.RegisterType<DbContext, TravelEntities>();
            container.RegisterType<IJourney, Journey>();
            container.RegisterType<IJourneyService, JourneyService>();
            return container;

        }
    }
}