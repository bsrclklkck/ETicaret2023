using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ETicaret2023.Startup))]
namespace ETicaret2023
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
