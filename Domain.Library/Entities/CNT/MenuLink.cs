using Domain.Library.Bases;

namespace Domain.Library.Entities.CNT
{
    public class MenuLink : BaseAuditableEntity
    {
        public long? ParentId { get; set; }
        public string Action { get; set; }
        public string Icon { get; set; }
        public string Color { get; set; }
        public string Link { get; set; }
        public string Title { get; set; }
    }
}
