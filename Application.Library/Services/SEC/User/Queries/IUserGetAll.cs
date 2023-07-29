using Application.Library.Bases;
using Application.Library.DatabaseContext;
using Application.Library.Models.Views.SEC;

namespace Application.Library.Services
{
    public interface IUserGetAll
    {
        ResultView<List<UserView>> Execute();

    }
    public class UserGetAll : IUserGetAll
    {
        private readonly IDatabaseContext _context;
        public UserGetAll(IDatabaseContext context)
        {
            _context = context;
        }
        public ResultView<List<UserView>> Execute()
        {
            return new ResultView<List<UserView>>()
            {
                IsSuccess = true,
                Message = new List<string>()
                {
                    "با موفقیت ذخیره شده",
                },
                Data = new List<UserView>()
            };
        }
    }
}
