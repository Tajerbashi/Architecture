using Domain.Library.Base.IDTOs;
using Domain.Library.Entities.SEC.User.DTOs;

namespace Application.Library.Repositories.SEC.User.Write
{
    public interface IChangeUserRepository
    {
        ResultDto<UserDTO> Execute(Guid guid);
    }

}
