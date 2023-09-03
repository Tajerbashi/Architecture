using Application.Library.DatabaseContext;
using Application.Library.Repositories.SEC;

namespace Infrastructure.Library.Repositories.SEC
{
    public class RoleRepository:IRoleRepository
    {
        private readonly IDatabaseContext _context;
        public RoleRepository(IDatabaseContext context)
        {
            _context = context;
        }

        public IAddRoleService AddRoleService { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IRemoveRoleService RemoveRoleService { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IUpdateRoleService UpdateRoleService { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IGetAllRoleService GetAllRoleService { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IGetRoleService GetRoleService { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IChangeRoleService ChangeRoleService { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
