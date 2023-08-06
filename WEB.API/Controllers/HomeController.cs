using Application.Library.Models.DTOs;
using Application.Library.Services;
using Microsoft.AspNetCore.Mvc;

namespace WEB.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserFacadRepository _userFacad;
        public HomeController(
            ILogger<HomeController> logger,
            IUserFacadRepository userFacad
            )
        {
            _logger = logger;
            _userFacad = userFacad;
        }
        [Route("Index")]
        public ActionResult Index()
        {
            //for (int i = 62600; i < 10000000; i++)
            //{
            //    UserDTO userDTO = new UserDTO();
            //    userDTO.RoleId = 3;
            //    userDTO.Name = $"User {i}";
            //    userDTO.Family = $"Family {i}";
            //    userDTO.Age = 25;
            //    userDTO.DisplayName = $"{userDTO.Name} : {userDTO.Family}";
            //    userDTO.Email = $"User{i}@mail.com";
            //    userDTO.Phone = $"09{i}";
            //    userDTO.Address = $"Address of user in street{i + 10} block {i + 2}";
            //    var res =_userFacad.UserCreateService.Execute(userDTO);
            //    if (!res.IsSuccess)
            //    {
            //        return StatusCode(StatusCodes.Status400BadRequest, res.Message);
            //    }
            //}
            return StatusCode(StatusCodes.Status200OK, "Model is valid!");
        }

        [Route("Update/{id}")]
        public ActionResult Update(long Id)
        {
            var data = _userFacad.UserGetById.Execute(Id);
            if (!data.IsSuccess)
            {
                return StatusCode(StatusCodes.Status400BadRequest, data.Message);
            }
            UserDTO userDTO = new UserDTO();
            userDTO.ID = Id;
            userDTO.RoleId = 3;
            //userDTO.Name = new Domain.Library.ValueObjects.Name.Create(($"{data.Data.Name}" ?? ""));
            userDTO.Name = $"Name {data.Data.Name}";
            userDTO.Family = $"Family {data.Data.ID}";
            userDTO.Age = 25;
            userDTO.DisplayName = $"{data.Data.Name} : {data.Data.Family}";
            userDTO.Email = $"User{data.Data.ID}@mail.com";
            userDTO.Phone = $"09020320844";
            userDTO.Address = $"Address of user in street{data.Data.ID + 10} block {data.Data.ID + 2}";
            userDTO.UpdateDate = DateTime.Now;
            userDTO.UpdateBy = 3;
            var upd =_userFacad.UserUpdateService.Execute(userDTO);
            if (!upd.IsSuccess)
            {
                return StatusCode(StatusCodes.Status400BadRequest, upd.Message);
            }
            return StatusCode(StatusCodes.Status200OK, upd);
        }

        [Route("Change/{id}")]
        public ActionResult Change(long Id)
        {
            var res = _userFacad.UserChangeService.Execute(Id);
            if (!res.IsSuccess)
            {
                return StatusCode(StatusCodes.Status400BadRequest, res.Message);
            }

            return StatusCode(StatusCodes.Status200OK, res);
        }

        [Route("Delete/{id}")]
        public ActionResult Delete(long Id)
        {
            var res = _userFacad.UserDeleteService.Execute(Id);
            if (!res.IsSuccess)
            {
                return StatusCode(StatusCodes.Status400BadRequest, res.Message);
            }

            return StatusCode(StatusCodes.Status200OK, res);
        }

        [Route("GetAll")]
        public ActionResult GetAll()
        {
            var res = _userFacad.UserGetAll.Execute();
            if (!res.IsSuccess)
            {
                return StatusCode(StatusCodes.Status400BadRequest, res.Message);
            }
            return StatusCode(StatusCodes.Status200OK, "Model is valid!");
        }
        [Route("Get/{id}")]
        public ActionResult Get(long id)
        {
            var res = _userFacad.UserGetById.Execute(id);
            if (!res.IsSuccess)
            {
                return StatusCode(StatusCodes.Status400BadRequest, res.Message);
            }
            return StatusCode(StatusCodes.Status200OK, res);
        }
    }
}