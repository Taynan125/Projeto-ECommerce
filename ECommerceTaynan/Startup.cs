using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ECommerceTaynan.Startup))]
namespace ECommerceTaynan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
