using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookBorrowSystemApp.Startup))]
namespace BookBorrowSystemApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
