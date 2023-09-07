using Application.Library.Repositories.SEC.User.Write;
using Domain.Library.Base.IDTOs;
using Domain.Library.Entities.SEC.User.DTOs;

namespace Infrastructure.Library.Repositories.SEC.User
{
    public class AddUserRepository : IAddUserRepository
    {
        public ResultDto<UserDTO> Execute(UserDTO userDTO)
        {
            return new ResultDto<UserDTO>()
            {
                IsSuccess = true,
                Message = "",
                Data = userDTO
            };
        }
    }
}
