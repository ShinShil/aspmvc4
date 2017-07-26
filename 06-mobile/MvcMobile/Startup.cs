using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcMobile.Startup))]
namespace MvcMobile
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
