using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjetoDDD.MVC.Startup))]
namespace ProjetoDDD.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
