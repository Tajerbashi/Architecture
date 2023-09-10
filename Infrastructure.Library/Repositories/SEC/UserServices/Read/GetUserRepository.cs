using Application.Library.Repositories.SEC.User.Read;
using Domain.Library.Base.IDTOs;
using Domain.Library.Entities.SEC.User.DTOs;
using Infrastructure.Library.DatabaseContextDb;

namespace Infrastructure.Library.Repositories.SEC.UserServices.Read
{
    public class GetUserRepository : IGetUserRepository
    {
        private readonly DatabaseContext _context;

        public GetUserRepository(DatabaseContext context)
        {
            _context = context;
        }
        public ResultDto<UserDTO> Execute(Guid guid)
        {
            throw new NotImplementedException();
        }
    }
}
