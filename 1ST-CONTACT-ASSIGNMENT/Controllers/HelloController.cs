using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _1ST_CONTACT_ASSIGNMENT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello World";
        }

    }
}
