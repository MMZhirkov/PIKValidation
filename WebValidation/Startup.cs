using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(WebValidation.Startup))]

namespace WebValidation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
