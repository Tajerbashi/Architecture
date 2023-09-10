using Domain.Library.Base.IDTOs;
using Domain.Library.Entities.SEC.User.DTOs;

namespace Application.Library.Repositories.SEC.User.Write
{
    public interface IAddUserRepository
    {
        ResultDto<long> Execute(UserDTO userDTO);
    }

}
