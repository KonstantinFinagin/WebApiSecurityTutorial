namespace SecurityPipeline.Pipeline
{
    using System;
    using System.Collections.Generic;
    using System.Security.Principal;
    using System.Threading.Tasks;
    using Microsoft.Owin;

    public class TestMiddleware
    {
        private readonly Func<IDictionary<string, object>, Task> next;

        // IDictionary is the environment
        public TestMiddleware(Func<IDictionary<string, object>, Task> next)
        {
            this.next = next;
        }

        // method that is doing the actual work
        public async Task Invoke(IDictionary<string, object> env)
        {
            var context = new OwinContext(env);

            // authentication

            // very simple katana authentication mw simulation
            context.Request.User = new GenericPrincipal(new GenericIdentity("dom"), new string[] {});

            Helper.Write("Middleware", context.Request.User);

            await this.next(env);
        }
    }
}
