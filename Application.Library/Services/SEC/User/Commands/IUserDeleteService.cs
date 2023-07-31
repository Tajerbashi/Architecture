using Application.Library.Bases;
using Application.Library.DatabaseContext;
using Application.Library.Models.Views.SEC;

namespace Application.Library.Services
{
    public interface IUserDeleteService
    {
        ResultView<long> Execute(long Id);
    }
    public class UserDeleteService : IUserDeleteService
    {
        private readonly IDatabaseContext _context;
        public UserDeleteService(IDatabaseContext context)
        {
            _context = context;
        }
        public ResultView<long> Execute(long Id)
        {
            var data = _context.Users.Find(Id);
            var role = _context.UserRoles.FirstOrDefault(c => c.UserID == data.ID);

            role.IsActive = false;
            role.IsDeleted = true;
            data.IsActive = false;
            data.IsDeleted = true;

            _context.Users.Update(data);
            _context.SaveChanges();
            return new ResultView<long>()
            {
                IsSuccess = true,
                Message = new List<string>()
                {
                    "با موفقیت حذف شد",
                },
                Data = Id
            };
        }
    }
}
