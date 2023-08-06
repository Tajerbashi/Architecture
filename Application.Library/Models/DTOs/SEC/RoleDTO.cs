using Application.Library.Bases;

namespace Application.Library.Models.DTOs
{
    public class RoleDTO : BaseDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
