using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MdReazulIslam_298652.Startup))]
namespace MdReazulIslam_298652
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
