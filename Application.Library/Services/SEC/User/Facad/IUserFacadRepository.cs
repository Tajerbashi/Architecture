using Application.Library.DatabaseContext;

namespace Application.Library.Services
{
    public interface IUserFacadRepository
    {
        UserCreateService UserCreateService { get; }
        UserUpdateService UserUpdateService { get; }
        UserDeleteService UserDeleteService { get; }
        UserChangeService UserChangeService { get; }
        IUserGetAll UserGetAll { get; }
        IUserGetById UserGetById { get; }
    }
    public class UserFacadRepository : IUserFacadRepository
    {
        private readonly IDatabaseContext _context;
        public UserFacadRepository(IDatabaseContext context)
        {
            _context = context;
        }

        private UserCreateService _userCreateService;
        public UserCreateService UserCreateService
        {
            get
            {
                return _userCreateService = _userCreateService ?? new UserCreateService(_context);
            }
        }

        private UserUpdateService _userUpdateService;
        public UserUpdateService UserUpdateService
        {
            get
            {
                return _userUpdateService = _userUpdateService ?? new UserUpdateService(_context);
            }
        }

        private UserDeleteService _userDeleteService;
        public UserDeleteService UserDeleteService
        {
            get
            {
                return _userDeleteService = _userDeleteService ?? new UserDeleteService(_context);
            }
        }

        private UserChangeService _userChangeService;
        public UserChangeService UserChangeService
        {
            get
            {
                return _userChangeService = _userChangeService ?? new UserChangeService(_context);
            }
        }
        private IUserGetAll _userGetAll;
        public IUserGetAll UserGetAll
        {
            get
            {
                return _userGetAll = _userGetAll ?? new UserGetAll(_context);
            }
        }
        private IUserGetById _userGetById;
        public IUserGetById UserGetById
        {
            get
            {
                return _userGetById = _userGetById ?? new UserGetById(_context);
            }
        }
    }
}
