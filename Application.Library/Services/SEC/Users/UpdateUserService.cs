using Application.Library.Patterns.UnitOfWork;
using Application.Library.Repositories.SEC;
using Domain.Library.Base.IDTOs;
using Domain.Library.Entities.SEC.User.DTOs;

namespace Application.Library.Services.SEC.Users
{
    public class UpdateUserService : IUpdateUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        public UpdateUserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ResultDto<UserDTO> Execute(Guid guid, UserDTO user)
        {
            return _unitOfWork.UserRepository.UserWriteRepository.UpdateUserService.Execute(guid, user);
        }

    }
}
