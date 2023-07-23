using Domain.Library.Bases;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities
{
    [Table("Roles", Schema = "SEC")]
    public class Role : BaseAuditableEntity
    {
    }
}
