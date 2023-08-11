using Microsoft.AspNetCore.Mvc;
using WEB.API.IOCContainer;

namespace WEB.API.Controllers
{
    [Route("api/[controller]")]     //api/IoCContainer/[action]
    [ApiController]
    public class IoCContainerController : ControllerBase
    {
        [Route("Index")]
        public IActionResult Index()
        {
            Buy buy = new Buy(new Mellat());
            var item = buy.Pay();
            var upd = new
            {
                IsSuccess=false,
                Message=$"Result: {item}"
            };
            if (!upd.IsSuccess)
            {
                return StatusCode(StatusCodes.Status400BadRequest, upd.Message);
            }
            return StatusCode(StatusCodes.Status200OK, upd);
        }
    }
}
