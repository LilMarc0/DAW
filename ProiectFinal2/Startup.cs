using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProiectFinal2.Startup))]
namespace ProiectFinal2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
