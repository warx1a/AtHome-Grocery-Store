using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AtHomeGroceryStore.Startup))]
namespace AtHomeGroceryStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
