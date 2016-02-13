using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Travel.Startup))]
namespace MVC_Travel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
