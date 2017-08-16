using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(asap.Startup))]
namespace asap
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
