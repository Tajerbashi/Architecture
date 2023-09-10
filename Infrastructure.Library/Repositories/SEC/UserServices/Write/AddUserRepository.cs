using Application.Library.Repositories.SEC.User.Write;
using Domain.Library.Base.IDTOs;
using Domain.Library.Entities;
using Domain.Library.Entities.SEC.User.DTOs;
using Infrastructure.Library.DatabaseContextDb;

namespace Infrastructure.Library.Repositories.SEC.UserServices.Write
{
    public class AddUserRepository : IAddUserRepository
    {
        private readonly DatabaseContext _context;
        public AddUserRepository(DatabaseContext context)
        {
            _context = context;
        }
        public ResultDto<long> Execute(UserDTO userDTO)
        {
            var entity = new User
            {
                Name = userDTO.Name,
                Family = userDTO.Family,
                Email = userDTO.Email,
                Username = userDTO.Username,
                Password = userDTO.Password,
                CreateByUserRoleID = userDTO.CreateByUserRoleID,
                CreateDate = DateTime.Now,
                DeleteByUserRoleID = userDTO.DeleteByUserRoleID,
                DeleteDate = DateTime.Now.AddYears(-10),
                Guid = new Guid(),
                IsActive = true,
                IsDeleted = false,
            };
            var result = _context.Users.Add(entity);
            return new ResultDto<long>()
            {
                IsSuccess = true,
                Message = "با موفقیت ذخیره شد",
                Data = result.Entity.ID
            };
        }
    }
}
