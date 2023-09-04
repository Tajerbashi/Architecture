using Application.Library.Patterns.CQRS.UserServices;

namespace Application.Library.Repositories.SEC
{
    public interface IUserRepository
    {
        IUserReadRepository UserReadRepository { get; set; }
        IUserWriteRepository UserWriteRepository { get; set; }
    }
}
