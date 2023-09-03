namespace Application.Library.Repositories.SEC
{
    public interface IRoleRepository
    {
        IAddRoleService AddRoleService { get; set; }
        IRemoveRoleService RemoveRoleService { get; set; }
        IUpdateRoleService UpdateRoleService { get; set; }
        IGetAllRoleService GetAllRoleService { get; set; }
        IGetRoleService GetRoleService { get; set; }
        IChangeRoleService ChangeRoleService { get; set; }
    }
}
