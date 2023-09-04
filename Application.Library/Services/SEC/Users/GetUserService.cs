using Application.Library.Patterns.UnitOfWork;
using Application.Library.Repositories.SEC;
using Domain.Library.Base.IDTOs;
using Domain.Library.Entities.SEC.User.DTOs;

namespace Application.Library.Services.SEC.Users
{
    public class GetUserService : IGetUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        public GetUserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ResultDto<UserDTO> Execute(Guid guid)
        {
            return _unitOfWork.UserRepository.UserReadRepository.GetUserService.Execute(guid);
        }
    }
}
