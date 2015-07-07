using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Demo2.Startup))]
namespace Demo2
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
