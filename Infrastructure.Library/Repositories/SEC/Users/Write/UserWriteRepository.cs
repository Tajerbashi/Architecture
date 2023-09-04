using Application.Library.Patterns.CQRS.UserServices;
using Application.Library.Repositories.SEC;
using Application.Library.Services.SEC.Users;
using Infrastructure.Library.DatabaseContextDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Library.Repositories.SEC.Users.Write
{
    public class UserWriteRepository : IUserWriteRepository
    {
        public UserWriteRepository()
        {
            
        }
        public IAddUserService AddUserService { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IRemoveUserService RemoveUserService { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IUpdateUserService UpdateUserService { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IChangeUserService ChangeUserService { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
