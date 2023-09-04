using Application.Library.Patterns.UnitOfWork;
using Application.Library.Repositories.SEC;
using Domain.Library.Base.IDTOs;
using Domain.Library.Entities.SEC.User.DTOs;

namespace Application.Library.Services.SEC.Users
{
    public class AddUserService : IAddUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        public AddUserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ResultDto<UserDTO> Execute(UserDTO user)
        {
            return _unitOfWork.UserRepository.UserWriteRepository.AddUserService.Execute(user);
        }
    }
}
