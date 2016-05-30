using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TS.Web.Startup))]
namespace TS.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
