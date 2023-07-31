using Application.Library.Bases;
using Application.Library.DatabaseContext;
using Application.Library.Models.Views.SEC;
using System.Collections.Generic;

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
            List < UserView > list = _context.Users.Where(c => c.IsDeleted == false && c.IsActive == true).Select(c => new UserView
            {
                ID = c.ID,
                Name = c.Name,
                Family=c.Family,
                Age=c.Age,
                Email=c.Email,
                DisplayName=c.DisplayName,
                Phone=c.Phone,
                Address=c.Address,
                CreateDate=c.CreateDate,
                CreatedByUserRoleID = 1,
                UpdateDate=c.UpdateDate,
                DeleteDate=c.DeleteDate,
                DeleteBy=c.DeleteByUserID,
                UpdateBy=c.UpdateByUserRoleID

            }).ToList();
            return new ResultView<List<UserView>>()
            {
                IsSuccess = true,
                Message = new List<string>()
                {
                    "با موفقیت ذخیره شده",
                },
                Data = list
            };
        }
    }
}
