using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebBone.Startup))]
namespace WebBone
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
