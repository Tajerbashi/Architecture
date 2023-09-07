using Application.Library.Repositories.SEC.User.CQRS;
using Application.Library.Repositories.SEC.User.Write;
using Infrastructure.Library.DatabaseContextDb;

namespace Infrastructure.Library.Repositories.SEC.User
{
    public class UserWriteRepository : IUserWriteRepository
    {
        private readonly DatabaseContext _contextRead;
        public UserWriteRepository(DatabaseContext contextRead)
        {
            _contextRead = contextRead;
        }
        public IAddUserRepository AddUserRepository { get => new AddUserRepository(); set => throw new NotImplementedException(); }
        public IDeleteUserRepository DeleteUserRepository { get => new DeleteUserRepository(); set => throw new NotImplementedException(); }
        public IUpdateUserRepository UpdateUserRepository { get => new UpdateUserRepository(); set => throw new NotImplementedException(); }
        public IChangeUserRepository ChangeUserRepository { get => new ChangeUserRepository(); set => throw new NotImplementedException(); }
    }
}
