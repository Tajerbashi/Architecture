using Application.Library.Repositories.SEC;

namespace Application.Library.Patterns.CQRS.UserServices
{
    public interface IUserWriteRepository
    {
        IAddUserService AddUserService { get; set; }
        IRemoveUserService RemoveUserService { get; set; }
        IUpdateUserService UpdateUserService { get; set; }
        IChangeUserService ChangeUserService { get; set; }
    }
}
