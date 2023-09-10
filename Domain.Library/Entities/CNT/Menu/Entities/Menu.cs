using Domain.Library.Base.IEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities.CNT.Menu.Entities
{
    [Table("Menus", Schema = "CNT")]
    public class Menu : GeneralEntity
    {
        public string Link { get; set; }
        public string Icon { get; set; }
        public string URL { get; set; }
        public long ParentID { get; set; }

        public ICollection<MenuPrivilege> MenuPrivileges { get; set; }
    }
}
