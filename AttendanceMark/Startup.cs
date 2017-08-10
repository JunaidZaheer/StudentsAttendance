using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AttendanceMark.Startup))]
namespace AttendanceMark
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
