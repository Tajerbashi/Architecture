using Microsoft.AspNetCore.Mvc;

namespace SwaggerWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {

        private readonly ILogger<HomeController> _logger;
        public HomeController(
            ILogger<HomeController> logger
            )
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Read");
        }
        [HttpPost]
        public IActionResult Post()
        {
            return Ok("Create");
        }
        [HttpPut]
        public IActionResult Put()
        {
            return Ok("Update");
        }
        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok("Delete");
        }
    }
}
