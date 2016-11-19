using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SoftUniBlog.Startup))]
namespace SoftUniBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
