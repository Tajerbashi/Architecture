using Application.Library.Repositories.SEC.User.Write;
using Domain.Library.Base.IDTOs;
using Domain.Library.Entities.SEC.User.DTOs;
using Infrastructure.Library.DatabaseContextDb;

namespace Infrastructure.Library.Repositories.SEC.UserServices.Write
{
    public class ChangeUserRepository : IChangeUserRepository
    {
        private readonly DatabaseContext _context;
        public ChangeUserRepository(DatabaseContext context)
        {
            _context = context;
        }
        public ResultDto<UserDTO> Execute(Guid guid)
        {
            throw new NotImplementedException();
        }
    }
}
