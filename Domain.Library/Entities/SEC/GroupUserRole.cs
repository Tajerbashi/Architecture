using Domain.Library.Bases;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities
{
    [Table("GroupUserRoles", Schema = "SEC")]
    public class GroupUserRole : BaseAuditableEntity
    {
        [ForeignKey("Group")]
        public long? GroupID { get; set; }
        public virtual Group Group { get; set; }



        [ForeignKey("UserRole")]
        public long? UserRoleID { get; set; }
        public virtual UserRole UserRole { get; set; }
    }
}
