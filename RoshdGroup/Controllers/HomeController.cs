using DeskShiraz;
using Microsoft.AspNetCore.Mvc;
using RoshdGroup.Context;
using RoshdGroup.Models;
using RoshdGroup.ViewModels.Teachers;
using System;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Security.Cryptography.Xml;

namespace RoshdGroup.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
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