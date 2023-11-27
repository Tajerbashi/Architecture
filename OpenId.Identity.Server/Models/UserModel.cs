namespace OpenId.Identity.Server.Models
{
    public class UserModel
    {
        public Guid Guid { get; set; }
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }

    }
}
