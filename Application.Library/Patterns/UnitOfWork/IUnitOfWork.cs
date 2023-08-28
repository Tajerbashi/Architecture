using Application.Library.Repositories.LOG;
using Application.Library.Repositories.RPT;
using Application.Library.Repositories.SEC;

namespace Application.Library.Patterns.UnitOfWork
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; set; }
        IRoleRepository RoleRepository { get; set; }
        ISystemLoggerRepository SystemLoggerRepository { get; set; }
        IGeneralReportsRepository GeneralReportsRepository { get; set; }
        void Save();
    }
}
