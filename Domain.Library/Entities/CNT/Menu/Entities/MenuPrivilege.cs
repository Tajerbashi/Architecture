using Domain.Library.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities.CNT.Menu.Entities
{
    [Table("MenuPrivilege", Schema = "LOG")]
    public class MenuPrivilege : BaseEntity
    {
        [ForeignKey("Menu")]
        public long MenuId { get; set; }
        public Menu Menu { get; set; }




        [ForeignKey("Role")]
        public long RoleId { get; set; }
        public Role Role { get; set; }
    }
    
}
