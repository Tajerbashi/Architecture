using System.Security.Claims;

namespace OpenId.Identity.Server.Models
{
    public class UserModel
    {
        public Guid Guid { get; set; }
        public long ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Claim> Claims { get; set; }
    }
}
