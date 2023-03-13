using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LTK_1911060124_THLTW.Startup))]
namespace LTK_1911060124_THLTW
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
