using Application.Library.Repositories.SEC.User.CQRS;
using Application.Library.Repositories.SEC.User.Read;
using Infrastructure.Library.DatabaseContextDb;

namespace Infrastructure.Library.Repositories.SEC.User
{
    public class UserReadRepository : IUserReadRepository
    {
        private readonly DatabaseContext _contextRead;
        public UserReadRepository(DatabaseContext contextRead)
        {
            _contextRead = contextRead;
        }
        public IGetAllUserRepository GetAllUserRepository { get => new GetAllUserRepository(_contextRead); set => throw new NotImplementedException(); }
        public IGetUserRepository GetUserRepository { get => new GetUserRepository(); set => throw new NotImplementedException(); }
    }
}
