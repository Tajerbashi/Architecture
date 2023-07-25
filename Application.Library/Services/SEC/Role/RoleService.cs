using Application.Library.Bases.BaseService;
using Application.Library.DatabaseContext;
using Application.Library.DTOs;
using Application.Library.Views;
using Domain.Library.Entities;

namespace Application.Library.Services
{
    public sealed class RoleService : GenericService<Role, RoleDTO, RoleView>
    {
        public RoleService(IDatabaseContext context) : base(context)
        {
        }
    }
}
