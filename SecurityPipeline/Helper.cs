namespace SecurityPipeline
{
    using System.Diagnostics;
    using System.Security.Principal;

    public class Helper
    {
        public static void Write(string stage, IPrincipal principal)
        {
            Debug.WriteLine("------ " + stage + " ------");
            if (principal == null ||
                principal.Identity == null ||
                !principal.Identity.IsAuthenticated)
            {
                Debug.WriteLine("anonymous user");
            }
            else
            {
                Debug.WriteLine("user: " + principal.Identity.Name);
            }

            Debug.WriteLine("\n");
        }
    }
}
