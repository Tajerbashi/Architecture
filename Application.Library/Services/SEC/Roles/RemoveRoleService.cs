using Application.Library.Patterns.UnitOfWork;
using Application.Library.Repositories.SEC;
using Domain.Library.Base.IDTOs;

namespace Application.Library.Services.SEC.Roles
{
    public class RemoveRoleService : IRemoveRoleService
    {
        private readonly IUnitOfWork _unitOfWork;
        public RemoveRoleService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ResultDto<string> Execute(Guid guid)
        {
            throw new NotImplementedException();
        }
    }
}
