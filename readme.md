CrossFront Backend
===================

This is a backend to the cross platform project using asp.net mvc 4 web api. 


To get this to work I had to add a jsonp formatter nuget package `Install-Package WebApiContrib.Formatting.Jsonp`

Then I had to copy this file to the app_start folder.

`FormatterConfig.cs`

```
using System.Net.Http.Formatting;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using WebApiContrib.Formatting.Jsonp;

namespace WebContribContrib.Formatting.Jsonp.SampleWebHost.App_Start{
	public class FormatterConfig{
		public static void RegisterFormatters(MediaTypeFormatterCollection formatters){
			formatters.Remove(formatters.JsonFormatter);
			formatters.Insert(0, new JsonpMediaTypeFormatter {
				SerializerSettings = new JsonSerializerSettings {
					ContractResolver = new CamelCasePropertyNamesContractResolver()
				}
			});
		}
	}
}
```


Finally I had to add the reference to `global.asax`

```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;


namespace CrossFront_Web_Api
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            
            
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            WebContribContrib.Formatting.Jsonp.SampleWebHost.App_Start.FormatterConfig.RegisterFormatters(GlobalConfiguration.Configuration.Formatters);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

    }
}
```