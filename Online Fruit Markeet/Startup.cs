using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Online_Fruit_Markeet.Startup))]
namespace Online_Fruit_Markeet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
