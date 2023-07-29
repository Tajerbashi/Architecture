using Application.Library.Bases;
using Application.Library.DatabaseContext;
using Application.Library.Models.Views.SEC;

namespace Application.Library.Services
{
    public interface IRoleGetAll
    {
        ResultView<List<RoleView>> Execute();

    }
    public class RoleGetAll : IRoleGetAll
    {
        private readonly IDatabaseContext _context;
        public RoleGetAll(IDatabaseContext context)
        {
            _context = context;
        }
        public ResultView<List<RoleView>> Execute()
        {

            return new ResultView<List<RoleView>>()
            {
                IsSuccess = true,
                Message = new List<string>()
                {
                    "با موفقیت ذخیره شده",
                },
                Data = new List<RoleView>()
            };
        }
    }
}
