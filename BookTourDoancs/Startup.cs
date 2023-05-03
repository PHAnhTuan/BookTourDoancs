using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookTourDoancs.Startup))]
namespace BookTourDoancs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
