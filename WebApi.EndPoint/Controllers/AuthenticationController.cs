using Application.Library.Repositories.SEC.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using WebApi.EndPoint.Models;

namespace WebApi.EndPoint.Controllers
{
    [Route("app/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        // GET: api/<AuthenticationController>
        [HttpGet]
        public ResponseModel<UserDTO> Login()
        {
            HttpClient client = new HttpClient();
            var result = client.GetStringAsync("https://localhost:7022/security/Authentication").Result;
            var model = JsonConvert.DeserializeObject<UserDTO>(result);
            if (model == null)
            {
                return new ResponseModel<UserDTO>
                {
                    Model = null,
                };
            }
            return new ResponseModel<UserDTO>
            {
                Model = model,
            };
        }

    }
}
