using Domain.Library.Base.IDTOs;
using Domain.Library.Entities.SEC.User.DTOs;

namespace Application.Library.Repositories.SEC
{
    public interface IGetUserService
    {
        ResultDto<UserDTO> Execute(Guid guid);
    }
}
