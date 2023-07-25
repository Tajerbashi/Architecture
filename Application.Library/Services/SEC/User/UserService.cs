using Application.Library.Bases.BaseService;
using Application.Library.DatabaseContext;
using Application.Library.DTOs;
using Application.Library.Views;
using Domain.Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Library.Services
{
    public sealed class UserService : GenericService<User, UserDTO, UserView>
    {
        public UserService(IDatabaseContext context) : base(context)
        {
        }
    }
}
