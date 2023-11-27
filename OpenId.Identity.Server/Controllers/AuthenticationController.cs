using Microsoft.AspNetCore.Mvc;
using OpenId.Identity.Server.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OpenId.Identity.Server.Controllers
{
    [Route("security/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        // GET: api/<AuthenticationController>
        [HttpGet]
        public ActionResponse<UserModel> Get()
        {
            var model = new UserModel
            {
                Email = "tajerbashi@mail.com",
                Guid = Guid.NewGuid(),
                Id = 1,
                Name = "Kamran",
                Username="Tajerbashi"
            };
            return new ActionResponse<UserModel>()
            {
                Result = model,
            };
        }

        // GET api/<AuthenticationController>/5
        [HttpGet("{id}")]
        public ActionResponse<string> Get(int id)
        {
            return new ActionResponse<string>()
            {
                Result = "",
            };
        }

        // POST api/<AuthenticationController>
        [HttpPost]
        public ActionResponse<string> Post([FromBody] string value)
        {
            return new ActionResponse<string>()
            {
                Result = "",
            };
        }

        // PUT api/<AuthenticationController>/5
        [HttpPut("{id}")]
        public ActionResponse<string> Put(int id, [FromBody] string value)
        {
            return new ActionResponse<string>()
            {
                Result = "",
            };
        }

        // DELETE api/<AuthenticationController>/5
        [HttpDelete("{id}")]
        public ActionResponse<string> Delete(int id)
        {
            return new ActionResponse<string>()
            {
                Result = "",
            };
        }
    }
}
