using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcRecipeBook.Web.Startup))]
namespace mvcRecipeBook.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
