﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace HarmonieSanteParamedicalMonolithic
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //var hospitalContext = new CHEntities();
            //Database.SetInitializer(new ConsultantsInitializer());
            //Database.SetInitializer(new PatientsInitializer());
            //Database.SetInitializer(new ConsultantsCalendarInitializer());

            //hospitalContext.Database.Initialize(true);
        }
    }
}