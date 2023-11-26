using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.EndPoint.Models;

namespace WebApi.EndPoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        public AuthenticationController() { }

        public ResponseModel<bool> Login()
        {
            return new ResponseModel<bool>
            {
                Model = true,
            };
        }

    }
}
