using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Polito.Startup))]
namespace Polito
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
