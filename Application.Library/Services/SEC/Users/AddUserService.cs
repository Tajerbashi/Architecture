﻿using Application.Library.Patterns.UnitOfWork;
using Application.Library.Repositories.SEC;
using Domain.Library.Base.IDTOs;
using Domain.Library.Entities.SEC.User.DTOs;

namespace Application.Library.Services.SEC.Users
{
    public class AddUserService : IAddUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        public AddUserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        ResultDto<UserDTO> IAddUserService.Execute(UserDTO user)
        {
            throw new NotImplementedException();
        }
    }
}