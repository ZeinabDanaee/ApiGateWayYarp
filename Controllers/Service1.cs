using Microsoft.AspNetCore.Mvc;

namespace service1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Service1 : ControllerBase
    {
        [HttpGet("/Service1")]
        public string service1()
        {
            return "service1";
        }
    }
}
