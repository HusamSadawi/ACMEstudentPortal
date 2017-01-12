using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ACMEstudentPortal.Startup))]
namespace ACMEstudentPortal
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
