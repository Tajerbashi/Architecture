using Application.Library.Bases;
using Application.Library.DatabaseContext;
using Application.Library.Models.DTOs.SEC;
using Application.Library.Models.Views.SEC;

namespace Application.Library.Services
{
    public interface IUserUpdateService
    {
        ResultView<UserView> Execute(UserDTO model);
    }
    public class UserUpdateService : IUserUpdateService
    {
        private readonly IDatabaseContext _context;
        public UserUpdateService(IDatabaseContext context)
        {
            _context = context;
        }
        public ResultView<UserView> Execute(UserDTO model)
        {
            return new ResultView<UserView>()
            {
                IsSuccess = true,
                Message = new List<string>()
                {
                    "با موفقیت ذخیره شده",
                },
                Data = new UserView()
                {

                }
            };
        }
    }
}
