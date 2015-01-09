using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Castle.Windsor;
using ClinicLibrary.IoC;
using ClinicWeb.IoC;
using System.IO;

namespace ClinicWeb
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private IWindsorContainer _container;

        protected void Application_Start()
        {
            string path = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.FullName;
            AppDomain.CurrentDomain.SetData("DataDirectory", System.IO.Path.Combine(path, "Databases"));

            _container = new WindsorContainer();
            _container.Install(new CoreInstaller(), new ControllerInstaller());
            var controllerFactory = new ControllerFactory(_container.Kernel);
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
