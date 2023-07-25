using Domain.Library.Bases;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities
{
    [Table("UserRoles", Schema = "SEC")]
    public class UserRole : BaseAuditableEntity
    {
        public long? RoleID { get; set; }
        public virtual Role Role { get; set; }


        public long? UserID { get; set; }
        public virtual User User { get; set; }

    }
}
