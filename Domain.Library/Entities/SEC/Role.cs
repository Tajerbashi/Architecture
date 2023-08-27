using Domain.Library.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities.SEC
{
    [Table("Roles", Schema = "SEC")]
    public class Role : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
