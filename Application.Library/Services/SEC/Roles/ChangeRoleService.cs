using Application.Library.Patterns.UnitOfWork;
using Application.Library.Repositories.SEC;
using Domain.Library.Base.IDTOs;
using Domain.Library.Entities.SEC.Role.DTOs;

namespace Application.Library.Services.SEC.Roles
{
    public class ChangeRoleService : IChangeRoleService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ChangeRoleService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ResultDto<RoleDTO> Execute(Guid guid)
        {
            throw new NotImplementedException();
        }
    }
}
