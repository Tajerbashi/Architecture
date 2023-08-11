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


            //  Interface and Class is Save with this Type
            Resolver resolver = new Resolver();
            resolver.Register<IPayment,Mellat>();
            resolver.Register<Buy,Buy>();

            ////  With Out Resolver
            //Buy buy = new Buy(new Mellat());
            //var item = buy.Pay();
            var item = resolver.Resolve<Buy>();
            var text = item.Pay();
            var upd = new
            {
                IsSuccess=false,
                Message=$"Result: {text}"
            };
            if (!upd.IsSuccess)
            {
                return StatusCode(StatusCodes.Status400BadRequest, upd.Message);
            }
            return StatusCode(StatusCodes.Status200OK, upd);
        }
    }
}
