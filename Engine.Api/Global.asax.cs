using Engine.Ioc;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace Engine.Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var kernel = new StandardKernel(new IocBinding());
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
