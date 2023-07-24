using Domain.Library.Bases;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities
{
    [Table("Groups", Schema = "SEC")]
    public class Group : BaseAuditableEntity
    {
        public string Title { get; set; }

        public virtual ICollection<GroupUserRole> GroupUserRoles { get; set; }
    }
}
