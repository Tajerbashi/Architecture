using Application.Library.Repositories.SEC.User.Write;
using Domain.Library.Base.IDTOs;
using Domain.Library.Entities.SEC.User.DTOs;

namespace Infrastructure.Library.Repositories.SEC.User
{
    public class DeleteUserRepository : IDeleteUserRepository
    {
        public ResultDto<UserDTO> Execute(long guid)
        {
            throw new NotImplementedException();
        }
    }
}
