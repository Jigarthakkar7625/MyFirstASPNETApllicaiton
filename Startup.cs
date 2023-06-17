using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyFirstASPNETApllicaiton.Startup))]
namespace MyFirstASPNETApllicaiton
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
