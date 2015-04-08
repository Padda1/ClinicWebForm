﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClinicWebForm.Startup))]
namespace ClinicWebForm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
            ConfigureAuth(app);
        }
    }
}
