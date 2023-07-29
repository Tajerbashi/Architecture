using Application.Library.Bases;
using Application.Library.DatabaseContext;
using Application.Library.Models.DTOs.SEC;
using Application.Library.Models.Views.SEC;

namespace Application.Library.Services
{
    public interface IRoleUpdateService
    {
        ResultView<RoleView> Execute(RoleDTO model);
    }
    public class RoleUpdateService : IRoleUpdateService
    {
        private readonly IDatabaseContext _context;
        public RoleUpdateService(IDatabaseContext context)
        {
            _context = context;
        }
        public ResultView<RoleView> Execute(RoleDTO model)
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
