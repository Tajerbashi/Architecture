using Domain.Library.Bases;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities
{
    [Table("Groups", Schema = "SEC")]
    public class Group : BaseAuditableEntity
    {
    }
}
