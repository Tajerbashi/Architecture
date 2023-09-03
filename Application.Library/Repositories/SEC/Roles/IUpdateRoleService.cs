using Domain.Library.Base.IDTOs;
using Domain.Library.Entities.SEC.Role.DTOs;

namespace Application.Library.Repositories.SEC
{
    public interface IUpdateRoleService
    {
        ResultDto<RoleDTO> Execute(Guid guid,RoleDTO role);

    }
}
