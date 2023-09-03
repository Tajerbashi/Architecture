using Application.Library.Patterns.UnitOfWork;
using Application.Library.Repositories.LOG;
using Application.Library.Repositories.RPT;
using Application.Library.Repositories.SEC;
using Infrastructure.Library.DatabaseContextDb;
using Infrastructure.Library.Repositories.LOG;
using Infrastructure.Library.Repositories.RPT;
using Infrastructure.Library.Repositories.SEC;

namespace Infrastructure.Library.Pattern
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;
        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }
        public IUserRepository UserRepository { get => new UserRepository(_context); set => throw new NotImplementedException(); }
        public IRoleRepository RoleRepository { get => new RoleRepository(_context); set => throw new NotImplementedException(); }
        public ISystemLoggerRepository SystemLoggerRepository { get => new SystemLoggerRepository(); set => throw new NotImplementedException(); }
        public IGeneralReportsRepository GeneralReportsRepository { get => new GeneralReportRepository(); set => throw new NotImplementedException(); }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
