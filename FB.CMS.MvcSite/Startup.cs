using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FB.CMS.MvcSite.Startup))]
namespace FB.CMS.MvcSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
