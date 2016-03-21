namespace SecurityPipeline.Pipeline
{
    using System.Web.Http;
    using System.Web.Http.Controllers;

    public class TestAuthorizationFilterAttribute : AuthorizeAttribute
    {
        protected override bool IsAuthorized(HttpActionContext actionContext)
        {
            // custom authorization

            Helper.Write("AuthorizationFilter", actionContext.RequestContext.Principal);

            return true;

            return base.IsAuthorized(actionContext);
        }
    }
}
