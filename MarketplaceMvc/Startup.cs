using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MarketplaceMvc.Startup))]
namespace MarketplaceMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
