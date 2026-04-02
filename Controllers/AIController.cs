using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AIMeetingAssist.Controllers
{
   [Route("api/[controller]")]

    [ApiController]
    public class AIController : ControllerBase
    {
        [HttpGet("test")]
        public IActionResult Test()
        {
            return Ok("Api is Working");
        }
    }
}
