using Domain.Library.Base.IDTOs;
using Microsoft.AspNetCore.Mvc;

namespace Web.API.Controllers.Admin
{
    [Route("adm-secure/Admin")]
    [ApiController]
    public class AdminController : Controller
    {
        /// <summary>
        /// Index of Admin Controller
        /// </summary>
        /// <remarks>Awesomeness!</remarks>
        /// <response code="200">Admin created</response>
        /// <response code="400">Admin has missing/invalid values</response>
        /// <response code="500">Oops! Can't create your admin right now</response>
        [HttpGet("Create")]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(typeof(IDictionary<string, string>), 400)]
        [ProducesResponseType(500)]
        public async Task<ResultDto<string>> Create() => new ResultDto<string>();
    }
}
