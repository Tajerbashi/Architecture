using Domain.Library.Base;
using Domain.Library.Base.IEntities;
using Domain.Library.Entities.CNT.Menu.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities
{
    [Table("Roles", Schema = "SEC")]
    public class Role : GeneralEntity
    {
        public ICollection<UserRole> UserRoles { get; set; }
        public ICollection<MenuPrivilege> MenuPrivileges { get; set; }
    }
}
