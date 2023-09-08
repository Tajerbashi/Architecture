using Application.Library.Patterns.UnitOfWork;
using Domain.Library.Entities.SEC.User.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Web.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUnitOfWork _unitOfWork;
        public UserController(
            ILogger<UserController> logger,
            IUnitOfWork unitOfWork
            )
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public IActionResult Create()
        {
            var result =_unitOfWork.UserRepository.UserWriteRepository.AddUserRepository.Execute(new UserDTO()
            {
                Name="کامران",
                Family="تاجرباشی",
                Email="kamrantajerbashi@gmail.com",
                Username="Tajerbashi",
                Password="Tajerbashi",
                CreateByUserRoleID=1,
            });
            _unitOfWork.Save();
            return Ok(new
            {
                result = result.Message,
                statusCode = StatusCode(200),
            });
        }
        [HttpPut]
        public IActionResult Update()
        {
            return Ok();
        }
        [HttpGet]
        public IActionResult Read()
        {
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok();
        }
    }
}
