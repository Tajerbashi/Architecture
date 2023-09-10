using Application.Library.Repositories.SEC.User.CQRS;
using Application.Library.Repositories.SEC.User.Read;
using Infrastructure.Library.DatabaseContextDb;
using Infrastructure.Library.Repositories.SEC.UserServices.Read;

namespace Infrastructure.Library.Repositories.SEC.UserServices.CQRS
{
    public class UserReadRepository : IUserReadRepository
    {
        private readonly DatabaseContext _contextRead;
        public UserReadRepository(DatabaseContext contextRead)
        {
            _contextRead = contextRead;
        }
        public IGetAllUserRepository GetAllUserRepository { get => new GetAllUserRepository(_contextRead); set => throw new NotImplementedException(); }
        public IGetUserRepository GetUserRepository { get => new GetUserRepository(_contextRead); set => throw new NotImplementedException(); }
    }
}
