using Domain.Library.Bases;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities
{
    [Table("GroupUserRoles", Schema = "SEC")]
    public class GroupUserRole : BaseAuditableEntity
    {
    }
}
