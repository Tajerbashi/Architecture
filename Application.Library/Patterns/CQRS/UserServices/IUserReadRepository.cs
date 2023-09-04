using Application.Library.Repositories.SEC;

namespace Application.Library.Patterns.CQRS.UserServices
{
    public interface IUserReadRepository
    {
        IGetAllUserService GetAllUserService { get; set; }
        IGetUserService GetUserService { get; set; }
    }
}
