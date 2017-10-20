using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(E_commerce_site.Startup))]
namespace E_commerce_site
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
