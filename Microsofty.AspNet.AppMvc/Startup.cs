using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Microsofty.AspNet.AppMvc.Startup))]
namespace Microsofty.AspNet.AppMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
