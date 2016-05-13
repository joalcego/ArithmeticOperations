using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ArithmeticOperations.WebClient.Startup))]
namespace ArithmeticOperations.WebClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
