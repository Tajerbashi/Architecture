namespace Application.Library.Repositories.SEC
{
    public interface IUserRepository
    {
        IAddUserService AddUserService { get; set; }
        IRemoveUserService RemoveUserService { get; set; }
        IUpdateUserService UpdateUserService { get; set; }
        IGetAllUserService GetAllUserService { get; set; }
        IGetUserService GetUserService { get; set; }
        IChangeUserService ChangeUserService { get; set; }
    }
}
