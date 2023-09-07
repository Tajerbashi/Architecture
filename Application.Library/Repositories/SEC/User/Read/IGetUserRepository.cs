using Domain.Library.Base.IDTOs;
using Domain.Library.Entities.SEC.User.DTOs;

namespace Application.Library.Repositories.SEC.User.Read
{
    public interface IGetUserRepository
    {
        ResultDto<UserDTO> Execute(Guid guid);
    }
}
