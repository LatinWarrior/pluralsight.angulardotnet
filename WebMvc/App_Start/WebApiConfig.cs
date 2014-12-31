using System.Web.Http;
using Newtonsoft.Json.Serialization;

namespace WebMvc.App_Start
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {            
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            var jsonFormatter = GlobalConfiguration.Configuration.Formatters.JsonFormatter;
            jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        }
    }
}