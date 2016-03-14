using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExperimentProject.Startup))]
namespace ExperimentProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
