using Application.Library.Patterns.CQRS.UserServices;
using Application.Library.Patterns.UnitOfWork;
using Application.Library.Repositories.SEC;
using Application.Library.Services.SEC.Users;
using Infrastructure.Library.DatabaseContextDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Library.Repositories.SEC.Users.Read
{
    public class UserReadRepository : IUserReadRepository
    {
        private readonly DatabaseContext _context;
        public UserReadRepository(DatabaseContext context)
        {
            _context = context;
        }
        public IGetAllUserService GetAllUserService { get => new GetAllUserService(_context); set => throw new NotImplementedException(); }
        public IGetUserService GetUserService { get => new GetUserService(_context); set => throw new NotImplementedException(); }
    }
}
