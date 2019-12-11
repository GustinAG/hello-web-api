using System.Web.Http;
using System.Web.Http.Cors;

namespace HelloApi.Controllers
{
    [EnableCors("*", "*", "*")]
    public class DefaultController : ApiController
    {
        // Based on: https://docs.microsoft.com/en-us/dotnet/api/system.reflection.assemblyname.version?view=netframework-4.8
        private static string Version => typeof(DefaultController).Assembly.GetName().Version.ToString();

        [Route("")]
        public string Get() => $"Hello World! - version {Version} - via CI/CD pipeline!";
    }
}
