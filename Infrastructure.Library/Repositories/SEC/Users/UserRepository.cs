using Application.Library.Patterns.CQRS.UserServices;
using Application.Library.Repositories.SEC;
using Infrastructure.Library.DatabaseContextDb;
using Infrastructure.Library.Repositories.SEC.Users.Read;

namespace Infrastructure.Library.Repositories.SEC
{
    public class UserRepository : IUserRepository
    {
        private readonly DatabaseContext _context;
        public UserRepository(DatabaseContext context)
        {

            _context = context;

        }
        public IUserReadRepository UserReadRepository { get => new UserReadRepository(_context); set => throw new NotImplementedException(); }
        public IUserWriteRepository UserWriteRepository { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
