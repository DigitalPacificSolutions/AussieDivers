using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AussieDivers.Startup))]
namespace AussieDivers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
