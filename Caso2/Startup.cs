﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Caso2.Startup))]
namespace Caso2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
