using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LastBox.Startup))]
namespace LastBox
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
