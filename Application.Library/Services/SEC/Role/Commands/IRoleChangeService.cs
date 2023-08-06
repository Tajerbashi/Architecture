using Application.Library.Bases;
using Application.Library.DatabaseContext;
using Application.Library.Models.Views;

namespace Application.Library.Services
{
    public interface IRoleChangeService
    {
        ResultView<RoleView> Execute(long Id);
    }
    public class RoleChangeService : IRoleChangeService
    {
        private readonly IDatabaseContext _context;
        public RoleChangeService(IDatabaseContext context)
        {
            _context = context;
        }
        public ResultView<RoleView> Execute(long Id)
        {
            return new ResultView<RoleView>()
            {
                IsSuccess = true,
                Message = new List<string>()
                {
                    "با موفقیت ذخیره شده",
                },
                Data = new RoleView()
                {

                }
            };
        }
    }
}
