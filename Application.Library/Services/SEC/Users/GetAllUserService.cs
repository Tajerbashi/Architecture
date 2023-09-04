using Application.Library.Patterns.UnitOfWork;
using Application.Library.Repositories.SEC;
using Domain.Library.Base.IDTOs;
using Domain.Library.Entities.SEC.User.DTOs;

namespace Application.Library.Services.SEC.Users
{
    public class GetAllUserService : IGetAllUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        public GetAllUserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ResultDto<List<UserDTO>> Execute()
        {
            return _unitOfWork.UserRepository.UserReadRepository.GetAllUserService.Execute();
        }
    }
}
