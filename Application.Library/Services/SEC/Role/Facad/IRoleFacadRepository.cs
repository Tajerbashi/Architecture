using Application.Library.DatabaseContext;

namespace Application.Library.Services
{
    public interface IRoleFacadRepository
    {
        RoleCreateService RegisterUserService { get; }
        RoleUpdateService RoleUpdateService { get; }
        RoleDeleteService RoleDeleteService { get; }
        RoleChangeService RoleChangeService { get; }
        IRoleGetAll RoleGetAll { get; }
        IRoleGetById RoleGetById { get; }
    }
    public class RoleFacadRepository : IRoleFacadRepository
    {
        private readonly IDatabaseContext _context;
        public RoleFacadRepository(IDatabaseContext context)
        {
            _context = context;
        }

        private RoleCreateService _roleCreateService;
        public RoleCreateService RegisterUserService
        {
            get
            {
                return _roleCreateService = _roleCreateService ?? new RoleCreateService(_context);
            }
        }

        private RoleUpdateService _roleUpdateService;
        public RoleUpdateService RoleUpdateService
        {
            get
            {
                return _roleUpdateService = _roleUpdateService ?? new RoleUpdateService(_context);
            }
        }

        private RoleDeleteService _roleDeleteService;
        public RoleDeleteService RoleDeleteService
        {
            get
            {
                return _roleDeleteService = _roleDeleteService ?? new RoleDeleteService(_context);
            }
        }

        private RoleChangeService _roleChangeService;
        public RoleChangeService RoleChangeService
        {
            get
            {
                return _roleChangeService = _roleChangeService ?? new RoleChangeService(_context);
            }
        }
        private IRoleGetAll _roleGetAll;
        public IRoleGetAll RoleGetAll
        {
            get
            {
                return _roleGetAll = _roleGetAll ?? new RoleGetAll(_context);
            }
        }
        private IRoleGetById _roleGetById;
        public IRoleGetById RoleGetById
        {
            get
            {
                return _roleGetById = _roleGetById ?? new RoleGetById(_context);
            }
        }
    }
}