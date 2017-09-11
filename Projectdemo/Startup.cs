using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Projectdemo.Startup))]
namespace Projectdemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
