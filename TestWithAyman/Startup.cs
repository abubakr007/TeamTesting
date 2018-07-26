using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestWithAyman.Startup))]
namespace TestWithAyman
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
