using Application.Library.Bases;
using Application.Library.DatabaseContext;
using Application.Library.Models.DTOs;
using Application.Library.Validators;
using Domain.Library.Entities;

namespace Application.Library.Services
{
    public interface IUserCreateService
    {
        ResultView<long> Execute(UserDTO model);
    }
    public class UserCreateService : IUserCreateService
    {
        private readonly IDatabaseContext _context;
        public UserCreateService(IDatabaseContext context)
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
            User entity = new User()
            {
                Name = model.Name,
                Family=model.Family,
                Age=model.Age,
                Email=model.Email,
                DisplayName=model.DisplayName,
                Phone=model.Phone,
                Address=model.Address,
                CreateDate=model.CreateDate,
                CreatedByUserRoleID = 1
            };

            _context.Users.Add(entity);


            if (model.RoleId != null)
            {
                var Role = _context.Roles.Find(model.RoleId);
                //var Roles = _context.Roles.ToList();

                UserRole userRole = new UserRole()
                {
                    User = entity,
                    Role = Role
                };
                _context.UserRoles.Add(userRole);
            }

            _context.SaveChanges();

            var ID = _context.Users
                     .OrderByDescending(m => m.ID)
                     .FirstOrDefault().ID;


            return new ResultView<long>()
            {
                IsSuccess = true,
                Data = ID,
                Message = new List<string>()
                {
                    "با موفقیت ذخیره شده",
                }
            };
        }
    }
}
