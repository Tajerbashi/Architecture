using Application.Library.Repositories.SEC.User.Read;

namespace Application.Library.Repositories.SEC.User.CQRS
{
    public interface IUserReadRepository
    {
        IGetAllUserRepository GetAllUserRepository { get; set; }
        IGetUserRepository GetUserRepository { get; set; }
    }
}
