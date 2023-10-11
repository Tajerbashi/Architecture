using Domain.Library.Base.IDTOs;
using Microsoft.AspNetCore.Mvc;

namespace Web.API.Controllers.Base.SEC
{
    [Route("tk/User")]
    [ApiController]
    public class UserController : Controller
    {
        /// <summary>
        /// Index of User Controller
        /// </summary>
        /// <remarks>Awesomeness!</remarks>
        /// <response code="200">User created</response>
        /// <response code="400">User has missing/invalid values</response>
        /// <response code="500">Oops! Can't create your User right now</response>
        [HttpGet("Create")]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(typeof(IDictionary<string, string>), 400)]
        [ProducesResponseType(500)]
        public async Task<ResultDto<string>> Create() => new ResultDto<string>();
    }
}
