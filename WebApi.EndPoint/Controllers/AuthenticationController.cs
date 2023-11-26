using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.EndPoint.Models;

namespace WebApi.EndPoint.Controllers
{
    [Route("app/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        // GET: api/<AuthenticationController>
        [HttpGet]
        public ResponseModel<bool> Login()
        {
            HttpClient client = new HttpClient();
            return new ResponseModel<bool>
            {
                Model = true,
            };
        }

    }
}
