using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BusinessTechSolutionsWebSite.Startup))]
namespace BusinessTechSolutionsWebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
