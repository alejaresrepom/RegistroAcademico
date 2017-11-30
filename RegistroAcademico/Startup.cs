using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RegistroAcademico.Startup))]
namespace RegistroAcademico
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
