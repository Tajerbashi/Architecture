using Application.Library.Repositories.SEC.User.Write;

namespace Application.Library.Repositories.SEC.User.CQRS
{
    public interface IUserWriteRepository
    {
        IAddUserRepository AddUserRepository { get; set; }
        IDeleteUserRepository DeleteUserRepository { get; set; }
        IUpdateUserRepository UpdateUserRepository { get; set; }
        IChangeUserRepository ChangeUserRepository { get; set; }
    }
}
