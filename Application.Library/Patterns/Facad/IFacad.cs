using Application.Library.Repositories.SEC;

namespace Application.Library.Patterns.Facad
{
    public interface IFacad
    {
        IUserRepository UserRepository { get; }
    }
}
