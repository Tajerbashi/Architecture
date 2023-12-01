using External.Provider.ContextData;
using External.Provider.Models;
using External.Provider.Models.Enums;
using Microsoft.AspNetCore.Mvc;

namespace External.Provider.Controllers
{
    [ApiController]
    [Route("internal/[controller]/[action]")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ApplicationContext.LogData.Add(new LogModel
            {
                Id = (long)new Random().Next(),
                Service = "Home",
                Method = "Index",
                Param = new { },
                RequestTime = DateTime.Now,
                ResponseTime = DateTime.Now,
                Url = "https://localhost:8080/Home/Index",
                Username = "Admin",
                Model = HttpMode.None

            });
            return View();
        }
       
    }
}
