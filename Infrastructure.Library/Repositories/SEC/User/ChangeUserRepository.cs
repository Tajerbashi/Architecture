using Application.Library.Repositories.SEC.User.Write;
using Domain.Library.Base.IDTOs;
using Domain.Library.Entities.SEC.User.DTOs;

namespace Infrastructure.Library.Repositories.SEC.User
{
    public class ChangeUserRepository : IChangeUserRepository
    {
        public ResultDto<UserDTO> Execute(Guid guid)
        {
            throw new NotImplementedException();
        }
    }
}
