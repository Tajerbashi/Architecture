using Application.Library.Repositories.SEC.User.CQRS;
using Application.Library.Repositories.SEC.User.Write;
using Infrastructure.Library.DatabaseContextDb;
using Infrastructure.Library.Repositories.SEC.UserServices.Write;

namespace Infrastructure.Library.Repositories.SEC.UserServices.CQRS
{
    public class UserWriteRepository : IUserWriteRepository
    {
        private readonly DatabaseContext _contextRead;
        public UserWriteRepository(DatabaseContext contextRead)
        {
            _contextRead = contextRead;
        }
        public IAddUserRepository AddUserRepository { get => new AddUserRepository(_contextRead); set => throw new NotImplementedException(); }
        public IDeleteUserRepository DeleteUserRepository { get => new DeleteUserRepository(_contextRead); set => throw new NotImplementedException(); }
        public IUpdateUserRepository UpdateUserRepository { get => new UpdateUserRepository(_contextRead); set => throw new NotImplementedException(); }
        public IChangeUserRepository ChangeUserRepository { get => new ChangeUserRepository(_contextRead); set => throw new NotImplementedException(); }
    }
}
