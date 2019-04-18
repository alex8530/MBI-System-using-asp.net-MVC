using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MBI_ASP.Startup))]
namespace MBI_ASP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
