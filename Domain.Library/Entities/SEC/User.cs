using Domain.Library.Bases;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities
{
    [Table("Users", Schema = "SEC")]
    public class User : BaseAuditableEntity
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
