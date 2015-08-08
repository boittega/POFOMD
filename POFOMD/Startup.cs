using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(POFOMD.Startup))]
namespace POFOMD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
