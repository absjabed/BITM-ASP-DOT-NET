using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCIntroWebApp.Startup))]
namespace MVCIntroWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
