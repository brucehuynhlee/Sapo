using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sapo.Startup))]
namespace Sapo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
