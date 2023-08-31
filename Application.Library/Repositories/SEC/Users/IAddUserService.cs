﻿using Domain.Library.Base.IDTOs;
using Domain.Library.Entities.SEC.User.DTOs;

namespace Application.Library.Repositories.SEC
{
    public interface IAddUserService
    {
        ResultDto<UserDTO> Execute(UserDTO user);

    }
}
