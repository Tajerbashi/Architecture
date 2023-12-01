using External.Provider.Client.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace External.Provider.Client.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            HttpClient client = new HttpClient();
            var loggers = client.GetStringAsync("https://localhost:44331/external/Logger/ReadAll").Result;
            var result = client.GetStringAsync("https://localhost:44331/external/Authentication/Login").Result;
            var contacts = client.GetStringAsync("https://localhost:44331/external/Contact").Result;
            ViewBag.model = JsonConvert.DeserializeObject<Contact>(result);
            ViewBag.logs = JsonConvert.DeserializeObject<List<LogModel>>(loggers);
            ViewBag.contacts = JsonConvert.DeserializeObject<List<Contact>>(contacts);

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
