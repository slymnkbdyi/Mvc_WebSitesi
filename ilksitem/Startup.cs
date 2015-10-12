using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ilksitem.Startup))]
namespace ilksitem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
