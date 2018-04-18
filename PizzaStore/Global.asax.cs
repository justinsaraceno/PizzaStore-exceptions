using log4net;
using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace PizzaStore
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(HttpApplication));

        protected void Application_Start()
        {
            log4net.Config.XmlConfigurator.Configure();
            log.Debug("###Starting Application###");
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);            
        }

        void Application_Error(Object sender, EventArgs e)
        {
            Exception ex = Server.GetLastError().GetBaseException();
            if(ex.GetType() != typeof(HttpException))
            {
                log.Error("App_Error", ex);
            }
        }
    }
}
