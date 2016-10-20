using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DevApp.Startup))]
namespace DevApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
