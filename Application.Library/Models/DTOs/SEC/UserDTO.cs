using Application.Library.Bases;

namespace Application.Library.Models.DTOs
{
    public class UserDTO : BaseDTO
    {
        public long ID { get; set; }
        public string Name { get; set; }
        //public Name Name { get; set; }
        public string Family { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public byte Age { get; set; }
        public long? RoleId { get; set; }
    }
}
