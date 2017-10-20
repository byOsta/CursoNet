using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CursoNET.Startup))]
namespace CursoNET
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
