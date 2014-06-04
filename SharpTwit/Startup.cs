using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Flutter.Startup))]
namespace Flutter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
