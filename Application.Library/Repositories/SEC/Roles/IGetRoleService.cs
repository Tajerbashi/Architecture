using Domain.Library.Base.IDTOs;
using Domain.Library.Entities.SEC.Role.DTOs;

namespace Application.Library.Repositories.SEC
{
    public interface IGetRoleService
    {
        ResultDto<RoleDTO> Execute(Guid guid);

    }
}
