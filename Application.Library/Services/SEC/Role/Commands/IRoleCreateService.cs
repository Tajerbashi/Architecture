using Application.Library.Bases;
using Application.Library.DatabaseContext;
using Application.Library.Models.DTOs;

namespace Application.Library.Services
{
    public interface IRoleCreateService
    {
        ResultView<long> Execute(RoleDTO model);
    }
    public class RoleCreateService : IRoleCreateService
    {
        private readonly IDatabaseContext _context;
        public RoleCreateService(IDatabaseContext context)
        {
            _context = context;
        }
        public ResultView<long> Execute(RoleDTO model)
        {
            return new ResultView<long>()
            {
                IsSuccess = true,
                Message = new List<string>()
                {
                    "با موفقیت ذخیره شده",
                },
                Data = 0
            };
        }
    }
}
