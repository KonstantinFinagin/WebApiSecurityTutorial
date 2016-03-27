using System.Reflection;
using System.Web.Http;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(WindowsAuthentication.Startup))]

namespace WindowsAuthentication
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseWebApi(WebApiConfig.Register());
        }
    }
}
