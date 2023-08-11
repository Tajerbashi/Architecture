using Microsoft.AspNetCore.Mvc;

namespace WEB.API.Controllers
{
    public class BaseController : ControllerBase
    {
        public IActionResult Index()
        {
            return StatusCode(StatusCodes.Status200OK, "Model is valid!");
        }
    }
}
