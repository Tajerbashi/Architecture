using Application.Library.DatabaseContext;
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
        public IAddUserService AddUserService { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IRemoveUserService RemoveUserService { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IUpdateUserService UpdateUserService { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IGetAllUserService GetAllUserService { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IGetUserService GetUserService { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IChangeUserService ChangeUserService { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
