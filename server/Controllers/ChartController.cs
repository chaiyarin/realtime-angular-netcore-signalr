using Microsoft.AspNetCore.Mvc;

namespace server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChartController : ControllerBase
    {
        public ChartController()
        {

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { Text = "API Can Be Use"});
        }
    }
}