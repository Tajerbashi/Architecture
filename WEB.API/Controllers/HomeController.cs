using Application.Library.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WEB.API.Models;

namespace WEB.API.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RoleService _roleService;

        public HomeController(
            ILogger<HomeController> logger,
            RoleService roleService
            )
        {
            _logger = logger;
            _roleService = roleService;
        }

        public IActionResult Index()
        {
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