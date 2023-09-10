using Application.Library.Repositories.SEC.User.CQRS;

namespace Application.Library.Repositories.SEC.User.UnitOfWork
{
    public interface IUserRepository
    {
        IUserReadRepository UserReadRepository { get; set; }
        IUserWriteRepository UserWriteRepository { get; set; }
    }
}
