using Application.Library.Bases;

namespace Application.Library.Models.DTOs
{
    public class UserRoleDTO : BaseDTO
    {
        public long UserID { get; set; }
        public long RoleID { get; set; }
    }
}
