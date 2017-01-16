using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PortalForDepartmentIS.Startup))]
namespace PortalForDepartmentIS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
