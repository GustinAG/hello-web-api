using System.Web.Http;

namespace HelloApi.Controllers
{
    public class DefaultController : ApiController
    {
        [Route("")]
        public string Get() => "Hello World!";
    }
}
