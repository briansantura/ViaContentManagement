using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ViaContentManagement.Web.Startup))]
namespace ViaContentManagement.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
