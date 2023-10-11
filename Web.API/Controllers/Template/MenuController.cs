using Domain.Library.Base.IDTOs;
using Microsoft.AspNetCore.Mvc;

namespace Web.API.Controllers.Template
{
    [Route("tk/Menu")]
    [ApiController]
    public class MenuController : Controller
    {
        /// <summary>
        /// Index of Menu Controller
        /// </summary>
        /// <remarks>Awesomeness!</remarks>
        /// <response code="200">Menu created</response>
        /// <response code="400">Menu has missing/invalid values</response>
        /// <response code="500">Oops! Can't create your Menu right now</response>
        [HttpGet("Create")]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(typeof(IDictionary<string, string>), 400)]
        [ProducesResponseType(500)]
        public async Task<ResultDto<string>> Create() => new ResultDto<string>();
    }
}
