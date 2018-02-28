using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GymP.Startup))]
namespace GymP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
