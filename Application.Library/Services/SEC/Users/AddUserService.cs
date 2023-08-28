using Application.Library.Patterns.UnitOfWork;
using Application.Library.Repositories.SEC;

namespace Application.Library.Services.SEC.Users
{
    public class AddUserService : IAddUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        public AddUserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void Execute()
        {

            _unitOfWork.Save();
        }
    }
}
