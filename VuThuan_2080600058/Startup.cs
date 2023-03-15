using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VuThuan_2080600058.Startup))]
namespace VuThuan_2080600058
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
