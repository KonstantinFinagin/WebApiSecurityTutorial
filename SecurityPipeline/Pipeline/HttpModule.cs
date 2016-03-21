namespace SecurityPipeline.Pipeline
{
    using System;
    using System.Web;

    public class HttpModule : IHttpModule
    {
        public void Init(HttpApplication context)
        {
            context.BeginRequest += ContextOnBeginRequest;
        }

        private void ContextOnBeginRequest(object sender, EventArgs eventArgs)
        {
            Helper.Write("HttpModule", HttpContext.Current.User);
        }

        public void Dispose()
        {
            
        }
    }
}
