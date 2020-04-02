using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EntityFramworkDatabaseFirst.Startup))]
namespace EntityFramworkDatabaseFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
