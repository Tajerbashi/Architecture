using Application.Library.Patterns.UnitOfWork;
using Application.Library.Repositories.SEC.User.UnitOfWork;
using Infrastructure.Library.DatabaseContextDb;
using Infrastructure.Library.Repositories.SEC.User;

namespace Infrastructure.Library.Pattern
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _contextRead;
        private readonly DatabaseContext _contextWrite;
        public UnitOfWork(DatabaseContext context, DatabaseContext contextWrite)
        {
            _contextRead = context;
            _contextWrite = contextWrite;
        }

        public IUserRepository UserRepository { get => new UserRepository(_contextRead,_contextWrite); set => new UserRepository(_contextRead,_contextWrite); }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
