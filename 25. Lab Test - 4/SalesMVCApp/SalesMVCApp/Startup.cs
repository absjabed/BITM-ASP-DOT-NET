using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SalesMVCApp.Startup))]
namespace SalesMVCApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
