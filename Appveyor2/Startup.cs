using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Appveyor2.Startup))]
namespace Appveyor2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
