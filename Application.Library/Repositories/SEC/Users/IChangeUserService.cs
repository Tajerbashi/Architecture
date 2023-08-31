namespace Application.Library.Repositories.SEC
{
    public interface IChangeUserService
    {
        bool Execute(Guid guid);
    }
}
