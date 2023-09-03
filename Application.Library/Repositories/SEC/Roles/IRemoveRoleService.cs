using Domain.Library.Base.IDTOs;

namespace Application.Library.Repositories.SEC
{
    public interface IRemoveRoleService
    {
        ResultDto<string> Execute(Guid guid);
    }
}
