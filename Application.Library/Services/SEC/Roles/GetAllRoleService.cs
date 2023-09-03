using Application.Library.Patterns.UnitOfWork;
using Application.Library.Repositories.SEC;
using Domain.Library.Base.IDTOs;
using Domain.Library.Entities.SEC.Role.DTOs;

namespace Application.Library.Services.SEC.Roles
{
    public class GetAllRoleService : IGetAllRoleService
    {
        private readonly IUnitOfWork _unitOfWork;
        public GetAllRoleService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ResultDto<List<RoleDTO>> Execute()
        {
            throw new NotImplementedException();
        }
    }
}
