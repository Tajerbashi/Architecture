using Domain.Library.Base.IDTOs;

namespace Domain.Library.Entities.SEC.User.DTOs
{
    public class UserDTO : BaseDTO
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool IsActive { get; set; } = true;

        public long CreateByUserRoleID { get; set; }
        public long DeleteByUserRoleID { get; set; }

        public DateTime DeleteDate { get; set; } = DateTime.Now;
    }
}
