﻿using Microsoft.Owin;
using Owin;
using Hangfire;

[assembly: OwinStartup(typeof(UOKO.Jobs.Startup))]

namespace UOKO.Jobs
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // 有关如何配置应用程序的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkID=316888
            GlobalConfiguration.Configuration.UseSqlServerStorage("Hangfire");

            app.UseHangfireDashboard();
            app.UseHangfireServer();
        }
    }
}
