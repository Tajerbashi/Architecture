using Domain.Library.Base.IDTOs;
using Microsoft.AspNetCore.Mvc;

namespace Web.API.Controllers.Template
{
   
    [Route("tk/Dashboard")]
    [ApiController]
    public class DashboardController : Controller
    {
        /// <summary>
        /// Index of Dashboard Controller
        /// </summary>
        /// <remarks>Awesomeness!</remarks>
        /// <response code="200">Dashboard created</response>
        /// <response code="400">Dashboard has missing/invalid values</response>
        /// <response code="500">Oops! Can't create your Dashboard right now</response>
        [HttpGet("Create")]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(typeof(IDictionary<string, string>), 400)]
        [ProducesResponseType(500)]
        public async Task<ResultDto<string>> Create() => new ResultDto<string>();
    }
}
