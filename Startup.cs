using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab1MvcAuth.Startup))]
namespace Lab1MvcAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
