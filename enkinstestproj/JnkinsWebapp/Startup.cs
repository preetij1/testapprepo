using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JnkinsWebapp.Startup))]
namespace JnkinsWebapp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
