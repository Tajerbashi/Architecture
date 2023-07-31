using Application.Library.Bases;
using Application.Library.DatabaseContext;
using Application.Library.Models.DTOs.SEC;
using Application.Library.Models.Views.SEC;
using Application.Library.Validators;
using Domain.Library.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Application.Library.Services
{
    public interface IUserUpdateService
    {
        ResultView<long> Execute(UserDTO model);
    }
    public class UserUpdateService : IUserUpdateService
    {
        private readonly IDatabaseContext _context;
        public UserUpdateService(IDatabaseContext context)
        {
            _context = context;
        }
        public ResultView<long> Execute(UserDTO model)
        {
            //  Fluent Validation
            var validator = new UserValidator();
            var result = validator.Validate(model);

            if (!result.IsValid)
            {
                List<string> errors = new List<string>();
                foreach (var error in result.Errors)
                {
                    errors.Add(error.ToString());
                }
                return new ResultView<long>()
                {
                    IsSuccess = false,
                    Data = -1,
                    Message = errors
                };
            }

            User entity = new User();
            entity.CreatedByUserRoleID = model.RoleId.Value;
            entity.Name = model.Name;
            entity.Family = model.Family;
            entity.Age = 25;
            entity.DisplayName = model.DisplayName;
            entity.Email = model.Email;
            entity.Phone = model.Phone;
            entity.Address = model.Address;
            entity.UpdateDate = model.UpdateDate;
            _context.Users.Update(entity);

            _context.SaveChanges();
            return new ResultView<long>()
            {
                IsSuccess = true,
                Message = new List<string>()
                {
                    "با موفقیت بروزرسانی شد",
                },
                Data = model.ID
            };
        }
    }
}
