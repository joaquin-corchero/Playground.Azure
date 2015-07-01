using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Playground.Azure.Web.Startup))]
namespace Playground.Azure.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
