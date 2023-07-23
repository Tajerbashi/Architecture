using Domain.Library.Bases;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities
{
    [Table("Users", Schema = "SEC")]
    public class User : BaseAuditableEntity
    {
    }
}
