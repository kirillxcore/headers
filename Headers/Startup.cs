using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Headers.Startup))]
namespace Headers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
