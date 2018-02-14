using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bitcoin.Startup))]
namespace Bitcoin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
