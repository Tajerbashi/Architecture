using Application.Library.Repositories.SEC.User.Read;
using Domain.Library.Base.IDTOs;
using Domain.Library.Entities.SEC.User.DTOs;
using Infrastructure.Library.DatabaseContextDb;

namespace Infrastructure.Library.Repositories.SEC.User
{
    public class GetAllUserRepository : IGetAllUserRepository
    {
        private readonly DatabaseContext _contextRead;
        public GetAllUserRepository(DatabaseContext context)
        {
            _contextRead = context;
        }
        public ResultDto<List<UserDTO>> Execute()
        {
            throw new NotImplementedException();
        }
    }
}
