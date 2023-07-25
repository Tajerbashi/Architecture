using Application.Library.Bases.BaseService;
using Application.Library.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Library.Services
{
    public interface IRoleFacad
    {
        CreateRoleService CreateRoleService { get; }
    }
    public class RoleFacad : IRoleFacad
    {
        private readonly IBaseService _context;
        public RoleFacad(
            IBaseService context
            )
        {
            _context = context;
        }

        public CreateRoleService CreateRoleService => throw new NotImplementedException();


        //private CreateRoleService _createRoleService;
        //public CreateRoleService CreateRoleService
        //{
        //    get
        //    {
        //        return _createRoleService == _createRoleService ?? new CreateRoleService(_context);
        //    }
        //}
    }
}
