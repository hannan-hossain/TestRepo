using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Mvc;
using TS.ServiceInterfaces;
using TS.RepositoryInterfaces;
using TS.Repositories;
using TS.Services;
using System.Web.Http;

namespace TS.Web
{
    public static class Bootstrapper
    {
        public static IUnityContainer Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            return container;
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers
            container.RegisterType<ITestService, TestService>();
            container.RegisterType<ITestRepository, TestRepository>();
           
            RegisterTypes(container);
            //GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);

            return container;
        }

        public static void RegisterTypes(IUnityContainer container)
        {

        }
    }
}