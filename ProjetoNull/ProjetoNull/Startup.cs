using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjetoNull.Startup))]
namespace ProjetoNull
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
