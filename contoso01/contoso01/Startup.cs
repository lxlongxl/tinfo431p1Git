using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(contoso01.Startup))]
namespace contoso01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
