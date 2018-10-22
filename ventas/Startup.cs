using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ventas.Startup))]
namespace ventas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
