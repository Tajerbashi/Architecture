using Application.Library.Repositories.SEC.User.UnitOfWork;

namespace Application.Library.Patterns.UnitOfWork
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; set; }
        void Save();
    }
}
