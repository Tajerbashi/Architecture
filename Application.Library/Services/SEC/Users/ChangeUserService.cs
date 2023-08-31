using Application.Library.Patterns.UnitOfWork;
using Application.Library.Repositories.SEC;

namespace Application.Library.Services.SEC.Users
{
    public class ChangeUserService : IChangeUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ChangeUserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public bool Execute(Guid guid)
        {
            throw new NotImplementedException();
        }
    }
}
