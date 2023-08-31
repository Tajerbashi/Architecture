using Domain.Library.Base.IDTOs;

namespace Application.Library.Repositories.SEC
{
    public interface IRemoveUserService
    {
        ResultDto<string> Execute(Guid guid);
    }
}
