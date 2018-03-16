using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjektniCentar1.Startup))]
namespace ProjektniCentar1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
