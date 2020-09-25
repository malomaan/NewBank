using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewBankWEB.Startup))]
namespace NewBankWEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
