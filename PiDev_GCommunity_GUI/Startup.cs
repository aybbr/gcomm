using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PiDev_GCommunity_GUI.Startup))]
namespace PiDev_GCommunity_GUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
