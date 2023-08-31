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
        ResultDto<UserDTO> IUpdateUserService.Execute(UserDTO user, Guid guid)
        {
            throw new NotImplementedException();
        }
    }
}
