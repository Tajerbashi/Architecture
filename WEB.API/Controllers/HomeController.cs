﻿using Application.Library.Models.DTOs.SEC;
using Application.Library.Services;
using Domain.Library.Entities;
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

        public ActionResult Index()
        {
            
            for (int i = 1; i < 100000; i++)
            {
                UserDTO userDTO = new UserDTO();
                userDTO.RoleId = 3;
                userDTO.Name = @$"User {i}";
                userDTO.Family = @$"Family {i}";
                userDTO.Age = 25;
                userDTO.DisplayName = @$"{userDTO.Name} : {userDTO.Family}";
                userDTO.Email = @$"User{i}@mail.com";
                userDTO.Phone = @$"0902100100{i}";
                userDTO.Address = @$"Address of user in street{i+10} block {i+2}";
                 var res =_userFacad.UserCreateService.Execute(userDTO);
                if (!res.IsSuccess)
                {
                    return StatusCode(StatusCodes.Status400BadRequest, res.Message);
                }
            }
            return StatusCode(StatusCodes.Status200OK, "Model is valid!");
        }
    }
}