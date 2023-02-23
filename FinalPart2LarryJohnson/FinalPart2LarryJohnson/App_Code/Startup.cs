using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinalPart2LarryJohnson.Startup))]
namespace FinalPart2LarryJohnson
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
