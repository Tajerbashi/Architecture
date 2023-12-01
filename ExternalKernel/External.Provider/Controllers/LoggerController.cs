using External.Provider.ContextData;
using External.Provider.Models;
using Microsoft.AspNetCore.Mvc;

namespace External.Provider.Controllers
{
    [ApiController]
    [Route("external/[controller]/[action]")]
    public class LoggerController : Controller
    {
        [HttpGet]
        public List<LogModel> ReadAll()
        {
            return ApplicationContext.LogData;
        }
    }
}
