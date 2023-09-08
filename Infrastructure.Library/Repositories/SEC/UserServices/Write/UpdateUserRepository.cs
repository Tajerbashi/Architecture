using Application.Library.Repositories.SEC.User.Write;
using Domain.Library.Base.IDTOs;
using Domain.Library.Entities.SEC.User.DTOs;
using Infrastructure.Library.DatabaseContextDb;

namespace Infrastructure.Library.Repositories.SEC.UserServices.Write
{
    public class UpdateUserRepository : IUpdateUserRepository
    {
        private readonly DatabaseContext _context;
        public UpdateUserRepository(DatabaseContext context)
        {
            _context = context;
        }

        public ResultDto<UserDTO> Execute(long guid, UserDTO userDTO)
        {
            throw new NotImplementedException();
        }
    }
}
