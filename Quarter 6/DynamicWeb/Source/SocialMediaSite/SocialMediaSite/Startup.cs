using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SocialMediaSite.Startup))]
namespace SocialMediaSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
