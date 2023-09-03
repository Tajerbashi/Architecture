using Application.Library.Patterns.UnitOfWork;
using Application.Library.Repositories.SEC;
using Domain.Library.Base.IDTOs;
using Domain.Library.Entities.SEC.Role.DTOs;

namespace Application.Library.Services.SEC.Roles
{
    public class AddRoleService : IAddRoleService
    {
        private readonly IUnitOfWork _unitOfWork;
        public AddRoleService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public ResultDto<RoleDTO> Execute(RoleDTO role)
        {
            throw new NotImplementedException();
        }
    }
}
