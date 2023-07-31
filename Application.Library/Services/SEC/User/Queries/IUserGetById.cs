using Application.Library.Bases;
using Application.Library.DatabaseContext;
using Application.Library.Models.Views.SEC;

namespace Application.Library.Services
{
    public interface IUserGetById
    {
        ResultView<UserView> Execute(long Id);

    }
    public class UserGetById : IUserGetById
    {
        private readonly IDatabaseContext _context;
        public UserGetById(IDatabaseContext context)
        {
            _context = context;
        }
        public ResultView<UserView> Execute(long Id)
        {
            var model = _context.Users.FirstOrDefault(c => c.ID == Id && c.IsDeleted == false && c.IsActive == true);

            if (model != null)
            {
                UserView view = new UserView()
                {
                    ID = model.ID,
                    Name = model.Name,
                    Family=model.Family,
                    Age=model.Age,
                    Email=model.Email,
                    DisplayName=model.DisplayName,
                    Phone=model.Phone,
                    Address=model.Address,
                    CreateDate=model.CreateDate,
                    CreatedByUserRoleID = model.CreatedByUserRoleID,
                    UpdateDate=model.UpdateDate,
                    DeleteDate=model.DeleteDate,
                    DeleteBy=model.DeleteByUserID,
                    UpdateBy=model.UpdateByUserRoleID
                };
                return new ResultView<UserView>()
                {
                    IsSuccess = true,
                    Message = new List<string>()
                {
                    "با موفقیت دریافت شد",
                },
                    Data = view
                };
            }
            return new ResultView<UserView>()
            {
                IsSuccess = false,
                Message = new List<string>()
                {
                    "داده مورد نظر پیدا نشد",
                },
                Data = null
            };
        }
    }
}
