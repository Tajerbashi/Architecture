using Application.Library.Bases;
using Application.Library.DatabaseContext;

namespace Application.Library.Services
{
    public interface IUserChangeService
    {
        ResultView<long> Execute(long Id);
    }
    public class UserChangeService : IUserChangeService
    {
        private readonly IDatabaseContext _context;
        public UserChangeService(IDatabaseContext context)
        {
            _context = context;
        }
        public ResultView<long> Execute(long Id)
        {

            var data = _context.Users.Find(Id);
            var role = _context.UserRoles.FirstOrDefault(c => c.UserID == data.ID);

            role.IsActive = data.IsActive ? false : true;
            data.IsActive = data.IsActive ? false : true;

            _context.Users.Update(data);
            _context.SaveChanges();
            return new ResultView<long>()
            {
                IsSuccess = true,
                Message = new List<string>()
                {
                    "با موفقیت تغییر کرد",
                },
                Data = Id
            };
        }
    }
}
