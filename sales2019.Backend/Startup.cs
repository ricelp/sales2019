using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sales2019.Backend.Startup))]
namespace sales2019.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
