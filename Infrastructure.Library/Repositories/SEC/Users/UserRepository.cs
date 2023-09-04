using Application.Library.DatabaseContext;
using Application.Library.Patterns.CQRS.UserServices;
using Application.Library.Repositories.SEC;

namespace Infrastructure.Library.Repositories.SEC
{
    public class UserRepository : IUserRepository
    {
        private readonly IDatabaseContext _context;
        public UserRepository(IDatabaseContext context)
        {
            _context = context;
        }

        public IUserReadRepository UserReadRepository { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IUserWriteRepository UserWriteRepository { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
