using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LM.Web.Startup))]
namespace LM.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
