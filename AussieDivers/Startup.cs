using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestMVCSite.Startup))]
namespace TestMVCSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
