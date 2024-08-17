using System.Web.Http;
using B3.Investimento.API.Interfaces;
using B3.Investimento.API.Services;
using Unity;
using Unity.WebApi;

namespace B3.Investimento.API
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
             container.RegisterType<ICdbService, CdbService>();
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}