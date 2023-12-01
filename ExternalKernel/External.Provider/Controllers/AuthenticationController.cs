using External.Provider.ContextData;
using External.Provider.Models;
using External.Provider.Models.Enums;
using Microsoft.AspNetCore.Mvc;

namespace External.Provider.Controllers
{
    [ApiController]
    [Route("external/[controller]/[action]")]
    public class AuthenticationController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            ApplicationContext.LogData.Add(new LogModel
            {
                Id = (long)new Random().Next(),
                Service = "Authentication",
                Method = "Login",
                Param = new { },
                RequestTime = DateTime.Now,
                ResponseTime = DateTime.Now,
                Url = "https://localhost:8080/Home/Index",
                Username = "Admin",
                Model = HttpMode.Request

            });
            return Ok();
        }

    }
}
