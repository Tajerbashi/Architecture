using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using System;
using WEB.API.Services;

namespace WEB.API.Controllers
{
    [Route("api/[controller]")]//api/Attribute/[action]
    [ApiController]
    public class AttributeController : Controller
    {

        [Route("Index")]
        public IActionResult Index()
        {
            //ReadService readService = new ReadService();
            //readService.GetName();

            var personType = typeof(ReadService);
            var author = personType.GetCustomAttributes();
            if (author != null)
            {
                Console.WriteLine("Type Author: {0}", author);
            }
            return View();
        }
    }
}
