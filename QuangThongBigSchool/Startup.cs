using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuangThongBigSchool.Startup))]
namespace QuangThongBigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
