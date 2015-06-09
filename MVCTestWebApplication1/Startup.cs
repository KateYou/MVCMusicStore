using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCTestWebApplication1.Startup))]
namespace MVCTestWebApplication1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
