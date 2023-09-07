using Application.Library.Repositories.SEC.User.Read;
using Domain.Library.Base.IDTOs;
using Domain.Library.Entities.SEC.User.DTOs;

namespace Infrastructure.Library.Repositories.SEC.User
{
    public class GetUserRepository : IGetUserRepository
    {
        public ResultDto<UserDTO> Execute(Guid guid)
        {
            throw new NotImplementedException();
        }
    }
}
