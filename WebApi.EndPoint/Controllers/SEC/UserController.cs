using Application.Library.Repositories.SEC;
using Application.Library.Repositories.SEC.DTO;
using Infrastructure.Library.Services.SEC.UserServices;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace WebApi.EndPoint.Controllers.SEC
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly UserService _userService;
        public UserController(UserService userService)
        {
            _userService = userService;
        }
        [HttpPost]
        public IActionResult Create(UserDTO userDTO)
        {
            userDTO.Claims = new List<Claim>
            {
                new Claim("Name",userDTO.FirstName),
                new Claim("Family",userDTO.LastName),
                new Claim("Username",userDTO.UserName),
                new Claim("Phone",userDTO.PhoneNumber),
            };
            _userService.Create(userDTO);
            return View();
        }
        [HttpPost("List")]
        public IActionResult Create(List<UserDTO> userDTOs)
        {
            return View();
        }
        [HttpGet("{id}")]
        public IActionResult Read(long id)
        {
            return View();
        }
        [HttpGet("{guid}")]
        public IActionResult Read(Guid guid)
        {
            return View();
        }
        [HttpPatch("{id}")]
        public IActionResult Update(UserDTO userDTO, long id)
        {
            return View();
        }
        [HttpPatch("{guid}")]
        public IActionResult Update(UserDTO userDTO, Guid guid)
        {
            return View();
        }
        [HttpDelete("{guid}")]
        public IActionResult Delete(Guid guid)
        {
            return View();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            return View();
        }
        [HttpGet]
        public IActionResult ReadAll()
        {
            return View();
        }
        [HttpPut("{guid}")]
        public IActionResult Replace(UserDTO userDTO, Guid guid)
        {
            return View();
        }
        [HttpPut("{id}")]
        public IActionResult Replace(UserDTO userDTO, long id)
        {
            return View();
        }
    }
}
