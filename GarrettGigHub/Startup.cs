using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GarrettGigHub.Startup))]
namespace GarrettGigHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
