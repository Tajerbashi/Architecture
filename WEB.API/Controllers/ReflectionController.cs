using Application.Library.Services;
using Domain.Library.Bases;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace WEB.API.Controllers
{
    [Route("api/[controller]")]//api/Reflection/[action]
    [ApiController]
    public class ReflectionController : BaseController
    {
        private readonly ILogger<ReflectionController> _logger;
        public ReflectionController(
            ILogger<ReflectionController> logger
            )
        {
            _logger = logger;
        }

        [Route("GetClassReflection")]
        public IActionResult GetClassReflection()
        {


            Type type = typeof(BaseEntity);

            PropertyInfo[] propertyInfo = type.GetProperties();

            Console.WriteLine("The list of properties of the Customer class are:--");
            List<PropertyInfo> properties = new List<PropertyInfo>();
            foreach (PropertyInfo pInfo in propertyInfo)
            {
                properties.Add(pInfo);
            }
            return Ok();
        }
    }
}
