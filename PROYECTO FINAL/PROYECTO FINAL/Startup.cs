using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PROYECTO_FINAL.Startup))]
namespace PROYECTO_FINAL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
