using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LigaFutbol.Startup))]
namespace LigaFutbol
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
