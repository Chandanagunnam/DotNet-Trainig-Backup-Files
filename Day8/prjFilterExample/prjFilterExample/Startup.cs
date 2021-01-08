using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(prjFilterExample.Startup))]
namespace prjFilterExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
