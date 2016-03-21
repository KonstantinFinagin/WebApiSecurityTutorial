namespace SecurityPipeline
{
    using System.Web.Http;
    using Owin;
    using SecurityPipeline.Pipeline;

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var configuration = new HttpConfiguration();
            configuration.Routes.MapHttpRoute(
                "default",
                "api/{controller}");

            // configuration.Filters.Add...

            // adding additional middleware
            app.Use(typeof (TestMiddleware));

            app.UseWebApi(configuration);
        }
    }
}
