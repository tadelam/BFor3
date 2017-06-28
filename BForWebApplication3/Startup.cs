using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BForWebApplication3.Startup))]
namespace BForWebApplication3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
