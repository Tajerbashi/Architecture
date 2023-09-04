using Application.Library.Patterns.UnitOfWork;
using Application.Library.Repositories.SEC;
using Domain.Library.Base.IDTOs;

namespace Application.Library.Services.SEC.Users
{
    public class RemoveUserService : IRemoveUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        public RemoveUserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ResultDto<string> Execute(Guid guid)
        {
            return _unitOfWork.UserRepository.UserWriteRepository.RemoveUserService.Execute(guid);
        }
    }
}
