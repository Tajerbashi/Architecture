using Application.Library.Repositories.SEC.User.CQRS;
using Application.Library.Repositories.SEC.User.UnitOfWork;
using Infrastructure.Library.DatabaseContextDb;
using Infrastructure.Library.Repositories.SEC.UserServices.CQRS;

namespace Infrastructure.Library.Repositories.SEC.UserServices.UnitOfWork
{
    public class UserRepository : IUserRepository
    {
        private readonly DatabaseContext _contextRead;
        private readonly DatabaseContext _contextWrite;
        public UserRepository(DatabaseContext contextRead, DatabaseContext contextWrite)
        {
            _contextRead = contextRead;
            _contextWrite = contextWrite;
        }

        public IUserReadRepository UserReadRepository { get => new UserReadRepository(_contextRead); set => new UserReadRepository(_contextRead); }
        public IUserWriteRepository UserWriteRepository { get => new UserWriteRepository(_contextWrite); set => new UserWriteRepository(_contextWrite); }
    }
}
