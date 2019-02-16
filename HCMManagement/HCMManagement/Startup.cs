using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HCMManagement.Startup))]
namespace HCMManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
