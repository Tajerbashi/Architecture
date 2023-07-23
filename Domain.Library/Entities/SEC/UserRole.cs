using Domain.Library.Bases;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities
{
    [Table("UserRoles", Schema = "SEC")]
    public class UserRole : BaseAuditableEntity
    {
    }
}
