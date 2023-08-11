using Microsoft.AspNetCore.Mvc;

namespace WEB.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : Controller    //ControllerBase
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(
            ILogger<HomeController> logger
            )
        {
            _logger = logger;
        }
        [Route("/")]
        [Route("Index")]
        public ActionResult Index()
        {
            return View();
            //return StatusCode(StatusCodes.Status200OK, "Model is valid!");
        }

    }
}