using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PUCEntityFrameworkMVC.Startup))]
namespace PUCEntityFrameworkMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
